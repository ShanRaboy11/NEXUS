using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEXUS.Forms;
using NEXUS.Classes;
using System.Data.OleDb;

namespace NEXUS.User_Controls
{
    public partial class PaymentUC : UserControl
    {
        Driver currentDriver;
        DatabaseManagement databasemanagement = new DatabaseManagement();
        private int CurrentPassenger;
        Passenger passenger;
        private int baseAmount;
        private decimal farePrice;

        public PaymentUC(string qrInfo, int currentPassenger)
        {
            InitializeComponent();
            DecodeQRCode(qrInfo);
            SetBaseAmount();
            this.CurrentPassenger = currentPassenger;
        }


        private void DecodeQRCode(string QRInfo)
        {
            int driverID = int.Parse(QRInfo);
            this.currentDriver = databasemanagement.GetUserInfoByID(driverID);
            
            using (MemoryStream ms = new MemoryStream(currentDriver.ProfilePicture))
            {
                pbDriverPicture.Image = Image.FromStream(ms);
            }
            lblDriverName.Text = currentDriver.Name;
            lblDriverRoute.Text = currentDriver.Route;
            lblDriverStatus.Text = currentDriver.Status;
            lblPlateNum.Text = currentDriver.PlateNumber;
            lblDateTime.Text = DateTime.Now.ToString("f");
            ComboBoxList(currentDriver.Route);
        }


        private void ComboBoxList(string jeepCode)
        {
            string query = $"SELECT [{jeepCode}] FROM Routes";

            cmbxLocation.Items.Clear();
            cmbxDestination.Items.Clear();
            List<string> locationsList = new List<string>();

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        string location = row[jeepCode].ToString().Trim();
                        if (!string.IsNullOrEmpty(location) && !location.StartsWith("MSys"))
                        {
                            locationsList.Add(location);
                        }
                    }
                }
            }

            cmbxLocation.Items.AddRange(locationsList.ToArray());
            cmbxDestination.Items.AddRange(locationsList.ToArray());

            cmbxLocation.SelectedIndexChanged += (s, e) =>
            {
                string selectedLocation = cmbxLocation.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedLocation))
                {
                    cmbxDestination.Items.Remove(selectedLocation);
                }
                CalculateFare();
            };

            cmbxDestination.SelectedIndexChanged += (s, e) =>
            {
                string selectedDestination = cmbxDestination.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedDestination))
                {
                    cmbxLocation.Items.Remove(selectedDestination);
                }
                CalculateFare();
            };
        }

        private void SetBaseAmount()
        {
            if (currentDriver.JeepType == "Traditional")
                baseAmount = 13;
            else
                baseAmount = 15;
            numericMultiplier.Value = 1;
            lblAmount.Text = baseAmount.ToString("N2");
        }

        private async void CalculateFare()
        {
            if (cmbxLocation.SelectedIndex != -1 && cmbxDestination.SelectedIndex != -1)
            {
                string origin = cmbxLocation.SelectedItem.ToString();
                string destination = cmbxDestination.SelectedItem.ToString();
                string jeepCode = currentDriver.Route;

                try
                {
                    double distance = await OpenRouteService.CalculateDistance(jeepCode, origin, destination);

                    // Pricing logic
                    decimal fare = baseAmount;
                    if (distance > 4)
                    {
                        int kmBeyondMinimum = (int)Math.Floor(distance) - 4;  // This ensures you are only counting full km beyond 4
                        if (kmBeyondMinimum >= 1)
                        {
                            fare += kmBeyondMinimum;  // Add 1 peso per full km beyond 4
                        }
                    }

                    // Apply discount if eligible
                    bool isDiscountEligible = CheckDiscountEligibility();
                    if (isDiscountEligible)
                    {
                        fare *= 0.8m;
                    }

                    this.farePrice = fare * numericMultiplier.Value;
                    lblAmount.Text = this.farePrice.ToString("N2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating fare: " + ex.Message);
                }
            }
        }


        private bool CheckDiscountEligibility()
        {
            passenger = databasemanagement.GetPassengerInfoByID(CurrentPassenger);

            if (passenger.Classification != "Regular")
            {
                return true;
            }
            else 
                return false;
        }



        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            Scan scan = new Scan(CurrentPassenger);
            //Dashboard dashboard = new Dashboard(passenger);
            double passengerWallet;
            if (cmbxDestination.SelectedItem == null || cmbxLocation.SelectedItem == null)
            {
                dialogBox.ShowIcon("blank");
                scan.ShowOverlay(dialogBox, null);
                return;
            }
            else if(!databasemanagement.PaymentValid(farePrice, CurrentPassenger))
            {
                dialogBox.ShowIcon("not enough");
                scan.ShowOverlay(dialogBox, null);
                return;
            }
            Trip trip = new Trip(currentDriver.UserID, CurrentPassenger, DateTime.Now, passenger.Name,currentDriver.Name, currentDriver.Route, cmbxLocation.SelectedItem.ToString()
                , cmbxDestination.SelectedItem.ToString(), double.Parse(lblAmount.Text));
            trip.SaveTripToDatabase();
            passengerWallet = trip.DeductFareAmountToWallet();
            Form dashboardForm = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboardForm != null)
            {
                dashboardForm.Close();
            }

            // Create and open a new instance of Dashboard
            Dashboard newDashboard = new Dashboard(passenger); // Pass the necessary info
            newDashboard.Show();
            dialogBox.ShowIcon("successful payment");
            scan.ShowOverlay(dialogBox, null);
            this.Parent?.Controls.Remove(this);

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
                parentForm.Dispose(); 
            }
        }

        private void numericMultiplier_ValueChanged(object sender, EventArgs e)
        {
            if (this.baseAmount > 0) 
            {
                this.farePrice = this.baseAmount * numericMultiplier.Value;
                lblAmount.Text = this.farePrice.ToString("N2");
            }
        }
    }
}

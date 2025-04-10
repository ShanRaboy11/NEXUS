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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace NEXUS.User_Controls
{
    public partial class PaymentUC : UserControl
    {
        Driver currentDriver;
        DatabaseManagement databasemanagement = new DatabaseManagement();
        private int CurrentPassenger;
        Passenger passenger;
        private decimal baseAmount;
        private decimal farePrice;
        private bool pointsUsed = false;
        private double points = 0;

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
            string query = $"SELECT [Jeep Stop] FROM Routes WHERE [Jeep Code] = ?";

            cmbxLocation.Items.Clear();
            cmbxDestination.Items.Clear();
            List<string> locationsList = new List<string>();

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open(); // Opening the connection synchronously
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    // Add jeepCode as a parameter to avoid SQL injection
                    cmd.Parameters.AddWithValue("?", jeepCode);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            string location = row["Jeep Stop"].ToString().Trim();
                            if (!string.IsNullOrEmpty(location) && !location.StartsWith("MSys"))
                            {
                                locationsList.Add(location);
                            }
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
                    if (distance >= 5)
                    {
                        int kmBeyondMinimum = (int)Math.Floor(distance) - 4;
                        if (kmBeyondMinimum >= 1)
                        {
                            fare += kmBeyondMinimum;
                        }
                    }

                    // Apply discount if eligible
                    bool isDiscountEligible = CheckDiscountEligibility();
                    if (isDiscountEligible)
                    {
                        fare *= 0.8m;
                    }

                    this.baseAmount = fare * numericMultiplier.Value;
                    this.baseAmount = Math.Round(this.baseAmount); //rounds to the nearest whole number
                    farePrice = baseAmount;
                    lblAmount.Text = this.baseAmount.ToString("N2");
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
            double passengerWallet;

            if (cmbxDestination.SelectedItem == null || cmbxLocation.SelectedItem == null)
            {
                dialogBox.ShowIcon("blank");
                scan.ShowOverlay(dialogBox, null);
                return;
            }
            else if (!databasemanagement.PaymentValid(farePrice, CurrentPassenger))
            {
                dialogBox.ShowIcon("not enough");
                scan.ShowOverlay(dialogBox, null);
                return;
            }

            Trip trip = new Trip(currentDriver.UserID, CurrentPassenger, DateTime.Now, passenger.Name, currentDriver.Name, currentDriver.PlateNumber, currentDriver.Route, cmbxLocation.SelectedItem.ToString()
                , cmbxDestination.SelectedItem.ToString(), double.Parse(lblAmount.Text));

            if (pointsUsed)
                Trip.DeductPoints(points, CurrentPassenger);

            trip.SaveTripToDatabase();
            passengerWallet = trip.DeductFareAmountToWallet();

            dialogBox.ShowIcon("successful payment");
            var overlayForm = new Form();
            overlayForm.StartPosition = FormStartPosition.CenterScreen;
            overlayForm.FormBorderStyle = FormBorderStyle.None;
            overlayForm.Opacity = 0.5d;
            overlayForm.BackColor = Color.Black;
            overlayForm.Size = new Size(1400, 907);
            overlayForm.Location = this.Location;
            overlayForm.ShowInTaskbar = false;

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.FormClosed += (s, args) =>
                {
                    Dashboard existingDashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
                    if (existingDashboard != null)
                    {
                        existingDashboard.UpdateBalance(passenger.UserID);
                    }
                };
                overlayForm.Show();
                if (dialogBox.ShowDialog() == DialogResult.OK)
                {
                    dialogBox.Close();
                    overlayForm.Close();
                    parentForm.Close();
                }
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

        private void cbxPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPoints.Checked)
            {
                this.points = Trip.RetrievePoints(CurrentPassenger);
                decimal convertedPoints = (decimal)this.points;

                if (convertedPoints < farePrice)
                {
                    farePrice -= convertedPoints; 
                    this.points = 0; 
                }
                else
                {
                    convertedPoints -= farePrice; 
                    farePrice = 0; 
                    this.points = (double)convertedPoints;  
                }

                lblAmount.Text = farePrice.ToString("N2");  
                pointsUsed = true;
            }
            else
            {
                this.points = 0;
                CalculateFare();
                pointsUsed = false;
            }

        }

    }
}
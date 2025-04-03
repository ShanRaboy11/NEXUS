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
        public PaymentUC(string qrInfo, int currentPassenger)
        {
            InitializeComponent();
            DecodeQRCode(qrInfo);
            SetBaseAmount(13);//temporary
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

        private void CalculateFare()
        {
            int fare;
            if (cmbxLocation.SelectedIndex != -1 && cmbxDestination.SelectedIndex != -1)
            {
                int locationIndex = cmbxLocation.SelectedIndex;
                int destinationIndex = cmbxDestination.SelectedIndex;

                int indexDifference = Math.Abs(locationIndex - destinationIndex);

                if (currentDriver.JeepType == "Traditional")
                    fare = 13;
                else
                    fare = 15;

                if (indexDifference > 5)
                {
                    fare += indexDifference - 5;  
                }

                bool isDiscountEligible = CheckDiscountEligibility();  

                if (isDiscountEligible)
                {
                    fare = (int)(fare * 0.8);  
                }

                lblAmount.Text = fare.ToString();
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
            Scan scan = new Scan(CurrentPassenger); //change to userid

            if (this.passenger == null)
            {
                MessageBox.Show($"Passenger information not found [{CurrentPassenger}].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the passenger is null
            }
            if (cmbxDestination.SelectedItem == null || cmbxLocation.SelectedItem == null)
            {
                dialogBox.ShowIcon("blank");
                scan.ShowOverlay(dialogBox, null);
                return;
            }
            Trip trip = new Trip(currentDriver.UserID, CurrentPassenger, DateTime.Now, passenger.Name,currentDriver.Name, currentDriver.Route, cmbxLocation.SelectedItem.ToString()
                , cmbxDestination.SelectedItem.ToString(), double.Parse(lblAmount.Text));
            trip.SaveTripToDatabase();
            trip.SaveTransaction();

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

        private decimal baseAmount; 

        private void SetBaseAmount(decimal amount)
        {
            baseAmount = amount; 
            numericMultiplier.Value = 1; 
            lblAmount.Text = baseAmount.ToString("N2"); 
        }

        private void numericMultiplier_ValueChanged(object sender, EventArgs e)
        {
            if (baseAmount > 0) // Ensure base amount is set
            {
                decimal newAmount = baseAmount * numericMultiplier.Value;
                lblAmount.Text = newAmount.ToString("N2");
            }
        }
    }
}

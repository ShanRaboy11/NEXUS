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
        Passenger passemger;
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
            };

            cmbxDestination.SelectedIndexChanged += (s, e) =>
            {
                string selectedDestination = cmbxDestination.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedDestination))
                {
                    cmbxLocation.Items.Remove(selectedDestination);
                }
            };
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            Scan scan = new Scan(0); //change to userid
            passemger = databasemanagement.GetPassengerInfoByID(CurrentPassenger);

            if (cmbxDestination.SelectedItem == null || cmbxLocation.SelectedItem == null)
            {
                dialogBox.ShowIcon("blank");
                scan.ShowOverlay(dialogBox, null);
                return;
            }
            Trip trip = new Trip(currentDriver.UserID, CurrentPassenger, DateTime.Now, passemger.Name,currentDriver.Name, currentDriver.Route, cmbxLocation.SelectedItem.ToString()
                , cmbxDestination.SelectedItem.ToString(), double.Parse(lblAmount.Text));

            dialogBox.ShowIcon("successful payment");
            scan.ShowOverlay(dialogBox, null);
        }

        private decimal baseAmount; // Stores the initial value dynamically

        private void SetBaseAmount(decimal amount)
        {
            baseAmount = amount; // Assign the base amount dynamically
            numericMultiplier.Value = 1; // Reset the multiplier to 1
            lblAmount.Text = baseAmount.ToString("N2"); // Display initial amount
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

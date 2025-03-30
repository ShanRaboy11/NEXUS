using NEXUS.Classes;
using QRCoder;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEXUS.Forms
{
    public partial class QRCodeGeneratorform : Form
    {
        int UserID;
        public QRCodeGeneratorform(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            pbQRCode.Image = null;
        }

        private void btnQRGenerate_Click(object sender, EventArgs e)
        {
            btnSaveQR.Visible = true;
            UserInformation userInfo = GetUserInfoByID(UserID);

            if (userInfo is Driver driver)
            {
                string fullName = driver.Name;
                string plateNumber = driver.PlateNumber;
                string route = driver.Route;
                string status = driver.Status;

                // Create a structured QR Code data string
                string qrData = $"UserID:{driver.UserID};Name:{fullName};" +
                                $"Plate:{plateNumber};Route:{route};Status:{status}";

                // Generate the QR code
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                // Display the QR code in the picture box
                pbQRCode.Image = qrCodeImage;
            }
            else
            {
                MessageBox.Show("Driver information not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private UserInformation GetUserInfoByID(int userID)
        {
            string query = "SELECT ID, Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Attachment, [Plate Number], [Profile Picture], Wallet, [QR Code], Route, Status " +
                    "FROM Accounts WHERE ID = ?";


            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", userID);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int UserID = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        string password = reader.GetString(2);
                        string fullName = reader.GetString(3);
                        string email = reader.GetString(4);
                        string gender = reader.GetString(5);
                        string userType = reader.GetString(6);
                        string birthday = reader.GetString(7);
                        string attachment = reader.GetString(8);
                        string plateNumber = reader.GetString(9);
                        string profilepic = reader.GetString(10);
                        double wallet = reader.IsDBNull(11) ? 0.0 : Convert.ToDouble(reader.GetValue(11));
                        string qrcode = reader.IsDBNull(12) ? null : reader.GetString(12);
                        string route = reader.IsDBNull(13) ? null : reader.GetString(13);
                        string status = reader.IsDBNull(14) ? "Pending" : reader.GetString(14);

                        return new Driver(UserID, fullName, email, username, password, gender, userType, birthday, attachment, plateNumber, profilepic, wallet, qrcode, route, status);
                    }
                }
            }
            return null;
        }

        public void save_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            if (pbQRCode.Image == null)
            {
                dialogBox.Show();
                dialogBox.ShowIcon("no qr");
                return;
            }
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PNG|*.png" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pbQRCode.Image.Save(saveFileDialog.FileName);

                    }
                }
            }

            dialogBox.ShowIcon("save");
            dialogBox.ShowDialog();
        }

        private void Maximize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(null);

            this.Close();
            dashboard.Show();
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            if (pbQRCode.Image != null) // Ensure there's a QR code
            {
                QRCodeManager qrManager = new QRCodeManager();
                string filePath = qrManager.SaveQrCode(pbQRCode.Image, UserID);

                if (filePath != null) // Only save to database if file saving is successful
                {
                    DatabaseManagement.SaveQrCode(UserID, filePath);
                }
            }
            else
            {
                MessageBox.Show("No QR code to save!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

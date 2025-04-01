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

namespace NEXUS.Forms
{
    public partial class QRCodeGeneratorform : Form
    {
        DatabaseManagement databaseManagement = new DatabaseManagement();
        Driver userInfo;
        int UserID;
        bool qrSaved = false;

        public QRCodeGeneratorform(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.userInfo = databaseManagement.GetUserInfoByID(UserID);

            if (this.userInfo.QRCode != null)
            {
                qrSaved = true;
                LoadSavedQRCode(this.userInfo.QRCode);
            }

            btnQRGenerate.Visible = !qrSaved;
            btnSaveQR.Visible = !qrSaved;
        }

        private void btnQRGenerate_Click(object sender, EventArgs e)
        {
            btnSaveQR.Visible = true;

            string fullName = userInfo.Name;
            string plateNumber = userInfo.PlateNumber;
            string route = userInfo.Route;
            string status = userInfo.Status;

            // Create a structured QR Code data string
            string qrData = this.UserID.ToString();

            // Generate the QR code
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Display the QR code in the picture box
            pbQRCode.Image = qrCodeImage;
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
            // Convert the QR code image to a byte array
            byte[] qrCodeBytes = ImageToByteArray(pbQRCode.Image);

            if (qrCodeBytes != null)
            {
                // Call the method to save the image to the database
                userInfo.SaveImageToDatabase(qrCodeBytes, UserID);

                // Hide the buttons after saving the QR code
                btnQRGenerate.Visible = false;
                btnSaveQR.Visible = false;

                // Display a dialog box indicating the save was successful
                DialogBox dialogBox = new DialogBox();
                dialogBox.ShowIcon("qr save");
                dialogBox.ShowDialog();

                // Load the saved QR code (or refresh the UI as needed)
                LoadSavedQRCode(userInfo.QRCode);
            }
            else
            {
                MessageBox.Show("Failed to convert image to byte array.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        byte[] ImageToByteArray(Image image)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void LoadSavedQRCode(byte[] qrCodeData)
        {
            lblNoteQR.Text = "Your QR code is set! Use it for seamless trip logging and secure transactions.";
            pnlBG.Location = new Point(136, 152);
            pbQRCode.Location = new Point(167, 175);

            if (qrCodeData != null)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(qrCodeData))
                {
                    pbQRCode.Image = Image.FromStream(ms);
                }
            }
        }
    }
}

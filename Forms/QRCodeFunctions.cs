using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public class QRCodeFunctions
    {
        private PictureBox pictureBox; // Reference to a PictureBox to display the QR Code
        private Form parentForm; // Reference to the parent form
        DialogBox dialogbox = new DialogBox();

        // Constructor to initialize references
        public QRCodeFunctions(PictureBox pictureBox, Form parentForm)
        {
            this.pictureBox = pictureBox;
            this.parentForm = parentForm;
        }

        public void GenerateQRCode(string data)
        {
            try
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                if (pictureBox != null)
                {
                    pictureBox.Image = qrCodeImage; // Displays the QR code in the PictureBox
                }
                else
                {
                    MessageBox.Show("Error: PictureBox is not assigned!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("QR Code generation failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveFileDialog.FileName);

                    if (dialogbox.ShowDialog() == DialogResult.OK)
                    {
                        parentForm?.Close(); // Closes the parent form instead of 'this' (which is not a Form)
                    }
                }
            }
        }
    }
}
using QRCoder;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NEXUS.Forms
{
    public partial class QRCodeGeneratorform : Form
    {
        public QRCodeGeneratorform()
        {
            InitializeComponent();
        }

        private void btnQRGenerate_Click(object sender, EventArgs e)
        {
            string data = "https://github.com/ShanRaboy11/NEXUS";
            try
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                if (pbQRCode != null)
                {
                    pbQRCode.Image = qrCodeImage; // Displays the QR code in the PictureBox
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
            if (pbQRCode.Image == null)
            {
                MessageBox.Show("No QR Code to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbQRCode.Image.Save(saveFileDialog.FileName);
                }
            }
        }

       
    }
}

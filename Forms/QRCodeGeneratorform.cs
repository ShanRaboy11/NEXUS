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
            pbQRCode.Image = null;
        }

        private void btnQRGenerate_Click(object sender, EventArgs e)
        {
            Scan scan = new Scan(null);
            string data = "https://github.com/ShanRaboy11/NEXUS";
            ProgressBar progressBar = new ProgressBar();

            progressBar.labelChange("QR");
            scan.ShowOverlay(progressBar, null);
            this.Hide();
            progressBar.FormClosed += (s, args) => this.Show();
            progressBar.Owner = this;
            //progressBar.Show();
            

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            if(pbQRCode != null)
            {
                pbQRCode.Image = qrCodeImage; 
            }
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
    }
}

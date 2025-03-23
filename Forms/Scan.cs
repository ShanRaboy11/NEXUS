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
    public partial class Scan : Form
    {
        Dashboard dashboard = new Dashboard(null);
        public Scan()
        {
            InitializeComponent();
        }

        public void ShowOverlay(Form newForm, Form dialog)
        {
            var overlayForm = new Form();
            overlayForm.StartPosition = FormStartPosition.CenterScreen;
            overlayForm.FormBorderStyle = FormBorderStyle.None;
            overlayForm.Opacity = 0.5d;
            overlayForm.BackColor = Color.Black;
            overlayForm.Size = new Size(1400, 907);
            overlayForm.Location = this.Location;
            overlayForm.ShowInTaskbar = false;

            if (dialog != null)
            {
                overlayForm.Show();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    dialog.Close();
                    overlayForm.Close();
                }
            }
            else
            {
                overlayForm.Show();
                newForm.FormClosed += (s, args) => overlayForm.Close();
                newForm.Show();
            }
        }

        private void btnOpenQRScan_Click(object sender, EventArgs e)
        {
            QRScannerForm qRScannerForm = new QRScannerForm();
            ShowOverlay(qRScannerForm, null);
            qRScannerForm.FormClosed += (s, args) => this.Show();
        }

        private void btnUploadQR_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    btnUploadQR.SizeMode = PictureBoxSizeMode.Zoom;
                    btnUploadQR.Image = Image.FromFile(openFileDialog.FileName);
                    lblUpload.Visible = false;
                }
            }
        }
    }
}

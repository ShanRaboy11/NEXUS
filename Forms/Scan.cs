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
        //QRScannerForm qrScanner = new QRScannerForm();

        public Scan()
        {
            InitializeComponent();
        }

        public void ShowOverlay(Form newForm)
        {
            var overlayForm = new Form();
            overlayForm.StartPosition = FormStartPosition.CenterScreen;
            overlayForm.FormBorderStyle = FormBorderStyle.None;
            overlayForm.Opacity = 0.5d;
            overlayForm.BackColor = Color.Black;
            overlayForm.Size = new Size(1400, 907);
            overlayForm.Location = this.Location;
            overlayForm.ShowInTaskbar = false;

            overlayForm.Show();
            newForm.FormClosed += (s, args) => overlayForm.Close();
            newForm.Show();
        }

        private void btnOpenQRScan_Click(object sender, EventArgs e)
        {
            QRScannerForm qRScannerForm = new QRScannerForm();
            ShowOverlay(qRScannerForm);
            qRScannerForm.FormClosed += (s, args) => this.Show();
        }
    }
}

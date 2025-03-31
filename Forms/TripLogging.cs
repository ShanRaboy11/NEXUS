using NEXUS.User_Controls;
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
    public partial class TripLogging : Form
    {
        public TripLogging(int userID)
        {
            InitializeComponent();
            DisplayScanner();
        }

        private void DisplayScanner()
        {
            pnlContainerScan.Controls.Clear();

            QRScanUC qRScanUC = new QRScanUC(pnlContainerScan)
            {
                Dock = DockStyle.Fill
            };

            pnlContainerScan.Controls.Add(qRScanUC);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

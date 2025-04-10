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
        private int UserID;
        public TripLogging(int userID, string message)
        {
            InitializeComponent();
            this.UserID = userID;
            if(message == "camera")
                DisplayScanner();
        }

        private void DisplayScanner()
        {
            pnlContainerScan.Controls.Clear();

            QRScanUC qRScanUC = new QRScanUC(pnlContainerScan, UserID)
            {
                Dock = DockStyle.Fill
            };

            pnlContainerScan.Controls.Add(qRScanUC);
        }

        public void DisplayPayment(string decoded, int userID)
        {
            pnlContainerScan.Controls.Clear();

            PaymentUC payment = new PaymentUC(decoded, UserID)
            {
                Dock = DockStyle.Fill
            };

            pnlContainerScan.Controls.Add(payment);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

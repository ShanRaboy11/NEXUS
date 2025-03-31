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

namespace NEXUS.User_Controls
{
    public partial class PaymentUC : UserControl
    {
        Driver currentDriver;
        DatabaseManagement Databasemanagement;
        public PaymentUC(string qrInfo)
        {
            InitializeComponent();
            DecodeQRCode(qrInfo);
        }

        private void DecodeQRCode(string QRInfo)
        {
            //int driverID = int.Parse(QRInfo);
            //this.currentDriver = Databasemanagement.GetUserInfoByID(driverID);

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            Scan scan = new Scan(0); //change to userid

            if (cmbxDestination.SelectedItem == null || cmbxLocation.SelectedItem == null)
            {
                dialogBox.ShowIcon("blank");
                scan.ShowOverlay(dialogBox, null);
                return;
            }

            dialogBox.ShowIcon("successful payment");
            scan.ShowOverlay(dialogBox, null);
        }
    }
}

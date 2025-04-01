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
            SetBaseAmount(13);//temporary
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

        private decimal baseAmount; // Stores the initial value dynamically

        private void SetBaseAmount(decimal amount)
        {
            baseAmount = amount; // Assign the base amount dynamically
            numericMultiplier.Value = 1; // Reset the multiplier to 1
            lblAmount.Text = baseAmount.ToString("N2"); // Display initial amount
        }

        private void numericMultiplier_ValueChanged(object sender, EventArgs e)
        {
            if (baseAmount > 0) // Ensure base amount is set
            {
                decimal newAmount = baseAmount * numericMultiplier.Value;
                lblAmount.Text = newAmount.ToString("N2");
            }
        }
    }
}

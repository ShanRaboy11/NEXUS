using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }
    }
}

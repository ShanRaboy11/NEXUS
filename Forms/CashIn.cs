using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEXUS.Classes;

namespace NEXUS.Forms
{
    public partial class CashIn : Form
    {
        int userID;
        string Name;
        private bool isClicked = false;
        public CashIn(int ID, string name)
        {
            InitializeComponent();
            this.userID = ID;
            this.Name = name;
        }

        private void tbxAmount_TextChanged(object sender, EventArgs e)
        {
            int originalX = 169; // Original X position
            int shiftAmount = 20; // Pixels to shift per character
            int textLength = tbxAmount.Text.Length;

            lblPhp.Location = new Point(originalX - (shiftAmount * textLength), lblPhp.Location.Y);
        }

        private void tbxAmount_Click(object sender, EventArgs e)
        {
            if (isClicked) return;

            isClicked = true;
            tbxAmount.Text = "";
        }

        private void tbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; // Block the input
            }

            // Prevent multiple decimal points
            if (e.KeyChar == '.' && tbxAmount.Text.Contains("."))
            {
                e.Handled = true; // Block extra decimal points
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Message message = new Message("cash in");
            Scan scan = new Scan(0);

            double amount = double.Parse(tbxAmount.Text);
            DatabaseManagement.CashInLoad(this.userID, this.Name, amount);
            scan.ShowOverlay(message, null);
            this.Close();
        }
    }
}

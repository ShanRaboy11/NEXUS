using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.User_Controls
{
    public partial class TransactionsAdmin : UserControl
    {
        private FontAwesome.Sharp.IconButton selectedButton = null;
        private FontAwesome.Sharp.IconButton currentBtn;
        string filter;
        public TransactionsAdmin()
        {
            InitializeComponent();
            btnTransactions_Click(btnTransactions, EventArgs.Empty);
        }

        private void DisplayAllTransactions()
        {
            pnlContainer.Controls.Clear();

            DataGrid dataGrid = new DataGrid("Transaction")
            {
                Dock = DockStyle.Fill
            };

            pnlContainer.Controls.Add(dataGrid);
        }

        private void SelectButton(FontAwesome.Sharp.IconButton button)
        {
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.FromArgb(230, 249, 255);
                selectedButton.ForeColor = Color.Black;
                button.Font = new(button.Font.FontFamily, 18, button.Font.Style);
            }

            selectedButton = button;
            button.BackColor = Color.FromArgb(0, 229, 255);
            button.Font = new(button.Font.FontFamily, 20, button.Font.Style);
            button.ForeColor = Color.White;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            SelectButton(btnTransactions);
            DisplayAllTransactions();
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            SelectButton(btnTrips);

        }

        private void cmbxFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            this.filter = cmbxFilter.SelectedValue.ToString();
        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

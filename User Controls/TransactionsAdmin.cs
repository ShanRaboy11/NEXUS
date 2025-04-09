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
        private string query;
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
                selectedButton.BackColor = Color.FromArgb(153, 229, 255);
                selectedButton.ForeColor = Color.Black;
                selectedButton.Font = new(selectedButton.Font.FontFamily, 18, selectedButton.Font.Style);
            }

            selectedButton = button;
            selectedButton.BackColor = Color.FromArgb(0, 229, 255);
            selectedButton.ForeColor = Color.FromArgb(24, 60, 114);
            selectedButton.Font = new(selectedButton.Font.FontFamily, 24, selectedButton.Font.Style);
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

        private void DisplayDataGrid(string transactionQuery)
        {
            pnlContainer.Controls.Clear();

            DataGrid dataGrid = new DataGrid(transactionQuery)
            {
                Dock = DockStyle.Fill
            };

            pnlContainer.Controls.Add(dataGrid);
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxFilter.SelectedItem == "Cash In")
                query = "SELECT TransactionID, UserID, TransactionDate, [Full Name], Amount FROM Transactions WHERE Type = 'Cash In'";
            else if (cmbxFilter.SelectedItem == "Cash Out")
                query = "SELECT TransactionID, UserID, TransactionDate, [Full Name], Amount FROM Transactions WHERE Type = 'Cash Out'";
            else
                query = "SELECT TransactionID, UserID, TransactionDate, [Full Name], Amount FROM Transactions WHERE Type = 'Trip Payment'";
            DisplayDataGrid(query);
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            string selectedDate = dtDate.Value.ToString("MM/dd/yyyy"); // Format selected date
            query = $"SELECT TransactionID, UserID, [Full Name], Amount, Type FROM Transactions WHERE Format([TransactionDate], 'MM/dd/yyyy') = '{selectedDate}'";
            DisplayDataGrid(query);
        }
    }
}

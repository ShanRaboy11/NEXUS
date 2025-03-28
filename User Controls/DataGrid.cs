using NEXUS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.User_Controls
{
    public partial class DataGrid : UserControl
    {
        public DataGrid(string UserType)
        {
            InitializeComponent();
            DataGridDetailsDisplay(UserType);
        }

        private void DataGridDetailsDisplay(string userType)
        {
            // Ensure valid input
            if (string.IsNullOrEmpty(userType)) return;

            // Select the correct query based on user type
            string query = userType == "Passenger" ? "SELECT * FROM PassengersQuery" :
                           userType == "Driver" ? "SELECT * FROM DriversQuery" : "";

            if (string.IsNullOrEmpty(query)) return; // Exit if the userType is invalid

            // Clear existing data in DataGridView
            dgvUsers.DataSource = null;
            dgvUsers.Rows.Clear();
            dgvUsers.Columns.Clear();

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt); // Load data into DataTable
                dgvUsers.DataSource = dt; // Bind DataTable to DataGridView

                // Formatting (Optional)
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Adjust column width
                dgvUsers.DefaultCellStyle.Font = new Font("Inter", 14F, FontStyle.Regular); // Set font
                dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Inter", 16F, FontStyle.Bold); // Header font
                dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 60, 114); // Header background color
                dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Header text color
                dgvUsers.EnableHeadersVisualStyles = false; // Apply custom styling
            }
        }

    }
}

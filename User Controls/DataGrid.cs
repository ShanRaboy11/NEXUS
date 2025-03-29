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
using NEXUS.Forms;

namespace NEXUS.User_Controls
{
    public partial class DataGrid : UserControl
    {
        string userType1;
        public DataGrid(string UserType)
        {
            InitializeComponent();
            this.userType1 = UserType;
            DataGridDetailsDisplay(UserType);
        }

        private void DataGridDetailsDisplay(string userType)
        {
            
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



        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scan scan = new Scan(null);

            if (dgvUsers.SelectedRows.Count == 0)
            {
                NEXUS.Forms.Message message1 = new NEXUS.Forms.Message("select");

                scan.ShowOverlay(message1, null);
                return;
            }

            NEXUS.Forms.Message message = new NEXUS.Forms.Message("question");
            scan.ShowOverlay(message, null);
            if (message.DialogResult == DialogResult.OK)
            {
                using (OleDbConnection conn = DatabaseManagement.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        int userIdColumnIndex = -1;
                        foreach (DataGridViewColumn col in dgvUsers.Columns)
                        {
                            if (col.Name.Equals("ID", StringComparison.OrdinalIgnoreCase))
                            {
                                userIdColumnIndex = col.Index;
                                break;
                            }
                        }

                        // Get UserID value
                        object userIdValue = dgvUsers.SelectedRows[0].Cells[userIdColumnIndex].Value;


                        string query = "DELETE FROM Accounts WHERE ID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", userIdValue);
                            cmd.ExecuteNonQuery();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                return;
            }
            DataGridDetailsDisplay(userType1);
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }




        private void DataGrid_Load(object sender, EventArgs e)
        {
            dgvUsers.ClearSelection();
            dgvUsers.CurrentCell = null;
        }
    }
}

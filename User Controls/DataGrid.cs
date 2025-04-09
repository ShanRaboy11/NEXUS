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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows;

namespace NEXUS.User_Controls
{
    public partial class DataGrid : UserControl
    {
        string userType1, current;
        public DataGrid(string UserType)
        {
            InitializeComponent();
            this.userType1 = UserType;
            DataGridDetailsDisplay(UserType);
        }

        private void DataGridDetailsDisplay(string userType)
        {
            this.current = userType;
            string query = null;
            if (string.IsNullOrEmpty(userType)) return;

            switch (userType)
            {
                case "Passenger":
                    query = "SELECT ID, Username, [Password], [Full Name], [Email Address], Gender, Birthday, Classification, Wallet, Points, Status FROM PassengersQuery";
                    dgvUsers.ContextMenuStrip = contextMenuStrip1;
                    break;
                case "Driver":
                    query = "SELECT ID, Username, [Password], [Full Name], [Email Address], Gender, Birthday, [Plate Number], Wallet, Route, Status FROM DriversQuery";
                    dgvUsers.ContextMenuStrip = contextMenuStrip1;
                    break;
                case "Report":
                    query = "SELECT * FROM TripReportQuery";
                    dgvUsers.ContextMenuStrip = cmsAttachment;
                    break;
                case "ReportDate":
                    break;
                case "Rate":
                    query = "SELECT * FROM AdminRatings";
                    dgvUsers.ContextMenuStrip = contextMenuStrip1;
                    break;
                case "Transaction":
                    query = "SELECT * FROM Transactions";
                    dgvUsers.ContextMenuStrip = contextMenuStrip1;
                    break;
                default:
                    dgvUsers.ContextMenuStrip = cmsAttachment;
                    query = userType;
                    break;
            }

            dgvUsers.DataSource = null;
            dgvUsers.Rows.Clear();
            dgvUsers.Columns.Clear();

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt); // Load data into DataTable

                if (dt.Rows.Count == 0)
                {
                    pbEmpty.Visible = true;
                    return;
                }

                dgvUsers.DataSource = dt; // Bind DataTable to DataGridView


                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Adjust column width
                dgvUsers.DefaultCellStyle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Inter"), 14F, System.Drawing.FontStyle.Regular); // Set font
                dgvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Inter"), 16F, System.Drawing.FontStyle.Bold); // Header font
                dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 60, 114); // Header background color
                dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White; // Header text color
                dgvUsers.EnableHeadersVisualStyles = false; // Apply custom styling

            }
        }

        private int Overlay(Form form)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            var overlayForm = new Form();
            overlayForm.StartPosition = FormStartPosition.CenterScreen;
            overlayForm.FormBorderStyle = FormBorderStyle.None;
            overlayForm.Opacity = 0.5d;
            overlayForm.BackColor = Color.Black;
            if (adminDashboard.maximized)
            {
                overlayForm.StartPosition = FormStartPosition.Manual; // Ensure manual positioning
                overlayForm.Bounds = Screen.FromControl(adminDashboard).WorkingArea; // Adjust to working area (excludes taskbar)
                overlayForm.FormBorderStyle = FormBorderStyle.None; // Remove borders if needed
                overlayForm.WindowState = FormWindowState.Normal; // Reset first to ensure proper resize
                overlayForm.WindowState = FormWindowState.Maximized; // Then maximize
            }
            else
            {
                overlayForm.WindowState = FormWindowState.Normal;
            }


            overlayForm.Size = adminDashboard.Size;
            overlayForm.Location = this.Location;
            overlayForm.ShowInTaskbar = false;
            overlayForm.Show();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Close();
                overlayForm.Close();
                return 1;
            }
            else
            {
                form.Close();
                overlayForm.Close();
                return 0;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num;
            if (dgvUsers.SelectedRows.Count == 0)
            {
                NEXUS.Forms.Message message1 = new NEXUS.Forms.Message("select");

                num = Overlay(message1);
                return;
            }

            NEXUS.Forms.Message message = new NEXUS.Forms.Message("question");
            num = Overlay(message);
            if (num == 0)
            {
                using (OleDbConnection conn = DatabaseManagement.GetConnection())
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

        private void attachmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
                return;

            // Get the selected ReportID from the first selected row
            var selectedRow = dgvUsers.SelectedRows[0];
            var reportId = selectedRow.Cells["ReportID"].Value.ToString();

            if (string.IsNullOrEmpty(reportId))
                return;

            // Retrieve image bytes from the database
            byte[] imageData = GetImageFromDatabase(reportId);

            if (imageData != null && imageData.Length > 0)
            {
                DisplayImage displayForm = new DisplayImage(imageData, null);
                DialogBox dialogBox = new DialogBox();
                dialogBox.ShowOverlay(displayForm, null);
            }
        }

        private byte[] GetImageFromDatabase(string reportId)
        {
            byte[] imageBytes = null;

            string query = "SELECT Documentation FROM Reports WHERE ReportID = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", reportId);

                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    imageBytes = (byte[])result;
                }
            }

            return imageBytes;
        }

        private void resolvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
                return;

            var selectedRow = dgvUsers.SelectedRows[0];
            var reportId = selectedRow.Cells["ReportID"].Value.ToString();

            if (string.IsNullOrEmpty(reportId))
                return;

            // Update the status in the database
            bool success = UpdateReportStatus(reportId, "Resolved");

            if (success)
            {
                DataGridDetailsDisplay(current);
            }
        }

        private bool UpdateReportStatus(string reportId, string newStatus)
        {
            string query = "UPDATE Reports SET [Status] = ? WHERE ReportID = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                // Add parameters explicitly to avoid type confusion
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = newStatus;
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = reportId;


                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

    }
}

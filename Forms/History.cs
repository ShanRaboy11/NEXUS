using NEXUS.Classes;
using NEXUS.Properties;
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

namespace NEXUS.Forms
{
    public partial class History : Form
    {
        private string Filter;
        int UserID;
        public History(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            string historyQuery = $"SELECT TripID, [Trip Date], DriverID, Driver, [Plate Number], Route, Location, " +
                $"Destination, [Fare Amount] FROM Trips WHERE PassengerID = {userID}";
            DisplayDataGrid(historyQuery);
        }

        private void DisplayDataGrid(string query)
        {

            dgvHistory.DataSource = null;
            dgvHistory.Rows.Clear();
            dgvHistory.Columns.Clear();

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt); // Load data into DataTable
                dgvHistory.DataSource = dt; // Bind DataTable to DataGridView


                dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Adjust column width
                dgvHistory.DefaultCellStyle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Inter"), 14F, System.Drawing.FontStyle.Regular); // Set font
                dgvHistory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Inter"), 16F, System.Drawing.FontStyle.Bold); // Header font
                dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 60, 114); // Header background color
                dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White; // Header text color
                dgvHistory.EnableHeadersVisualStyles = false; // Apply custom styling

            }
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxFilter.SelectedItem != null)
            {
                Filter = cmbxFilter.SelectedItem.ToString();
                displayTools(Filter);
            }
        }

        private void displayTools(string tool)
        {
            if (tool == "Date")
            {
                tbxJeepCode.Visible = false;
                dtDate.Visible = true;
                pbIcon.Visible = true;
                pbIcon.Image = Resources._115762_calendar_date_event_month_icon;
            }
            else
            {
                dtDate.Visible = false;
                pbIcon.Visible = true;
                tbxJeepCode.Visible = true;
                pbIcon.Image = Resources.jeepcode;
            }
        }

        private void tbxJeepCode_Click(object sender, EventArgs e)
        {
            tbxJeepCode.Text = "";
            tbxJeepCode.ForeColor = Color.Black;
        }

        private void rateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rate rate = new Rate();
            Scan scan = new Scan(UserID);

            scan.ShowOverlay(rate, null);
            scan.FormClosed += (s, args) => this.Show();
        }
    }
}

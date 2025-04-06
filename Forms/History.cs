using Microsoft.VisualBasic.ApplicationServices;
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
        private string Filter, JeepCode;
        string filterQuery;
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
            dgvHistory.ClearSelection();
            dgvHistory.CurrentCell = null;

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                    pbEmpty.Visible = true;
                else
                    pbEmpty.Visible = false;

                dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvHistory.DataSource = dt;

                dgvHistory.AutoResizeColumns();
                dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvHistory.DefaultCellStyle.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Regular);
                dgvHistory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Bold);
                dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 60, 114);
                dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgvHistory.EnableHeadersVisualStyles = false;
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
                cmbxJeepCodes.Visible = false;
                dtDate.Visible = true;
                pbIcon.Visible = true;
                pbIcon.Image = Resources._115762_calendar_date_event_month_icon;
                pbIcon.Size = new System.Drawing.Size(74, 51);
            }
            else
            {
                dtDate.Visible = false;
                pbIcon.Visible = true;
                cmbxJeepCodes.Visible = true;
                pbIcon.Image = Resources.jeepcode;
                pbIcon.Size = new System.Drawing.Size(79, 56);
            }
        }

        private void rateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scan scan = new Scan(UserID);

            if (dgvHistory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvHistory.SelectedRows[0];

                int tripID = Convert.ToInt32(selectedRow.Cells["TripID"].Value);
                int driverID = Convert.ToInt32(selectedRow.Cells["DriverID"].Value);
                string driverName = selectedRow.Cells["Driver"].Value.ToString();

                // Pass these details to your rate form
                Rate rate = new Rate(tripID, driverID, driverName);
                scan.ShowOverlay(rate, null);
                scan.FormClosed += (s, args) => this.Show();
            }
        }

        private void cmbxJeepCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxJeepCodes.SelectedItem != null)
            {
                string JeepCode = cmbxJeepCodes.SelectedItem.ToString(); 
                this.filterQuery = $"SELECT TripID, [Trip Date], DriverID, Driver, [Plate Number], Location, " +
                                   $"Destination, [Fare Amount] FROM Trips WHERE Route = '{JeepCode}' AND PassengerID = {UserID}";
                DisplayDataGrid(this.filterQuery);
            }
        }

        private void dtpTripDate_ValueChanged(object sender, EventArgs e)
        {
            string selectedDate = dtDate.Value.ToString("MM/dd/yyyy"); // Format selected date
            this.filterQuery = $"SELECT TripID, [Trip Date], DriverID, Driver, [Plate Number], Location, " +
                               $"Destination, [Fare Amount] FROM Trips WHERE Format([Trip Date], 'MM/dd/yyyy') = '{selectedDate}' AND PassengerID = {UserID}";

            DisplayDataGrid(this.filterQuery);
        }


        private void History_Load(object sender, EventArgs e)
        {
            dgvHistory.ClearSelection();
            dgvHistory.CurrentCell = null;
        }
    }
}

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
    public partial class DriverHistory : Form
    {
        private string Filter;
        string filterQuery;
        int UserID;
        public DriverHistory(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            string historyQuery = $"SELECT TripID, [Trip Date], PassengerID, Passenger, [Plate Number], Route, Location, " +
                $"Destination, [Fare Amount] FROM Trips WHERE DriverID = {userID}";
            DisplayDataGrid(historyQuery);
        }

        private void DisplayDataGrid(string query)
        {
            dgvDriverHistory.DataSource = null;
            dgvDriverHistory.Rows.Clear();
            dgvDriverHistory.Columns.Clear();
            dgvDriverHistory.ClearSelection();
            dgvDriverHistory.CurrentCell = null;

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                    pbEmpty.Visible = true;
                else
                    pbEmpty.Visible = false;

                dgvDriverHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvDriverHistory.DataSource = dt;

                dgvDriverHistory.AutoResizeColumns();
                dgvDriverHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvDriverHistory.DefaultCellStyle.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Regular);
                dgvDriverHistory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Inter", 16F, System.Drawing.FontStyle.Bold);
                dgvDriverHistory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 60, 114);
                dgvDriverHistory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgvDriverHistory.EnableHeadersVisualStyles = false;
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
                dtDate.Visible = true;
                pbIcon.Visible = true;
                pbIcon.Image = Resources._115762_calendar_date_event_month_icon;
            }
            else
            {
                pbIcon.Visible = true;
                pbIcon.Image = Resources.rate_hover2;
            }
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            if(Filter == "Date")
            {
                string selectedDate = dtDate.Value.ToString("MM/dd/yyyy");
                this.filterQuery = $"SELECT TripID, [Trip Date], PassengerID, Passenger, [Plate Number], Location, " +
                                   $"Destination, [Fare Amount] FROM Trips WHERE Format([Trip Date], 'MM/dd/yyyy') = '{selectedDate}' AND DriverID = {UserID}";

                DisplayDataGrid(this.filterQuery);
            }
            else
            {

            }
        }

        private void DriverHistory_Load(object sender, EventArgs e)
        {
            dgvDriverHistory.ClearSelection();
            dgvDriverHistory.CurrentCell = null;
        }
    }
}

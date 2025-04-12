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
    public partial class ReportsAdmin : UserControl
    {
        private FontAwesome.Sharp.IconButton selectedButton = null;
        private FontAwesome.Sharp.IconButton currentBtn;
        private string current;
        public ReportsAdmin()
        {
            InitializeComponent();
            btnReport_Click(btnReports, EventArgs.Empty);
        }

        private void DisplayReports()
        {
            pnlContainer.Controls.Clear();

            DataGrid dataGrid = new DataGrid("Report")
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            SelectButton(btnReports);
            DisplayReports();
            current = "Report";
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            SelectButton(btnRate);
            DisplayRates();
            cmbxFilter.Items.Clear();
            cmbxFilter.Items.Add("Trip Date");
            cmbxFilter.Items.Add("Date Rated");
        }

        private void DisplayRates()
        {
            pnlContainer.Controls.Clear();

            DataGrid dataGrid = new DataGrid("Rate")
            {
                Dock = DockStyle.Fill
            };

            pnlContainer.Controls.Add(dataGrid);
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            string selectedDate = dtDate.Value.ToString("MM/dd/yyyy");
            string dateQuery = null;
            if (current == "Report")
            {
                dateQuery = $"SELECT ReportID, TripID, Passenger, Driver, Location, " +
                            $"Category, Description, Status FROM TripReportQuery WHERE Format([Date of Incident], 'MM/dd/yyyy') = '{selectedDate}'";
            }
            else if(current == "Date Rated")
            {
                dateQuery = $"SELECT TripID, [Trip Date], Passenger, Driver, Safety, Smoothness, Speed, " +
                            $"Comfortability, Cleanliness, [Overall Satisfaction], Comments FROM AdminRatings WHERE Format([Date Rated], 'MM/dd/yyyy') = '{selectedDate}'";
            }
            else
            {
                dateQuery = $"SELECT TripID, Passenger, Driver, Safety, Smoothness, Speed, " +
                            $"Comfortability, Cleanliness, [Overall Satisfaction], Comments, [Date Rated] FROM AdminRatings WHERE Format([Trip Date], 'MM/dd/yyyy') = '{selectedDate}'";
            }

            pnlContainer.Controls.Clear();

            DataGrid dataGrid = new DataGrid(dateQuery)
            {
                Dock = DockStyle.Fill
            };
            pnlContainer.Controls.Add(dataGrid);
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxFilter.SelectedItem == "Pending Reports")
            {
                dtDate.Visible = false;
                pbDate.Visible = false;
                string query = "SELECT * FROM TripReportQuery WHERE Status = 'Pending'";
                pnlContainer.Controls.Clear();

                DataGrid dataGrid = new DataGrid(query)
                {
                    Dock = DockStyle.Fill
                };
                pnlContainer.Controls.Add(dataGrid);
            }
            else if (cmbxFilter.SelectedItem == "Trip Date")
            {
                current = "Trip Date";
                dtDate.Visible = true;
                pbDate.Visible = true;

            }
            else if (cmbxFilter.SelectedItem == "Date Rated")
            {
                current = "Date Rated";
                dtDate.Visible = true;
                pbDate.Visible = true;
            }
            else
            {
                dtDate.Visible = true;
                pbDate.Visible = true;
            }
        }
    }
}

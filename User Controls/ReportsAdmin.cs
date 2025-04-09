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
                selectedButton.BackColor = Color.FromArgb(230, 249, 255);
                selectedButton.ForeColor = Color.Black;
                button.Font = new(button.Font.FontFamily, 18, button.Font.Style);
            }

            selectedButton = button;
            button.BackColor = Color.FromArgb(0, 229, 255);
            button.Font = new(button.Font.FontFamily, 20, button.Font.Style);
            button.ForeColor = Color.White;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SelectButton(btnReports);
            DisplayReports();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SelectButton(btnUpdates);

        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            SelectButton(btnRate);
            DisplayRates();
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
            string selectedDate = dtDate.Value.ToString("MM/dd/yyyy"); // Format selected date
            string dateQuery = $"SELECT ReportID, TripID, Passenger, Driver, Location, " +
                               $"Category, Description, Status FROM TripReportQuery WHERE Format([Date of Incident], 'MM/dd/yyyy') = '{selectedDate}'";

            pnlContainer.Controls.Clear();

            DataGrid dataGrid = new DataGrid(dateQuery)
            {
                Dock = DockStyle.Fill
            };
            pnlContainer.Controls.Add(dataGrid);
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxFilter.SelectedItem == "Pending Reports")
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
            else
            {
                dtDate.Visible = true;
                pbDate.Visible = true;
            }

        }
    }
}

using NEXUS.Classes;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
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
    public partial class Home : Form
    {
        private Dashboard passengerDashboard;
        private DriverDashboard driverDashboard;
        private UserInformation currentUser;

        public Home(UserInformation user)
        {
            InitializeComponent();
            this.currentUser = user;


            if (user is Passenger passenger)
            {
                passengerDashboard = new Dashboard(passenger);
                LoadPassengerFareAnalytics();
            }
            else if (user is Driver driver)
            {
                driverDashboard = new DriverDashboard(driver);
                pvPassenger.Visible = false;
                label3.Visible = false;
            }
        }

        private void pbMap_Click(object sender, EventArgs e)
        {
            Scan scan = new Scan(currentUser.UserID);
            Map map = new Map();
            scan.ShowOverlay(map, null);
        }

        private void LoadPassengerFareAnalytics()
        {
            string query = @"
        SELECT Sum([Fare Amount]) AS TotalFare, Format([Trip Date], 'mm/dd/yyyy') AS TripDay 
        FROM Trips 
        WHERE [Trip Date] >= Date() - 7 AND PassengerID = ?
        GROUP BY Format([Trip Date], 'mm/dd/yyyy') 
        ORDER BY Format([Trip Date], 'mm/dd/yyyy') ASC";

            using (OleDbConnection connection = DatabaseManagement.GetConnection())
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // Use parameter to securely insert current user ID
                command.Parameters.AddWithValue("?", currentUser.UserID);

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                double totalExpenses = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalExpenses += Convert.ToDouble(row["TotalFare"]);
                }

                // Update the chart and total label
                CreateFareLineChart(dataTable);
                //lblTotalFareExpenses.Text = "₱ " + totalExpenses.ToString("N2");
            }
        }

        private void CreateFareLineChart(DataTable dataTable)
        {
            var model = new PlotModel { };

            var areaSeries = new AreaSeries
            {
                Title = "Fare Area",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black,
                Color = OxyColor.FromRgb(38, 36, 68),
                Fill = OxyColor.FromArgb(100, 0, 229, 255)
            };

            var lineSeries = new LineSeries
            {
                Title = "Fare Expenses",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black,
                LineStyle = LineStyle.Solid,
                Color = OxyColor.FromRgb(38, 36, 68)
            };

            foreach (DataRow row in dataTable.Rows)
            {
                DateTime tripDate = Convert.ToDateTime(row["TripDay"]);
                double totalFare = Convert.ToDouble(row["TotalFare"]);

                lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(tripDate), totalFare));
                areaSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(tripDate), totalFare));
            }

            model.Series.Add(areaSeries);
            model.Series.Add(lineSeries);

            model.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                FontSize = 16,
                StringFormat = "MM/dd",
                Title = "Date"
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                FontSize = 16,
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                Title = "Fare (₱)"
            });

            pvPassenger.Model = model; // Make sure this matches your PlotView control name
        }

    }

}

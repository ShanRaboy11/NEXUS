using OxyPlot.Series;
using OxyPlot.WindowsForms;
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
using NEXUS.Classes;
using OxyPlot.Axes;

namespace NEXUS.User_Controls
{
    public partial class HomeAdmin : UserControl
    {
        public HomeAdmin()
        {
            InitializeComponent();
            LoadUserDataAndShowChart();
            LoadRevenueData();
        }

        private void LoadUserDataAndShowChart()
        {
            int totalPassengers = 0;
            int totalDrivers = 0;
            string query = "SELECT [User Type] FROM Accounts";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userType = reader["User Type"].ToString().Trim().ToLower();

                            if (userType == "passenger")
                                totalPassengers++;
                            else if (userType == "driver")
                                totalDrivers++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }

            CreatePieChart(totalPassengers, totalDrivers);
        }

        private void CreatePieChart(int totalPassengers, int totalDrivers)
        {
            int numUsers = totalDrivers + totalPassengers;

            var model = new PlotModel(); // No title set here

            var pieSeries = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.8,
                AngleSpan = 360,
                StartAngle = 15,
                FontSize = 16,
                TextColor = OxyColors.Black
            };

            pieSeries.Slices.Add(new PieSlice("Passengers", totalPassengers)
            {
                IsExploded = true,
                Fill = OxyColor.FromRgb(153, 229, 255)
            });

            pieSeries.Slices.Add(new PieSlice("Drivers", totalDrivers)
            {
                IsExploded = true,
                Fill = OxyColor.FromRgb(0, 229, 255)
            });

            model.Series.Add(pieSeries);

            pvPieChart.Model = model;
            lblNumPassenger.Text = totalPassengers.ToString();
            lblNumDriver.Text = totalDrivers.ToString();
            lblUsers.Text = numUsers + " Users";
        }

        private void LoadRevenueData()
        {
            string query = @"SELECT Sum([Fare Amount]) AS TotalFare, Format([Trip Date], 'mm/dd/yyyy') AS TripDay FROM Trips WHERE [Trip Date] >= Date() - 7
                GROUP BY Format([Trip Date], 'mm/dd/yyyy') ORDER BY Format([Trip Date], 'mm/dd/yyyy') ASC";

            using (OleDbConnection connection = DatabaseManagement.GetConnection())
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Now you can use this data to create the chart
                CreateRevenueLineChart(dataTable);
            }
        }

        private void CreateRevenueLineChart(DataTable dataTable)
        {
            var model = new PlotModel { Title = "Total Revenue in the Last 7 Days" };

            // Create the line series
            var lineSeries = new LineSeries
            {
                Title = "Revenue",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black,
                LineStyle = LineStyle.Solid,
                Color = OxyColor.FromRgb(38, 36, 68)
            };

            // Add data points to the line series
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime tripDate = Convert.ToDateTime(row["TripDay"]); // Use "TripDay" instead of "Trip Date"
                double totalFare = Convert.ToDouble(row["TotalFare"]);

                // Add the data point to the line series
                lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(tripDate), totalFare));
            }

            model.Series.Add(lineSeries);

            // Set up the X-axis (Date)
            model.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "MM/dd",
                Title = "Date"
            });

            // Set up the Y-axis (Revenue)
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                Title = "Total Revenue ($)"
            });

            // Assign the model to the plot view
            pvRevenueChart.Model = model;  // pvRevenueChart is the name of the PlotView control
        }
    }
}

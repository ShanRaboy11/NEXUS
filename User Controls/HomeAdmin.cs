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
using System.Globalization;

namespace NEXUS.User_Controls
{
    public partial class HomeAdmin : UserControl
    {
        public HomeAdmin()
        {
            InitializeComponent();
            LoadUserDataAndShowChart();
            LoadRevenueData();
            LoadDriverRevenueData();
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

                double totalRevenue = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalRevenue += Convert.ToDouble(row["TotalFare"]);
                }

                // Now you can use this data to create the chart
                CreateRevenueLineChart(dataTable);
                lblTotalRevenue.Text = "₱ " + totalRevenue.ToString("N2");
            }
        }

        private void CreateRevenueLineChart(DataTable dataTable)
        {
            var model = new PlotModel { };

            // Create the area series (shaded area under the line)
            var areaSeries = new AreaSeries
            {
                Title = "Revenue Area",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black,
                Color = OxyColor.FromRgb(38, 36, 68),  // Line color
                Fill = OxyColor.FromArgb(100, 0, 229, 255)    // Shaded area under the line (lightened shade of the line color)
            };

            // Create the line series
            var lineSeries = new LineSeries
            {
                Title = "Revenue",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black,
                LineStyle = LineStyle.Solid,
                Color = OxyColor.FromRgb(38, 36, 68)  // Line color
            };

            // Add data points to the line series and area series
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime tripDate = Convert.ToDateTime(row["TripDay"]);  // Use "TripDay" instead of "Trip Date"
                double totalFare = Convert.ToDouble(row["TotalFare"]);

                // Add the data point to the line series
                lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(tripDate), totalFare));

                // Add the same data point to the area series for shading
                areaSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(tripDate), totalFare));
            }

            // Add both series to the plot model
            model.Series.Add(areaSeries);  // Add AreaSeries to the model
            model.Series.Add(lineSeries);  // Add LineSeries to the model

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
                Title = "Total Revenue (₱)"
            });

            // Assign the model to the plot view
            pvRevenueChart.Model = model;  // pvRevenueChart is the name of the PlotView control
        }

        private void LoadMonthlyRevenueData()
        {
            string query = @"SELECT Sum([Fare Amount]) AS TotalFare, Format([Trip Date], 'mm/yyyy') AS TripMonth FROM Trips 
             WHERE [Trip Date] >= DateAdd('m', -1, Date()) 
             GROUP BY Format([Trip Date], 'mm/yyyy') 
             ORDER BY Format([Trip Date], 'mm/yyyy') ASC";

            using (OleDbConnection connection = DatabaseManagement.GetConnection())
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Debugging: Check if data is being retrieved
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data available for the past month.");
                    return;
                }

                // Add missing months to the DataTable with zero values
                AddMissingMonths(dataTable);

                // Sum up total revenue
                double totalRevenue = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalRevenue += Convert.ToDouble(row["TotalFare"]);
                }

                // Create the chart with the data (including months with zero revenue)
                CreateMonthlyRevenueLineChart(dataTable);
                lblTotalRevenue.Text = "₱ " + totalRevenue.ToString("N2");  // Display total revenue with proper formatting
            }
        }

        private void AddMissingMonths(DataTable dataTable)
        {
            // Generate all months for the past 2 months (current month and last month)
            List<string> expectedMonths = new List<string>();
            DateTime currentDate = DateTime.Now;

            for (int i = -1; i <= 0; i++)  // Loop through last month and this month
            {
                expectedMonths.Add(currentDate.AddMonths(i).ToString("MM/yyyy"));
            }

            // Loop through the expected months and check if they exist in the data
            foreach (var month in expectedMonths)
            {
                // If the month is not present in the dataTable, add it with zero total fare
                if (!dataTable.AsEnumerable().Any(row => row["TripMonth"].ToString() == month))
                {
                    // Add missing month with zero fare
                    DataRow newRow = dataTable.NewRow();
                    newRow["TripMonth"] = month;
                    newRow["TotalFare"] = 0;  // No revenue for this month
                    dataTable.Rows.Add(newRow);
                }
            }
        }



        private void CreateMonthlyRevenueLineChart(DataTable dataTable)
        {
            var model = new PlotModel { };

            // Create the area series (shaded area under the line)
            var areaSeries = new AreaSeries
            {
                Title = "Revenue Area",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black,
                Color = OxyColor.FromRgb(38, 36, 68),  // Line color
                Fill = OxyColor.FromArgb(100, 0, 229, 255)    // Shaded area under the line (lightened shade of the line color)
            };

            // Create the line series
            var lineSeries = new LineSeries
            {
                Title = "Revenue",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black,
                LineStyle = LineStyle.Solid,
                Color = OxyColor.FromRgb(38, 36, 68)  // Line color
            };

            // Add data points to the line series and area series
            foreach (DataRow row in dataTable.Rows)
            {
                // Debugging: Check the parsed TripMonth
                DateTime tripMonth = DateTime.ParseExact(row["TripMonth"].ToString(), "MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine($"Parsed DateTime: {tripMonth}");

                double totalFare = Convert.ToDouble(row["TotalFare"]);

                // Add the data point to the line series
                lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(tripMonth), totalFare));

                // Add the same data point to the area series for shading
                areaSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(tripMonth), totalFare));
            }

            // Add both series to the plot model
            model.Series.Add(areaSeries);  // Add AreaSeries to the model
            model.Series.Add(lineSeries);  // Add LineSeries to the model

            // Set up the X-axis (Month)
            model.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "MM/yyyy",  // Format for the month (e.g., 01/2025 for January 2025)
                Title = "Month",
                IntervalType = DateTimeIntervalType.Months,  // Ensure the interval is set to months
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });

            // Set up the Y-axis (Revenue)
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                Title = "Total Revenue (₱)"
            });

            // Assign the model to the plot view
            pvRevenueChart.Model = model;  // pvRevenueChart is the name of the PlotView control
        }


        private void LoadAnnualRevenueData()
        {
            string query = @"SELECT Sum([Fare Amount]) AS TotalFare, Format([Trip Date], 'yyyy') AS TripYear FROM Trips 
             WHERE [Trip Date] >= DateAdd('yyyy', -1, Date()) 
             GROUP BY Format([Trip Date], 'yyyy') 
             ORDER BY Format([Trip Date], 'yyyy') ASC";

            using (OleDbConnection connection = DatabaseManagement.GetConnection())
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Debugging: Check if data is being retrieved
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data available for the past year.");
                    return;
                }

                // Add missing years to the DataTable with zero values
                AddMissingYears(dataTable);

                // Sum up total revenue
                double totalRevenue = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalRevenue += Convert.ToDouble(row["TotalFare"]);
                }

                // Create the chart with the data (including years with zero revenue)
                CreateAnnualRevenueLineChart(dataTable);
                lblTotalRevenue.Text = "₱ " + totalRevenue.ToString("N2");  // Display total revenue with proper formatting
            }
        }

        private void AddMissingYears(DataTable dataTable)
        {
            // Generate all years for the past 2 years (current year and last year)
            List<string> expectedYears = new List<string>();
            DateTime currentDate = DateTime.Now;

            for (int i = -1; i <= 0; i++)  // Loop through last year and this year
            {
                expectedYears.Add(currentDate.AddYears(i).ToString("yyyy"));
            }

            // Loop through the expected years and check if they exist in the data
            foreach (var year in expectedYears)
            {
                // If the year is not present in the dataTable, add it with zero total fare
                if (!dataTable.AsEnumerable().Any(row => row["TripYear"].ToString() == year))
                {
                    // Add missing year with zero fare
                    DataRow newRow = dataTable.NewRow();
                    newRow["TripYear"] = year;
                    newRow["TotalFare"] = 0;  // No revenue for this year
                    dataTable.Rows.Add(newRow);
                }
            }
        }

        private void CreateAnnualRevenueLineChart(DataTable dataTable)
        {
            var model = new PlotModel { };

            // Create the area series (shaded area under the line)
            var areaSeries = new AreaSeries
            {
                Title = "Revenue Area",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black,
                Color = OxyColor.FromRgb(38, 36, 68),  // Line color
                Fill = OxyColor.FromArgb(100, 0, 229, 255)    // Shaded area under the line (lightened shade of the line color)
            };

            // Create the line series
            var lineSeries = new LineSeries
            {
                Title = "Revenue",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black,
                LineStyle = LineStyle.Solid,
                Color = OxyColor.FromRgb(38, 36, 68)  // Line color
            };

            // Add data points to the line series and area series
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime tripYear = DateTime.ParseExact(row["TripYear"].ToString(), "yyyy", CultureInfo.InvariantCulture);
                double totalFare = Convert.ToDouble(row["TotalFare"]);

                // Add the data point to the line series
                lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(tripYear), totalFare));

                // Add the same data point to the area series for shading
                areaSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(tripYear), totalFare));
            }

            // Add both series to the plot model
            model.Series.Add(areaSeries);  // Add AreaSeries to the model
            model.Series.Add(lineSeries);  // Add LineSeries to the model

            // Set up the X-axis (Year)
            model.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "yyyy",  // Format for the year (e.g., 2025)
                Title = "Year"
            });

            // Set up the Y-axis (Revenue)
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                Title = "Total Revenue (₱)"
            });

            // Assign the model to the plot view
            pvRevenueChart.Model = model;  // pvRevenueChart is the name of the PlotView control
        }

        private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadRevenueData();
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMonthlyRevenueData();
        }

        private void yearlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAnnualRevenueData();
        }

        private void LoadDriverRevenueData()
        {
            // SQL query to access the saved query in your database
            string query = "SELECT * FROM DriverTotalRevenue"; // Access the saved query by name

            using (OleDbConnection connection = DatabaseManagement.GetConnection())
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Create the chart
                CreateDriverRevenueBarChart(dataTable);
            }
        }

        private void CreateDriverRevenueBarChart(DataTable dataTable)
        {
            // Create the plot model
            var model = new PlotModel
            {
                Title = "Driver Revenue Performance",
                TitleFontSize = 18
            };

            // Create the bar series
            var series = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "₱{0:N0}",
                FillColor = OxyColor.FromRgb(76, 229, 255)
            };

            // Add items dynamically based on data
            foreach (DataRow row in dataTable.Rows)
            {
                string driverName = row["FirstName"].ToString(); // Get the first name of the driver
                double totalRevenue = Convert.ToDouble(row["TotalRevenue"]); // Get the total revenue for that driver

                // Add the data to the BarSeries
                series.Items.Add(new BarItem(totalRevenue));
            }

            // Add the bar series to the plot model
            model.Series.Add(series);

            // Set up the X-axis (Driver Names)
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                ItemsSource = dataTable.AsEnumerable().Select(r => r["FirstName"].ToString()).ToList(),
                Title = "Driver"
            });

            // Set up the Y-axis (Revenue)
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "Total Revenue (₱)"
            });

            // Assign the model to the PlotView
            pvDrivers.Model = model; // Assuming plotViewDriverRevenue is your PlotView control
        }

    }
}

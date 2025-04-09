using NEXUS.Classes;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NEXUS.Forms
{
    public partial class Analytics : Form
    {
        private int driverID;

        public Analytics(int userID)
        {
            InitializeComponent();
            this.driverID = userID;
            LoadDriverWeeklyEarningsChart(driverID);
            DisplayAvgRatings(userID);
        }

        private Dictionary<string, decimal> GetWeeklyEarnings(int driverID)
        {
            Dictionary<string, decimal> earnings = new Dictionary<string, decimal>();

            DateTime today = DateTime.Today;
            DateTime startDate = today.AddDays(-6);
            DateTime endDate = today.AddDays(1).AddTicks(-1); // Include all of today

            string query = @"SELECT [Trip Date], [Fare Amount] FROM Trips WHERE DriverID = ? AND [Trip Date] >= ? AND [Trip Date] <= ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    // Pass parameters in correct order and type
                    cmd.Parameters.Add("DriverID", OleDbType.Integer).Value = driverID;
                    cmd.Parameters.Add("StartDate", OleDbType.Date).Value = startDate;
                    cmd.Parameters.Add("EndDate", OleDbType.Date).Value = endDate;

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime tripDate = Convert.ToDateTime(reader["Trip Date"]);
                            decimal fare = Convert.ToDecimal(reader["Fare Amount"]);
                            string dayName = tripDate.ToString("dddd"); // Full day name (e.g., Wednesday)

                            if (earnings.ContainsKey(dayName))
                                earnings[dayName] += fare;
                            else
                                earnings[dayName] = fare;
                        }
                    }
                }
            }

            // Fill in missing days (to ensure 7 days shown)
            for (int i = 0; i < 7; i++)
            {
                string day = today.AddDays(-i).ToString("dddd");
                if (!earnings.ContainsKey(day))
                    earnings[day] = 0;
            }

            // Order days from today backward
            return earnings
                .OrderByDescending(e =>
                {
                    if (Enum.TryParse<DayOfWeek>(e.Key, out var dayOfWeek))
                    {
                        return (7 + (int)today.DayOfWeek - (int)dayOfWeek) % 7;
                    }
                    return int.MaxValue;
                })
                .ToDictionary(pair => pair.Key, pair => pair.Value);
        }



        private void LoadDriverWeeklyEarningsChart(int driverID)
        {
            var earnings = GetWeeklyEarnings(driverID);

            // Compute total earnings
            decimal totalEarnings = earnings.Values.Sum();

            // Create the model with total earnings in the title (optional)
            var model = new PlotModel
            {
                Title = "Driver Earnings (Last 7 Days)",
                TitleFontSize = 18
            };

            var series = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "₱{0:N0}",
                FillColor = OxyColors.SteelBlue
            };

            // Add items dynamically based on earnings dictionary
            foreach (var dayEarning in earnings)
            {
                series.Items.Add(new BarItem((double)dayEarning.Value));
            }

            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                ItemsSource = earnings.Keys.ToList() // Use dynamic day names (e.g., Wed, Tue, etc.)
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "₱ Earnings"
            });

            model.Series.Add(series);
            plotViewDriverAnalytics.Model = model;

            // Update total and date range labels
            lblTotalEarnings.Text = $"₱ {totalEarnings:N2}";
            lblWeekRange.Text = $"({DateTime.Today.AddDays(-6):MMMM d, yyyy} - {DateTime.Today:MMMM d, yyyy})";
        }

        private Dictionary<string, double> GetDriverAverageRatings(int driverID)
        {
            Dictionary<string, double> averages = new Dictionary<string, double>();

            string query = @"SELECT AVG(Safety) AS AvgSafety,AVG(Smoothness) AS AvgSmoothness,AVG(Speed) AS AvgSpeed, AVG(Comfortability) AS AvgComfort,
             AVG(Cleanliness) AS AvgClean, AVG([Overall Satisfaction]) AS AvgSatisfaction FROM Rate WHERE DriverID = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", driverID);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            averages["Safety"] = reader["AvgSafety"] != DBNull.Value ? Convert.ToDouble(reader["AvgSafety"]) : 0;
                            averages["Smoothness"] = reader["AvgSmoothness"] != DBNull.Value ? Convert.ToDouble(reader["AvgSmoothness"]) : 0;
                            averages["Speed"] = reader["AvgSpeed"] != DBNull.Value ? Convert.ToDouble(reader["AvgSpeed"]) : 0;
                            averages["Comfortability"] = reader["AvgComfort"] != DBNull.Value ? Convert.ToDouble(reader["AvgComfort"]) : 0;
                            averages["Cleanliness"] = reader["AvgClean"] != DBNull.Value ? Convert.ToDouble(reader["AvgClean"]) : 0;
                            averages["Overall Satisfaction"] = reader["AvgSatisfaction"] != DBNull.Value ? Convert.ToDouble(reader["AvgSatisfaction"]) : 0;
                        }
                    }
                }
            }

            return averages;
        }

        private void DisplayAvgRatings(int driverID)
        {
            var averages = GetDriverAverageRatings(driverID);

            lblSafety.Text = averages["Safety"].ToString("0.0");
            lblSmooth.Text = averages["Smoothness"].ToString("0.0");
            lblSpeed.Text = averages["Speed"].ToString("0.0");
            lblComfort.Text = averages["Comfortability"].ToString("0.0");
            lblClean.Text = averages["Cleanliness"].ToString("0.0");
            lblOverall.Text = averages["Overall Satisfaction"].ToString("0.0");
        }

    }
}

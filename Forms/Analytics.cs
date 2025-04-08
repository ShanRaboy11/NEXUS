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
            Dictionary<string, decimal> earnings = new Dictionary<string, decimal>
            {
                { "Mon", 0 }, { "Tue", 0 }, { "Wed", 0 },
                { "Thu", 0 }, { "Fri", 0 }, { "Sat", 0 }, { "Sun", 0 }
            };

            string query = @"
                SELECT [Trip Date], [Fare Amount] 
                FROM Trips 
                WHERE DriverID = ? 
                AND [Trip Date] >= Date() - Weekday(Date()) + 1 
                AND [Trip Date] <= Date() - Weekday(Date()) + 7";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", driverID);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime tripDate = Convert.ToDateTime(reader["Trip Date"]);
                            decimal fare = Convert.ToDecimal(reader["Fare Amount"]);
                            string day = tripDate.DayOfWeek.ToString().Substring(0, 3); // Get first 3 chars of day name

                            if (earnings.ContainsKey(day))
                                earnings[day] += fare;
                        }
                    }
                }
            }

            return earnings;
        }

        private void LoadDriverWeeklyEarningsChart(int driverID)
        {
            var earnings = GetWeeklyEarnings(driverID);

            // Compute total earnings
            decimal totalEarnings = earnings.Values.Sum(); // Add this line

            // Show in chart title (you can remove this if you prefer using a label instead)
            var model = new PlotModel
            {
                Title = $"Driver Weekly Earnings - Total: ₱{totalEarnings:N2}"
            };

            var series = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "₱{0:N0}",
                FillColor = OxyColors.SteelBlue // 👈 Change color here if you want
            };

            string[] weekDays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            foreach (string day in weekDays)
            {
                series.Items.Add(new BarItem((double)earnings[day]));
            }

            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                ItemsSource = weekDays
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "₱ Earnings"
            });

            model.Series.Add(series);
            plotViewDriverAnalytics.Model = model;

            //lblTotalEarnings.Text = $"Total Earnings: ₱{totalEarnings:N2}"; // Make sure you have this label on your form
        }


        private Dictionary<string, double> GetDriverAverageRatings(int driverID)
        {
            Dictionary<string, double> averages = new Dictionary<string, double>();

            string query = @"
             SELECT 
             AVG(Safety) AS AvgSafety,
             AVG(Smoothness) AS AvgSmoothness,
             AVG(Speed) AS AvgSpeed,
             AVG(Comfortability) AS AvgComfort,
             AVG(Cleanliness) AS AvgClean,
             AVG([Overall Satisfaction]) AS AvgSatisfaction
             FROM Rate
             WHERE DriverID = ?";

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

using NEXUS.Classes;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public partial class Analytics : Form
    {
        private int driverID;

        public Analytics(int userID)
        {
            InitializeComponent();
            this.driverID = userID;
            LoadDriverWeeklyEarningsChart(driverID); // Make sure this method is called
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

            var model = new PlotModel { Title = "Driver Weekly Earnings" };

            var series = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "₱{0:N0}",
                FillColor = OxyColors.SteelBlue
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

        }
    }
}

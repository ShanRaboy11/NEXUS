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

namespace NEXUS.User_Controls
{
    public partial class HomeAdmin : UserControl
    {
        public HomeAdmin()
        {
            InitializeComponent();
            LoadUserDataAndShowChart();
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




        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

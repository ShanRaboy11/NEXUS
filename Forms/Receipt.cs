using FontAwesome.Sharp;
using NEXUS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public partial class Receipt : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
           int nleftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );
        public Receipt(int userID)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            DisplayReciptInfo(userID);
        }

        private void DisplayReciptInfo(int userID)
        {
            string tripQuery = @"
        SELECT TOP 1 TripID, [Trip Date], Passenger, Driver, [Fare Amount]
        FROM Trips WHERE PassengerID = ? ORDER BY [Trip Date] DESC";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(tripQuery, conn))
            {
                cmd.Parameters.AddWithValue("?", userID);
                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    int tripID = Convert.ToInt32(reader["TripID"]);
                    DateTime tripDate = Convert.ToDateTime(reader["Trip Date"]);
                    string passenger = reader["Passenger"].ToString();
                    string driver = reader["Driver"].ToString();
                    double fare = Convert.ToDouble(reader["Fare Amount"]);

                    lblRefNumber.Text = "000000" + tripID.ToString();
                    lblDT.Text = tripDate.ToString("MMMM d, yyyy");
                    lblPassenger.Text = passenger.Split(' ')[0];
                    lblDriver.Text = driver.Split(' ')[0];
                    lblAmount.Text = fare.ToString("C");
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

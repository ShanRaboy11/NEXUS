using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using NEXUS.Classes;
using ReaLTaiizor.Controls;

namespace NEXUS.User_Controls
{
    public partial class PassengersAdmin : UserControl
    {
        public PassengersAdmin()
        {
            InitializeComponent();
           // pnlContainer.Tag = tblVerification;
            LoadPendingPassengers(); // Ensure loading happens after initialization
        }

        private void LoadPendingPassengers()
        {
            if (!(pnlContainer.Tag is TableLayoutPanel tblVerification))
                return;

            // Remove only data rows, not headers
            while (tblVerification.RowCount > 1)
            {
                for (int i = tblVerification.ColumnCount - 1; i >= 0; i--)
                {
                    Control control = tblVerification.GetControlFromPosition(i, 1);
                    if (control != null)
                        tblVerification.Controls.Remove(control);
                }
                tblVerification.RowCount--;
            }

            string query = "SELECT [Full Name], Attachment FROM Accounts WHERE Status = 'Pending' AND [User Type] = 'Passenger' ";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string passengerName = reader["Full Name"].ToString();
                            string attachment = reader["Attachment"].ToString();
                            AddPassengerRow(tblVerification, passengerName, attachment);
                        }
                    }
                }
            }
        }

        private void AddPassengerRow(TableLayoutPanel tblVerification, string passengerName, string attachment)
        {
            int rowIndex = -1;

            // Find the first available empty row (starting from row 1)
            for (int i = 1; i < tblVerification.RowCount; i++)
            {
                bool rowOccupied = false;
                foreach (Control control in tblVerification.Controls)
                {
                    if (tblVerification.GetRow(control) == i)
                    {
                        rowOccupied = true;
                        break;
                    }
                }

                if (!rowOccupied)
                {
                    rowIndex = i;
                    break;
                }
            }

            // If no empty row is found, add a new row dynamically
            if (rowIndex == -1)
            {
                rowIndex = tblVerification.RowCount;
                tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
                tblVerification.RowCount++;
            }

            Label lblName = new Label
            {
                Text = passengerName,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Inter", 17F, FontStyle.Regular)
            };

            Label lblAttachment = new Label
            {
                Text = attachment,
                Dock = DockStyle.Fill,
                ForeColor = Color.FromArgb(24, 60, 114),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Inter", 17F, FontStyle.Regular)
            };

            CyberButton btnApprove = new CyberButton
            {
                Text = "Approve",
                Dock = DockStyle.Fill,
                BackColor = Color.LightGreen,
                Font = new Font("Inter", 17F, FontStyle.Regular),
                Cursor = Cursors.Hand
            };
            btnApprove.Click += (sender, e) => ApprovePassenger(passengerName, btnApprove);

            tblVerification.Controls.Add(lblName, 0, rowIndex);
            tblVerification.Controls.Add(lblAttachment, 1, rowIndex);
            tblVerification.Controls.Add(btnApprove, 2, rowIndex);
        }




        private void ApprovePassenger(string passengerName, CyberButton btnApprove)
        {
            string query = "UPDATE Accounts SET Status = 'Approved' WHERE [Full Name] = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", passengerName);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    btnApprove.Enabled = false;
                    btnApprove.Text = "Approved";
                    btnApprove.BackColor = Color.Gray;
                }
            }
        }
    }
}

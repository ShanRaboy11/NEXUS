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
            pnlContainer.Tag = tblVerification;
            LoadPendingPassengers();
        }

        private void LoadPendingPassengers()
        {
            for (int i = tblVerification.Controls.Count - 1; i >= 0; i--)
            {
                Control control = tblVerification.Controls[i];
                int rowIndex = tblVerification.GetRow(control);
                if (rowIndex >= 1) // Skip headers (row 0)
                {
                    tblVerification.Controls.RemoveAt(i);
                }
            }

            string query = "SELECT [Full Name], Attachment FROM Accounts WHERE Status = 'Pending' AND [User Type] = 'Passenger'";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        int rowIndex = 1; // Start adding passengers from the second row

                        while (reader.Read())
                        {
                            string passengerName = reader["Full Name"].ToString();
                            string attachment = reader["Attachment"].ToString();
                            AddPassengerRow(tblVerification, passengerName, attachment, rowIndex++);
                        }
                    }
                }
            }
        }

        private void AddPassengerRow(TableLayoutPanel tblVerification, string passengerName, string attachment, int rowIndex)
        {
            if (rowIndex >= tblVerification.RowCount)
            {
                tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
                tblVerification.RowCount++;
            }

            Label lblName = new Label
            {
                Text = passengerName,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Inter", 17F, FontStyle.Regular),
                ForeColor = Color.FromArgb(24, 60, 114)
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
                TextButton = "Approve",
                //Dock = DockStyle.Fill,
                ColorBackground = Color.LightGreen,
                Font = new Font("Inter", 17F, FontStyle.Regular),
                ForeColor = Color.FromArgb(24, 60, 114),
                Cursor = Cursors.Hand
            };
            btnApprove.Click += (sender, e) => ApprovePassenger(passengerName);

            tblVerification.Controls.Add(lblName, 0, rowIndex);
            tblVerification.Controls.Add(lblAttachment, 1, rowIndex);
            tblVerification.Controls.Add(btnApprove, 2, rowIndex);
        }

        private void RemovePassengerRow(string passengerName)
        {
            if (!(pnlContainer.Tag is TableLayoutPanel tblVerification))
                return;

            // Find and remove the row with the given passenger name
            foreach (Control control in tblVerification.Controls.Cast<Control>().ToList())
            {
                if (control is Label lbl && lbl.Text == passengerName)
                {
                    int rowIndex = tblVerification.GetRow(lbl);

                    // Remove all controls from the found row
                    for (int i = 0; i < tblVerification.ColumnCount; i++)
                    {
                        Control cellControl = tblVerification.GetControlFromPosition(i, rowIndex);
                        if (cellControl != null)
                            tblVerification.Controls.Remove(cellControl);
                    }

                    // Shift rows upwards
                    for (int i = rowIndex + 1; i < tblVerification.RowCount; i++)
                    {
                        for (int j = 0; j < tblVerification.ColumnCount; j++)
                        {
                            Control movingControl = tblVerification.GetControlFromPosition(j, i);
                            if (movingControl != null)
                                tblVerification.SetRow(movingControl, i - 1);
                        }
                    }

                    // Reduce row count
                    tblVerification.RowCount--;
                    break;
                }
            }

            tblVerification.Refresh();
        }
        //RemovePassengerRow(passengerName);

        private void ApprovePassenger(string passengerName)
        {
            string query = "UPDATE Accounts SET Status = 'Approved' WHERE [Full Name] = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", passengerName);

                int rowsAffected = cmd.ExecuteNonQuery();
            }

            LoadPendingPassengers();
        }
    }
}
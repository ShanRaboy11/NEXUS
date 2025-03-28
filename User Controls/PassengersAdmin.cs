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
using NEXUS.Forms;
using ReaLTaiizor.Controls;
using NEXUS.Properties;
using System.Security.Cryptography;

namespace NEXUS.User_Controls
{
    public partial class PassengersAdmin : UserControl
    {
        public PassengersAdmin()
        {
            InitializeComponent();
            pnlContainer.Tag = tblVerification;
            //LoadPendingPassengers();
            DisplayAllPassengers();
        }

        private void DisplayAllPassengers()
        {
            // Clear any existing controls in pnlContainer
            pnlContainer.Controls.Clear();

            // Create an instance of the PassengersAdmin UserControl
            DataGrid dataGrid = new DataGrid("Passenger")
            {
                Dock = DockStyle.Fill
            };

            // Add the user control to the panel
            pnlContainer.Controls.Add(dataGrid);
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
                            string attachmentPath = reader["Attachment"].ToString();

                            AddPassengerRow(tblVerification, passengerName, attachmentPath, rowIndex++);
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
                Font = new Font("Inter", 17F, FontStyle.Underline),
                //Anchor = AnchorStyles.None,
                Cursor = Cursors.Hand
            };

            CyberButton btnApprove = new CyberButton
            {
                TextButton = "Approve",
                ColorBackground = Color.LightGreen,
                ColorBackground_Pen = Color.FromArgb(230, 249, 255),
                Font = new Font("Inter", 17F, FontStyle.Regular),
                ForeColor = Color.FromArgb(24, 60, 114),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Right
            };

            CyberButton btnReject = new CyberButton
            {
                TextButton = "Reject",
                ColorBackground = Color.Red,
                ColorBackground_Pen = Color.FromArgb(230, 249, 255),
                Font = new Font("Inter", 17F, FontStyle.Regular),
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Left
            };

            btnApprove.Click += (sender, e) => ApprovePassenger(passengerName);
            btnReject.Click += (sender, e) => RejectPassenger(passengerName);
            lblAttachment.Click += (sender, e) => DisplayAttachment(attachment);

            tblVerification.Controls.Add(lblName, 0, rowIndex);
            tblVerification.Controls.Add(lblAttachment, 1, rowIndex);
            tblVerification.Controls.Add(btnApprove, 2, rowIndex);
            tblVerification.Controls.Add(btnReject, 3, rowIndex);
        }

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

        private void RejectPassenger(string passengerName)
        {
            string query = "UPDATE Accounts SET Status = 'Rejected' WHERE [Full Name] = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", passengerName);

                int rowsAffected = cmd.ExecuteNonQuery();
            }

            LoadPendingPassengers();
        }

        private void DisplayAttachment(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("No attachment found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(AppContext.BaseDirectory, "Attachments", fileName);

            if (File.Exists(filePath))
            {
                Image image = Image.FromFile(filePath);
                DisplayImage display = new DisplayImage(image, "register");
            }
            else
            {
                MessageBox.Show("Attachment not found at: " + filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
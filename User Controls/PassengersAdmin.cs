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
using System.Net.Mail;
using System.Transactions;
using System.Windows.Documents;

namespace NEXUS.User_Controls
{
    public partial class PassengersAdmin : UserControl
    {
        private FontAwesome.Sharp.IconButton selectedButton = null;
        private FontAwesome.Sharp.IconButton currentBtn;
        public PassengersAdmin()
        {
            InitializeComponent();
            pnlContainer.Tag = tblVerification;
            DisplayAllPassengers();
            btnPassengers_Click(btnPassengers, EventArgs.Empty);
        }

        private void DisplayAllPassengers()
        {
            pnlContainer.Controls.Clear();

            DataGrid dataGrid = new DataGrid("Passenger")
            {
                Dock = DockStyle.Fill
            };

            pnlContainer.Controls.Add(dataGrid);
        }

        private void LoadPendingPassengers()
        {
            pnlContainer.Controls.Clear();

            if (!pnlContainer.Controls.Contains(tblVerification))
            {
                tblVerification.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(tblVerification);
            }

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
                            byte[] attachmentPath = reader["Attachment"] as byte[];

                            AddPassengerRow(tblVerification, passengerName, attachmentPath, rowIndex++);
                        }
                    }
                }
            }
        }

        private void AddPassengerRow(TableLayoutPanel tblVerification, string passengerName, byte[] attachment, int rowIndex)
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
                Text = passengerName.Split(' ')[0] + "Attachment",
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
            string updateQuery = "UPDATE Accounts SET Status = 'Verified' WHERE [Full Name] = ?";
            string getUserIdQuery = "SELECT ID FROM Accounts WHERE [Full Name] = ?";
            string insertNotificationQuery = "INSERT INTO Notifications (UserID, Message, Status) VALUES (?, ?, ?)";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
            using (OleDbCommand getUserCmd = new OleDbCommand(getUserIdQuery, conn))
            using (OleDbCommand insertCmd = new OleDbCommand(insertNotificationQuery, conn))
            {
                conn.Open();

                // Update status
                updateCmd.Parameters.AddWithValue("?", passengerName);
                updateCmd.ExecuteNonQuery();

                // Get UserID
                getUserCmd.Parameters.AddWithValue("?", passengerName);
                object result = getUserCmd.ExecuteScalar();

                if (result != null)
                {
                    int userId = Convert.ToInt32(result);

                    // Insert Notification
                    insertCmd.Parameters.AddWithValue("?", userId);
                    insertCmd.Parameters.AddWithValue("?", "verified");
                    insertCmd.Parameters.AddWithValue("?", "Unread");

                    insertCmd.ExecuteNonQuery();
                }
            }

            LoadPendingPassengers();
        }


        private void RejectPassenger(string passengerName)
        {
            string updateQuery = "UPDATE Accounts SET Status = 'Rejected' WHERE [Full Name] = ?";
            string getUserIdQuery = "SELECT ID FROM Accounts WHERE [Full Name] = ?";
            string insertNotificationQuery = "INSERT INTO Notifications (UserID, Message, Status) VALUES (?, ?, ?)";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
            using (OleDbCommand getUserCmd = new OleDbCommand(getUserIdQuery, conn))
            using (OleDbCommand insertCmd = new OleDbCommand(insertNotificationQuery, conn))
            {
                conn.Open();

                // Update status
                updateCmd.Parameters.AddWithValue("?", passengerName);
                updateCmd.ExecuteNonQuery();

                // Get UserID
                getUserCmd.Parameters.AddWithValue("?", passengerName);
                object result = getUserCmd.ExecuteScalar();

                if (result != null)
                {
                    int userId = Convert.ToInt32(result);

                    // Insert Notification
                    insertCmd.Parameters.AddWithValue("?", userId);
                    insertCmd.Parameters.AddWithValue("?", "rejected");
                    insertCmd.Parameters.AddWithValue("?", "Unread");

                    insertCmd.ExecuteNonQuery();
                }
            }

            LoadPendingPassengers();
        }


        private void DisplayAttachment(byte[] fileName)
        {
            DialogBox dialog = new DialogBox();

            DisplayImage displayImage = new DisplayImage(fileName, "register");
            dialog.ShowOverlay(displayImage, null);
        }

        private void SelectButton(FontAwesome.Sharp.IconButton button)
        {
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.White;
                selectedButton.ForeColor = Color.Black;
                selectedButton.Font = new(selectedButton.Font.FontFamily, 18, selectedButton.Font.Style);
            }

            selectedButton = button;
            selectedButton.BackColor = Color.FromArgb(0, 229, 255);
            selectedButton.ForeColor = Color.FromArgb(24, 60, 114);
            selectedButton.Font = new(selectedButton.Font.FontFamily, 24, selectedButton.Font.Style);
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            SelectButton(btnPassengers);
            DisplayAllPassengers();
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            SelectButton(btnVerification);
            LoadPendingPassengers();
        }

        private void btnCashIn_Click(object sender, EventArgs e)
        {
            SelectButton(btnCashIn);
            DisplayCashInRequests();
        }

        private void DisplayCashInRequests()
        {
            pnlContainer.Controls.Clear();

            if (!pnlContainer.Controls.Contains(tblVerification))
            {
                tblVerification.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(tblVerification);
            }

            for (int i = tblVerification.Controls.Count - 1; i >= 0; i--)
            {
                Control control = tblVerification.Controls[i];
                int rowIndex = tblVerification.GetRow(control);
                if (rowIndex >= 1) // Skip headers (row 0)
                {
                    tblVerification.Controls.RemoveAt(i);
                }
            }

            string query = "SELECT UserID, [Full Name], Amount FROM [Cash In]";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        int rowIndex = 1;

                        while (reader.Read())
                        {
                            int userID = Convert.ToInt32(reader["UserID"]);
                            string passengerName = reader["Full Name"].ToString();

                            // Properly cast Amount to double
                            double amount = Convert.ToDouble(reader["Amount"]);

                            AddCashInRequests(tblVerification, userID, passengerName, amount, rowIndex++);
                        }
                    }
                }
            }
        }

        private void AddCashInRequests(TableLayoutPanel tblVerification, int userID, string passengerName, double amount, int rowIndex)
        {
            lblHeader2.Text = "Amount";
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

            Label lblAmount = new Label
            {
                Text = amount.ToString("N2"), // Format as currency
                Dock = DockStyle.Fill,
                ForeColor = Color.FromArgb(24, 60, 114),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Inter", 17F, FontStyle.Regular),
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

            btnApprove.Click += (sender, e) => ApproveCashIn(userID, passengerName);
            btnReject.Click += (sender, e) => RejectCashIn(userID, passengerName);

            tblVerification.Controls.Add(lblName, 0, rowIndex);
            tblVerification.Controls.Add(lblAmount, 1, rowIndex);
            tblVerification.Controls.Add(btnApprove, 2, rowIndex);
            tblVerification.Controls.Add(btnReject, 3, rowIndex);
        }


        private void ApproveCashIn(int UserID, string name)
        {
            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                OleDbTransaction transaction = conn.BeginTransaction(); 

                double amount = 0;
                string getAmountQuery = "SELECT Amount FROM [Cash In] WHERE UserID = ?";
                using (OleDbCommand cmd = new OleDbCommand(getAmountQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("?", UserID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        amount = Convert.ToDouble(result);
                    }
                }

                double currentWallet = 0;
                string getWalletQuery = "SELECT Wallet FROM Accounts WHERE ID = ?";
                using (OleDbCommand cmd = new OleDbCommand(getWalletQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("?", UserID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        currentWallet = Convert.ToDouble(result);
                    }
                }

                double newBalance = currentWallet + amount;
                string updateWalletQuery = "UPDATE Accounts SET Wallet = ? WHERE ID = ?";
                using (OleDbCommand cmd = new OleDbCommand(updateWalletQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("?", newBalance);
                    cmd.Parameters.AddWithValue("?", UserID);
                    cmd.ExecuteNonQuery();
                }

                string insertTransactionQuery = "INSERT INTO Transactions (UserID, TransactionDate, [Full Name], Amount, [Type]) VALUES (?, ?, ?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(insertTransactionQuery, conn, transaction))
                {
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = UserID;  
                    cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now; 
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = name;  
                    cmd.Parameters.Add("?", OleDbType.Double).Value = amount; 
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = "Cash In";  

                    cmd.ExecuteNonQuery();
                }

                string deleteQuery = "DELETE FROM [Cash In] WHERE UserID = ?";
                using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("?", UserID);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();

                DisplayCashInRequests();
            }
        }

        private void RejectCashIn(int UserID, string name)
        {
            string deleteQuery = "DELETE FROM [Cash In] WHERE UserID = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", UserID);
                    cmd.ExecuteNonQuery();
                }
            }
            DisplayCashInRequests();
        }
    }
}
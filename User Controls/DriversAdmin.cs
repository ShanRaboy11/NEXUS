using NEXUS.Classes;
using NEXUS.Forms;
using ReaLTaiizor.Controls;
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

namespace NEXUS.User_Controls
{
    public partial class DriversAdmin : UserControl
    {
        private FontAwesome.Sharp.IconButton selectedButton = null;
        private FontAwesome.Sharp.IconButton currentBtn;
        public DriversAdmin()
        {
            InitializeComponent();
            pnlDisplay.Tag = tblVerification;
            DisplayAllDrivers();
            btnDrivers_Click(btnDrivers, EventArgs.Empty);

        }

        private void DisplayAllDrivers()
        {
            // Clear any existing controls in pnlContainer
            pnlDisplay.Controls.Clear();

            // Create an instance of the PassengersAdmin UserControl
            DataGrid dataGrid = new DataGrid("Driver")
            {
                Dock = DockStyle.Fill
            };

            // Add the user control to the panel
            pnlDisplay.Controls.Add(dataGrid);
        }

        private void LoadPendingDrivers()
        {
            pnlDisplay.Controls.Clear();

            if (!pnlDisplay.Controls.Contains(tblVerification))
            {
                tblVerification.Dock = DockStyle.Fill;
                pnlDisplay.Controls.Add(tblVerification);
            }
            for (int i = tblVerification.Controls.Count - 1; i >= 0; i--)
            {
                Control control = tblVerification.Controls[i];
                int rowIndex = tblVerification.GetRow(control);
                if (rowIndex >= 1)
                {
                    tblVerification.Controls.RemoveAt(i);
                }
            }

            string query = "SELECT [Full Name], Attachment FROM Accounts WHERE Status = 'Pending' AND [User Type] = 'Driver'";

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
                            string driverName = reader["Full Name"].ToString();
                            byte[] attachmentPath = reader["Attachment"] as byte[];

                            AddDriverRow(tblVerification, driverName, attachmentPath, rowIndex++);
                        }
                    }
                }
            }
        }

        private void AddDriverRow(TableLayoutPanel tblVerification, string driverName, byte[] attachment, int rowIndex)
        {
            if (rowIndex >= tblVerification.RowCount)
            {
                tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
                tblVerification.RowCount++;
            }

            Label lblName = new Label
            {
                Text = driverName,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Inter", 17F, FontStyle.Regular),
                ForeColor = Color.FromArgb(24, 60, 114)
            };



            Label lblAttachment = new Label
            {
                Text = driverName.Split(' ')[0] + "Attachment",
                Dock = DockStyle.Fill,
                ForeColor = Color.FromArgb(24, 60, 114),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Inter", 17F, FontStyle.Underline),
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

            btnApprove.Click += (sender, e) => ApproveDriver(driverName);
            btnReject.Click += (sender, e) => RejectDriver(driverName);
            lblAttachment.Click += (sender, e) => DisplayAttachment(attachment);

            tblVerification.Controls.Add(lblName, 0, rowIndex);
            tblVerification.Controls.Add(lblAttachment, 1, rowIndex);
            tblVerification.Controls.Add(btnApprove, 2, rowIndex);
            tblVerification.Controls.Add(btnReject, 3, rowIndex);
        }

        private void ApproveDriver(string driverName)
        {
            string query = "UPDATE Accounts SET Status = 'Verified' WHERE [Full Name] = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", driverName);

                int rowsAffected = cmd.ExecuteNonQuery();
            }

            LoadPendingDrivers();
        }

        private void RejectDriver(string driverName)
        {
            string query = "UPDATE Accounts SET Status = 'Rejected' WHERE [Full Name] = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", driverName);

                int rowsAffected = cmd.ExecuteNonQuery();
            }

            LoadPendingDrivers();
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

        private void DisplayCashOutRequests()
        {
            pnlDisplay.Controls.Clear();

            if (!pnlDisplay.Controls.Contains(tblVerification))
            {
                tblVerification.Dock = DockStyle.Fill;
                pnlDisplay.Controls.Add(tblVerification);
            }

            for (int i = tblVerification.Controls.Count - 1; i >= 0; i--)
            {
                Control control = tblVerification.Controls[i];
                int rowIndex = tblVerification.GetRow(control);
                if (rowIndex >= 1)
                {
                    tblVerification.Controls.RemoveAt(i);
                }
            }

            string query = "SELECT UserID, [Full Name], Amount FROM [Cash Out]";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
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
                        double amount = Convert.ToDouble(reader["Amount"]);

                        AddCashOutRequests(tblVerification, userID, passengerName, amount, rowIndex++);
                    }
                }
            }
        }

        private void AddCashOutRequests(TableLayoutPanel tblVerification, int userID, string passengerName, double amount, int rowIndex)
        {
            label2.Text = "Amount";
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
                Text = amount.ToString("N2"),
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

            btnApprove.Click += (sender, e) => ApproveCashOut(userID, passengerName, amount);
            btnReject.Click += (sender, e) => RejectCashOut(userID);

            tblVerification.Controls.Add(lblName, 0, rowIndex);
            tblVerification.Controls.Add(lblAmount, 1, rowIndex);
            tblVerification.Controls.Add(btnApprove, 2, rowIndex);
            tblVerification.Controls.Add(btnReject, 3, rowIndex);
        }

        private void ApproveCashOut(int userID, string name, double amount)
        {
            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                OleDbTransaction transaction = conn.BeginTransaction();

                // Get current wallet
                double currentWallet = 0;
                string getWalletQuery = "SELECT Wallet FROM Accounts WHERE ID = ?";
                using (OleDbCommand cmd = new OleDbCommand(getWalletQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("?", userID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        currentWallet = Convert.ToDouble(result);
                    }
                }

                // Deduct the amount
                double newBalance = currentWallet - amount;
                string updateWalletQuery = "UPDATE Accounts SET Wallet = ? WHERE ID = ?";
                using (OleDbCommand cmd = new OleDbCommand(updateWalletQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("?", newBalance);
                    cmd.Parameters.AddWithValue("?", userID);
                    cmd.ExecuteNonQuery();
                }

                // Insert transaction log
                string insertTransactionQuery = "INSERT INTO Transactions (UserID, TransactionDate, [Full Name], Amount, [Type]) VALUES (?, ?, ?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(insertTransactionQuery, conn, transaction))
                {
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = userID;
                    cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = name;
                    cmd.Parameters.Add("?", OleDbType.Double).Value = amount;
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = "Cash Out";

                    cmd.ExecuteNonQuery();
                }

                // Delete from Cash Out table
                string deleteQuery = "DELETE FROM [Cash Out] WHERE UserID = ?";
                using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("?", userID);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                DisplayCashOutRequests();
            }
        }

        private void RejectCashOut(int userID)
        {
            string deleteQuery = "DELETE FROM [Cash Out] WHERE UserID = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", userID);
                    cmd.ExecuteNonQuery();
                }
            }

            DisplayCashOutRequests();
        }


        private void btnDrivers_Click(object sender, EventArgs e)
        {
            SelectButton(btnDrivers);
            DisplayAllDrivers();
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            SelectButton(btnVerification);
            LoadPendingDrivers();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SelectButton(btnCashOut);
            DisplayCashOutRequests();
        }
    }
}

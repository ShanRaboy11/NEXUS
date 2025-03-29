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

        private void SelectButton(FontAwesome.Sharp.IconButton button)
        {
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.FromArgb(230, 249, 255);
                selectedButton.ForeColor = Color.Black;
                button.Font = new(button.Font.FontFamily, 18, button.Font.Style);
            }

            selectedButton = button;
            button.BackColor = Color.FromArgb(0, 229, 255);
            button.Font = new (button.Font.FontFamily, 20, button.Font.Style);
            button.ForeColor = Color.White;
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
                    else
                    {
                        MessageBox.Show("Error: Cash-in request not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
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

        }

        private void DeleteSelectedRecord(DataGridView dgv, string tableName)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Identify the Primary Key (Assuming it's the first column)
            string primaryKeyColumn = dgv.Columns[0].Name;
            object selectedID = dgv.SelectedRows[0].Cells[primaryKeyColumn].Value;

            if (selectedID == null)
            {
                MessageBox.Show("Invalid selection. No ID found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM {tableName} WHERE {primaryKeyColumn} = ?";

                using (OleDbConnection conn = DatabaseManagement.GetConnection())
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("?", selectedID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index); // Remove from DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed. Record may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
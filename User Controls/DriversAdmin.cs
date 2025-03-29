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
                            string attachmentPath = reader["Attachment"].ToString();

                            AddDriverRow(tblVerification, driverName, attachmentPath, rowIndex++);
                        }
                    }
                }
            }
        }

        private void AddDriverRow(TableLayoutPanel tblVerification, string driverName, string attachment, int rowIndex)
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
                Text = attachment,
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
            string query = "UPDATE Accounts SET Status = 'Approved' WHERE [Full Name] = ?";

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

        private void DisplayAttachment(string fileName)
        {
            Scan scan = new Scan(null);
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("No attachment found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construct the full path using AppContext.BaseDirectory
            string filePath = Path.Combine(AppContext.BaseDirectory, "Attachments", fileName);

            if (File.Exists(filePath))
            {
                Image image = Image.FromFile(filePath);
                DisplayImage display = new DisplayImage(image, "register");
                scan.ShowOverlay(display, null);
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
            button.Font = new(button.Font.FontFamily, 20, button.Font.Style);
            button.ForeColor = Color.White;
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

    }
}

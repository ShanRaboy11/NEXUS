using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using static QRCoder.PayloadGenerator;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using NEXUS.Classes;
using NEXUS.Forms;

namespace NEXUS.User_Controls
{
    public partial class ForgetPassword1 : UserControl
    {
        private string resetCode;
        Panel pnlContainer;
        bool isClicked;
        public ForgetPassword1(Panel pnlcontainer)
        {
            InitializeComponent();
            this.pnlContainer = pnlcontainer;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmail.Text.Trim();
            DialogBox dialogBox = new DialogBox();
            if (string.IsNullOrEmpty(userEmail))
            {
                dialogBox.ShowIcon("blank");
                dialogBox.ShowDialog();
                return;
            }
            
            string query = "SELECT [Email Address] FROM Accounts WHERE [Email Address] = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", userEmail);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    dialogBox.ShowIcon("invalid email");
                    dialogBox.ShowDialog();
                    return;
                }
            }
            
            Random rand = new Random();
            resetCode = rand.Next(10000, 99999).ToString();

            string from = "shanraboy11@gmail.com";
            string password = "waac qbyd ajwo zxhp";

            MailMessage message = new MailMessage
            {
                From = new MailAddress(from, "NEXUS: Public Utility Vehicle System"),
                Subject = "Password Reset Code",
                Body = $"Your password reset code is: {resetCode}"
            };

            message.To.Add(userEmail);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(from, password)
            };
            smtp.Send(message);

            pnlContainer.Controls.Clear();

            ForgetPassword2 forgetPassword2 = new ForgetPassword2(pnlContainer, resetCode, userEmail)
            {
                Dock = DockStyle.Fill
            };

            pnlContainer.Controls.Add(forgetPassword2);
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (isClicked) return;

            isClicked = true;
            txtEmail.Text = "";
        }
    }
}

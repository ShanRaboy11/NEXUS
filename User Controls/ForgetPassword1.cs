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

            string from = "SENDER EMAIL";
            string password = "APP PASSWORD";

            MailMessage message = new MailMessage
            {
                From = new MailAddress(from, "NEXUS: Public Utility Vehicle System"),
                Subject = "Password Reset Code",
                IsBodyHtml = true,
                Body = $@"
    <div style='font-family:Segoe UI, sans-serif; color:#333; padding:20px;'>
        <h2 style='color:#183c72;'>Password Reset Request</h2>
        <p style='font-size:15px;'>
            We received a request to reset your password for your <strong>NEXUS</strong> account.
        </p>
        <p style='font-size:15px;'>
            Your password reset code is: 
            <span style='font-weight:bold; color:#183c72; font-size:18px;'>{resetCode}</span>
        </p>
        <p style='font-size:14px;'>
            If you did not request a password reset, please ignore this email or contact our support team.
        </p>
        <p style='margin-top:30px; font-size:15px;'>Stay safe,<br/>
        <span style='color:#183c72; font-weight:bold;'>NEXUS Team</span></p>
        <hr style='margin-top:40px; border:0; border-top:1px solid #ccc;'/>
        <p style='font-size:12px; color:gray;'>
            This is an automated message. Please do not reply directly to this email.
        </p>
    </div>"
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace NEXUS.Classes
{
    internal class Email
    {

        public static void SendRegistrationEmail(string recipientEmail, string fullName)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                string senderEmail = "SENDER EMAIL";
                string appPassword = "APP PASSWORD";

                mail.From = new MailAddress(senderEmail, "NEXUS: Public Utility Vehicle System");
                mail.To.Add(recipientEmail);
                mail.Subject = "Welcome to NEXUS!";

                mail.IsBodyHtml = true;

                mail.Body = $@"
        <div style='font-family:Segoe UI, sans-serif; color:#333; padding:20px;'>
            <h2 style='color:#183c72;'>Welcome to <span style='font-weight:bold;'>NEXUS</span>!</h2>
            <p style='font-size:16px;'>Hello <strong>{fullName}</strong>,</p>
            <p style='font-size:15px;'>
                Thank you for registering with <strong>NEXUS: Public Utility Vehicle System</strong>.<br />
                Your account has been <span style='color:green; font-weight:bold;'>successfully created</span>.
            </p>
            <p style='font-size:15px;'>
                We’re thrilled to have you on board. From tracking public utility routes to receiving real-time updates, 
                your experience is about to get more seamless and efficient.
            </p>
            <p style='margin-top:30px; font-size:15px;'>Warm regards,<br/>
            <span style='color:#183c72; font-weight:bold;'>NEXUS Team</span></p>
            <hr style='margin-top:40px; border:0; border-top:1px solid #ccc;'/>
            <p style='font-size:12px; color:gray;'>
                This is an automated email. Please do not reply to this message.
            </p>
        </div>";

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential(senderEmail, appPassword);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send registration email:\n" + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

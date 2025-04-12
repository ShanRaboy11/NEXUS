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

                string senderEmail = "shanraboy11@gmail.com";
                string appPassword = "waac qbyd ajwo zxhp"; 

                mail.From = new MailAddress(senderEmail, "NEXUS: Public Utility Vehicle System");
                mail.To.Add(recipientEmail);
                mail.Subject = "Welcome to NEXUS!";
                mail.Body = $"Hello {fullName},\n\nThank you for registering with NEXUS! Your account has been created successfully.\n\nBest regards,\nNEXUS Team";

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
        public static string GeneratedCode { get; private set; }

        public static bool ForgetPassword(string userEmail, string senderEmail, string senderPassword, out string resultMessage)
        {
            try
            {
                Random rand = new Random();
                GeneratedCode = rand.Next(100000, 999999).ToString(); // 6-digit code

                MailMessage message = new MailMessage();
                string messageBody = $"Your password reset code is: {GeneratedCode}";

                message.To.Add(userEmail);
                message.From = new MailAddress(senderEmail);
                message.Subject = "Password Reset Code";
                message.Body = messageBody;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = true,
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(senderEmail, senderPassword)
                };

                smtp.Send(message);
                resultMessage = "Reset code sent successfully.";
                return true;
            }
            catch (Exception ex)
            {
                resultMessage = "Error sending email: " + ex.Message;
                return false;
            }
        }
    }
}

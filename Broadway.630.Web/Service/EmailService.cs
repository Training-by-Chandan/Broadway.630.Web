using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Broadway._630.Web.Service
{
    public class EmailService
    {
        public static void SendEmail(string email, string username, string password = "")
        {
            var receiver = new MailAddress(email, username);
            var sender = new MailAddress("gchandaniw@gmail.com", "Chandan Gupta Bhagat");

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential("gchandaniw@gmail.com", "wvtzxhtqsuapljhy")
            };

            var attchment = new Attachment("D:\\list.txt");

            var msg = new MailMessage(sender, receiver)
            {
                Subject = "Password changed as per Requested",
                Body = $"Hi {username}! your new password is Test@123.\nPlease login to continue.",
            };
            msg.Attachments.Add(attchment);
            msg.Bcc.Add(new MailAddress("nirojgansi@gmail.com", "Niroj"));
            msg.Bcc.Add(new MailAddress("pallabi.mallik3663@gmail.com", "Pallabi"));

            smtp.Send(msg);
        }

        public static string GenerateRandomPassword()
        {
            return "Test@123";
        }
    }
}
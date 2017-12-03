using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Integration.Api;
using System.Net.Mail;
using System.Net;

namespace Company.Integration.Services
{
    public class GmailSender : IMailSender
    {
        public void SendMail(string source, string destination, string password, string subject, string body)
        {
            var fromAddress = new MailAddress(source);
            var toAddress = new MailAddress(destination);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, password)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                //smtp.Send(message);
            }
        }
    }
}

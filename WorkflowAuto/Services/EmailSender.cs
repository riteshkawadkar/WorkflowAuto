using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace WorkflowAuto.Services
{
    public class EmailSender : IEmailSender
    {
        private string smtpServer;
        private int portnumber;
        private string fromemail;

        public EmailSender(string smtpServer, int portnumber, string fromemail)
        {
            this.smtpServer = smtpServer;
            this.portnumber = portnumber;
            this.fromemail = fromemail;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(fromemail),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));

            using (var client = new SmtpClient(smtpServer, portnumber))
            {
                client.Send(message);
            }

            return Task.CompletedTask;
        }
    }
}

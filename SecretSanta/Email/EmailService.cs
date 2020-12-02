using SecretSanta.Participants;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace SecretSanta.EmailService
{
    internal class EmailService : IEmailService
    {
        private const string Mail = "secret.tovlisbabua@gmail.com";

        private const string Password = "";
        
        private const string Subject = "ჯადოსნური დღესასწაული";
        
        private const string SenderName = "Secret Santa";

        private readonly SmtpClient _smtp;

        public EmailService()
        {
            _smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(Mail, Password)
            };
        }

        public void Send(KeyValuePair<Participant, Participant> pair, string htmlBody)
        {
            System.Console.WriteLine(pair.Key.Email);

            var mailMessage = new MailMessage(Mail, pair.Key.Email, Subject, htmlBody)
            {
                IsBodyHtml = true,
                From = new MailAddress(Mail, SenderName)
            };

            _smtp.Send(mailMessage);
        }
    }
}
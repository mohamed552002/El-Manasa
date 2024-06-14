using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FutureEducationalPlatform.Application.Common.HelperModels;

namespace FutureEducationalPlatform.Application.Services.HelperServices
{
    public class EmailSender : IEmailSender
    {
        private readonly MessageSender _messageSender;

        public EmailSender(IOptions<MessageSender> messageSender)
        {
            _messageSender = messageSender.Value;
        }

        public void SendEmail(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage();
            message.From = new MailAddress(_messageSender.Email);
            message.Subject = subject;
            message.Body = $"<html><body>{htmlMessage}</body></html>";
            message.To.Add(email);
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp-relay.brevo.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(_messageSender.Email, _messageSender.Password),
                EnableSsl = true
            };
            smtpClient.Send(message);
        }
    }
}

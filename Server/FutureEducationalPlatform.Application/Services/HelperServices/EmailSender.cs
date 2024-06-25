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
            message.Body = $"<style>    .head{{       height: 20vh;        display: flex;      color: white;\r\n        background-color: #43b0f3;\r\n        justify-content: center;\r\n        align-items: center;\r\n    }}\r\n    .head h1{{\r\n        font-size: xxx-large;\r\n        font-family: sans-serif;\r\n    }}\r\n    .text{{\r\n        margin-top: 20vh;\r\n    display: flex;\r\n    justify-content: center;\r\n    align-items: center;\r\n    }}\r\n    .text .text-box{{\r\n        width: 450px;\r\n        display: flex;\r\n        height: 175px;\r\n        padding-left: 30px;\r\n        background: #eee;\r\n        justify-content: center;\r\n        align-items: center;\r\n        border-radius: 10px;\r\n    }}\r\n    .text .text-box p{{\r\n        font-size: xxx-large;\r\n        letter-spacing: 30px;\r\n        font-family: sans-serif;\r\n    }}\r\n</style>\r\n<div  class=\"head\">\r\n    <h1>Your OTP Is</h1>\r\n</div>\r\n<div class=\"text\">\r\n    <div class=\"text-box\">\r\n        <p>{htmlMessage}</p>\r\n    </div>\r\n</div>";
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

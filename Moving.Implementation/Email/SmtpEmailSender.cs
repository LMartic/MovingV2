using Microsoft.Extensions.Options;
using Moving.Application.Email;
using Moving.Implementation.Extensions;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Moving.Implementation.Email
{
    public class SmtpEmailSender : IEmailSender
    {
        private readonly EmailSettings _appSettings;

        public SmtpEmailSender(IOptions<EmailSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public Task Send(SendEmailDto dto)
        {
            // Plug in your email service here to send an email.
            return ConfigSmtpAsync(dto.SendTo, dto.Subject, dto.Content);
            //return Task.FromResult(0);
        }
        private async Task ConfigSmtpAsync(string email, string subject, string message)
        {
            var apiKey = _appSettings.SmtpPassword;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("admin@moving.com", "Admin Moving");
            var to = new EmailAddress(email, email);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "Thank you for choosing us", message);
            var response = await client.SendEmailAsync(msg);


        }
    }
}

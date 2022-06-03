using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using PayRoll.CrossCutting.Common.Interfaces;
using PayRoll.CrossCutting.Common.Models;
using PayRoll.CrossCutting.Common.Settings;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.CrossCutting.Common.Repository
{
    public class EmailService : IEmailService
    {
        public SettingEmail _settingEmail { get; }
        public ILogger<EmailService> _logger { get; }

        public EmailService(IOptions<SettingEmail> settingEmail, ILogger<EmailService> logger)
        {
            _settingEmail = settingEmail.Value;
            _logger = logger;
        }

        public async Task<bool> SendEmail(Email email)
        {
            var client = new SendGridClient(_settingEmail.ApiKey);

            var subject = email.Subject;
            var to = new EmailAddress(email.To);
            var emailBody = email.Body;

            var from = new EmailAddress
            {
                Email = _settingEmail.FromAddress,
                Name = _settingEmail.FromName
            };

            var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, emailBody, emailBody);
            var response = await client.SendEmailAsync(sendGridMessage);

            _logger.LogInformation("Email sent.");

            if (response.StatusCode == System.Net.HttpStatusCode.Accepted || response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;

            _logger.LogError("Email sending failed.");

            return false;
        }
    }
}

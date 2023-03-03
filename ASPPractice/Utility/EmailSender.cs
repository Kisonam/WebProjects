using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;

namespace ASPPractice.Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _confinguration;
        public MailJetSettings _mailJetSettings { get; set; }
        public EmailSender(IConfiguration configuration)
        {
            _confinguration = configuration;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }

        public async Task Execute(string email, string subject, string body)
        {
            _mailJetSettings = _confinguration.GetSection("MailJet").Get<MailJetSettings>();
            MailjetClient client = new MailjetClient(_mailJetSettings.ApiKey,_mailJetSettings.SecretKey);
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
               .Property(Send.FromEmail, "kisonamplay@gmail.com")
               .Property(Send.FromName, "Night")
               .Property(Send.To, email)
               .Property(Send.Subject, subject)
               .Property(Send.HtmlPart,body)
               .Property(Send.Recipients, new JArray 
               {
                    new JObject
                    {
                        {"Email", email}
                    }
               });
            MailjetResponse response = await client.PostAsync(request);
        }
    }

}
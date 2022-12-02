using MailKit.Net.Smtp;
using MimeKit;


namespace EmailServices
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _emailConfig;

        public EmailSender(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
        }

        private void Sendmail(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
                try
                {
                    client.Connect(_emailConfig.SmtpServer, _emailConfig.Port, false);
                    //client.AuthenticationMechanisms.Remove("XOAUTH");
                    client.Authenticate(_emailConfig.Username, _emailConfig.Password);

                    client.Send(mailMessage);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
        }
        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("", _emailConfig.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };
            return emailMessage;
        }

        public void SendEmail(Message message)
        {
            MimeMessage emailMessage = CreateEmailMessage(message);
            Sendmail(emailMessage);
        }
    }
}
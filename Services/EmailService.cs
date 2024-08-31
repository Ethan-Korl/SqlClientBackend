using System.Net.Mail;
using SqlClientBackend.Configs


namespace SqlClientBackend.Service
{
    public class SendEmail
    {
        public Task SendEmailAsync(string userEmail, string subject, string message)
        {
            var EmailHost = GeneralConfigs.Email;
            var EmailPassword = GeneralConfigs.EmailPassword;

            var client = new SmtpClient("stm@gmail.com", 587){
                EnableSsl = true,
                Credentials = new NetworkCredential(EmailHost, EmailPassword);
            }

            return client.SendMailAsync(
                new MailMessage(
                    from: EmailHost,
                    to: userEmail,
                    subject: subject,
                    message
                )
            )

        }
    }
}
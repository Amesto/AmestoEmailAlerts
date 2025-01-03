using AmestoEmailAlerts.Template;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Text;

namespace AmestoEmailAlerts
{
    public class EmailAlert
    {
        private readonly string htmlFilePath = "";
        private readonly SendGridClient sendGridClient;
        public EmailAlert()
        {
            htmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EmailTemplate.html");
            sendGridClient = new SendGridClient("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");
        }

        public async Task<bool> SendEmailAlert(string logSubject, List<ErrorEntry> errorEntry, List<ReceipentInfo> receipentInformation, string systemName)
        {
            if (errorEntry == null)
            {
                return false;
            }

            if (errorEntry.Count == 0)
            {
                return false;
            }

            var htmlTemplate = EmailTemplateContent.Template;

            if (string.IsNullOrEmpty(logSubject))
            {
                logSubject = "Error Messages";
            }

            if (string.IsNullOrEmpty(systemName))
            {
                logSubject = "Application from Amesto Solution";
            }

            if (File.Exists(htmlFilePath))
            {
                htmlTemplate = File.ReadAllText(htmlFilePath);
            }

            var content = new StringBuilder();

            content.AppendLine("<table id=\"tbalstyle\">");

            content.AppendLine("<td style=\"padding:8px;border:black 1px solid;border-collapse:collapse;font-weight:bold;\">Type</td>");
            content.AppendLine("<td style=\"padding:8px;border:black 1px solid;border-collapse:collapse;font-weight:bold;\">Message</td>");
            content.AppendLine("<td style=\"padding:8px;border:black 1px solid;border-collapse:collapse;font-weight:bold;\">TimeStamp</td>");

            foreach (var error in errorEntry)
            {
                content.AppendLine("<tr>");
                content.AppendLine(
                    "<td style=\"width:10%;padding:8px;border:black 1px solid;border-collapse:collapse;\"> " +
                    error.Severity.ToString() + "</td>");
                content.AppendLine($"<td style=\"padding:8px;border:black 1px solid;border-collapse:collapse;\">" +
                                   $"<span style=\"font-size:18px;font-family:Arial,Helvetica,sans-serif;font-weight:normal;\">" +
                                   error.Message.ToString() + "</span>" +
                                   "<br/>" +
                                   $"</td>");
                content.AppendLine($"<td style=\"width:20%;padding:8px;border:black 1px solid;border-collapse:collapse;\">" +
                                 $"<span style=\"font-size:18px;font-family:Arial,Helvetica,sans-serif;font-weight:normal;\">" +
                                 error.TimeStamp.ToString("dd.MM.yyyy HH:mm:ss") + "</span>" +
                                 "<br/>" +
                                 $"</td>");
                content.AppendLine("</tr>");
            }


            content.AppendLine("</table>");

            content.AppendLine("<br/><br/><br/>");

            htmlTemplate = htmlTemplate.Replace("*|BODY|*", content.ToString());
            htmlTemplate = htmlTemplate.Replace("*|CURRENT_YEAR|*", DateTime.UtcNow.Year.ToString());
            htmlTemplate = htmlTemplate.Replace("*|EmailSubject|*", "Feilmeldinger integrasjon ");
            htmlTemplate = htmlTemplate.Replace("*|ToEmail|*", "this email");
            htmlTemplate = htmlTemplate.Replace("*|Amesto logging|*", systemName);

            var from = new EmailAddress("integrasjoner@amesto.no", "Feilmeldinger NSF integrasjoner");
            var subject = logSubject;
            var htmlContent = htmlTemplate;

            var listOfEmails = new List<EmailAddress>();
            foreach (var email in receipentInformation)
                if (!string.IsNullOrEmpty(email.Email))
                    listOfEmails.Add(new EmailAddress(email.Email, email.Name));
            try
            {
                var Message = MailHelper.CreateSingleEmailToMultipleRecipients(from, listOfEmails, subject, null, htmlContent);
                var response = await sendGridClient.SendEmailAsync(Message);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

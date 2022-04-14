using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        public const int ClientPort = 25;
        public const bool SslEnabled = false;
        public const string HostIp = "127.0.0.1";
        public const bool DefaultCredentialsEnabled = true;

        private static void UpdateClient(this SmtpClient client)
        {
            client.Port = ClientPort;
            client.EnableSsl = SslEnabled;
            client.Host = HostIp;
            client.UseDefaultCredentials = DefaultCredentialsEnabled;
        }

        public static void SendEmail(string to, string subject, string body)
        {
            SendEmail(new List<string> { to }, new List<string>(), subject, body);
        }
        public static void SendEmail(List<string> to, List<string> bcc, string subject, string body)
        {
            MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.AppKeyLookup("senderDisplayName"));

            MailMessage mail = new MailMessage();

            foreach (string email in to)
            {
                mail.To.Add(email);
            }
            foreach (string email in bcc)
            {
                mail.Bcc.Add(email);
            }

            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.UpdateClient();
            client.Send(mail);

            // .NETCORE conflict with having <system.net> in app.Config
            //<smtp deliveryMethod="Network">
            //< network host = "127.0.0.1" userName = "Tim" password = "testing" port = "25" enableSsl = "false" />

            // ideally have the client information in a config file of some kind to allow it to be changed at run time.
        }
    }
}

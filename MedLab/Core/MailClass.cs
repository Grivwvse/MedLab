using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProgramm.Core
{
    class MailClass
    {
        public MimeMessage email = new MimeMessage();
        public MailClass(string filePath, string clientMail)
        {
            //email.From.Add(MailboxAddress.Parse("med.lab.results.help@gmail.com"));
            email.From.Add(MailboxAddress.Parse("med.lab.results@mail.ru"));
            email.To.Add(MailboxAddress.Parse($"{clientMail}"));
            email.Subject = "Результаты анализов";
            //email.Body = new TextPart(TextFormat.Html) { Text = "Результаты ваших анализо" };
            var builder = new BodyBuilder();
            builder.TextBody = "Уважаемый клиент!"+"\n"+"Во вложенном файле Вы можете увидеть результаты исследований по Вашему заказу." +
                "\n" + "ЗАКЛЮЧЕНИЕ О КОНФИДЕНЦИАЛЬНОСТИ."+"\n" +"" +
                "Данное электронное сообщение, включая вложения, содержит конфиденциальную информацию, защищенную законодательством РФ. Оно предназначено исключительно адресату. Всем прочим лицам доступ к данному сообщению, включая вложения, запрещен.";
            builder.Attachments.Add($@"{filePath}");
            email.Body = builder.ToMessageBody();
        }
        public void SendMessage()
        {
            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.mail.ru", 587);


                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                smtp.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                smtp.Authenticate("med.lab.results@mail.ru", "MHh1XwbxBvQwZPD5J5X0");

                smtp.Send(email);
                smtp.Disconnect(true);
            }


            //var smtp = new SmtpClient();
            //smtp.Connect("smtp.mail.ru", 2525);
            ////smtp.AuthenticationMechanisms.Remove("XOAUTH2");
            ////smtp.Authenticate("med.lab.results.help@gmail.com", "MedLabPasswd");
            //smtp.Authenticate("med.lab.results@mail.ru", "MHh1XwbxBvQwZPD5J5X0");
            //smtp.Send(email);
            //smtp.Disconnect(true);
        }
    }
}

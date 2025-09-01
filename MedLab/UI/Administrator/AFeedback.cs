using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace DiplomProgramm.UI.Administrator
{
    public partial class AFeedback : DiplomProgramm.UI.Templates.AdministratorMainTemplate
    {
        public AFeedback()
        {
            InitializeComponent();
        }

        private void AFeedback_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtn("AFeedbackbtn");
        }

        public MimeMessage email = new MimeMessage();
        public string Message = "";
        protected void SendMesage()
        {
            email.From.Add(MailboxAddress.Parse("med.lab.results@mail.ru"));
            email.To.Add(MailboxAddress.Parse("grigorii_trofimov@mail.ru"));
            email.Subject = "Сообщение о Программном продукте!";
            var builder = new BodyBuilder();
            builder.TextBody = $"{Message}";
            email.Body = builder.ToMessageBody();
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
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели текст!");
            }
            else
            {
                Message = guna2TextBox1.Text;
                SendMesage();
                MessageBox.Show("Сообщение отправлено!");
            }

        }
    }
}

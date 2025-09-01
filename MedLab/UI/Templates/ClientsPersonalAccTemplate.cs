using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiplomProgramm.UI.Templates
{
    public partial class ClientsPersonalAccTemplate : DiplomProgramm.Form1
    {
        public ClientsPersonalAccTemplate()
        {
            InitializeComponent();
        }

        private void ClientsPersonalAccTemplate_Load(object sender, EventArgs e)
        {
            
        }

        public void UpdatePersonalAccDataClient()
        {
            ClientsTable currentClient = view.GetClientByID(Program.CurrentClietnPersonalAcc);
            NameLable.Text = currentClient.Name;
            SurnameLable.Text = currentClient.Surname;
            PatronymicLable.Text = currentClient.Patronymic;
            AgeLable.Text = Convert.ToString(DateTime.Now.Year - currentClient.DateOfBirth.Year);
            DateOfBirthLable.Text = Convert.ToString(currentClient.DateOfBirth.ToShortDateString());
            PhoneLable.Text = currentClient.Phone;
            EmailLable.Text = currentClient.Email;
            PasportLable.Text = currentClient.Passport;
            

        }

        public void ChangeBackgroundColourBtnMenu(string value)
        {
            if (value == "EventsBtn")
            {
                EventsBtn.BackColor = Color.Gray;
            }
            else if (value == "ReceptionsBtn")
            {
                ReceptionsBtn.BackColor = Color.Gray;
            }
            else if (value == "ChangeInfoBtn")
            {
                ChangeInfoBtn.BackColor = Color.Gray;
            }
        }
        private void EventsBtn_Click(object sender, EventArgs e)
        {
            Program.Instanses.SecondaryMenu("Events");
        }

        private void ReceptionsBtn_Click(object sender, EventArgs e)
        {
            Program.Instanses.SecondaryMenu("Receptions");
        }

        private void ChangeInfoBtn_Click(object sender, EventArgs e)
        {
            Program.Instanses.SecondaryMenu("ChangeInfo");
        }

        private void RegistrationDateLable_Click(object sender, EventArgs e)
        {

        }
    }
}

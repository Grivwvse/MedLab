using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiplomProgramm.UI.CheckInCastumer.ClientsPersonalAcc
{
    public partial class ChangeInfo : DiplomProgramm.UI.Templates.ClientsPersonalAccTemplate
    {
        public ChangeInfo()
        {
            Program.SecondaryCurrentOpenPage = "ChangeInfo";
            
            InitializeComponent();
        }

        private void ChangeInfo_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtnMenu("ChangeInfoBtn");
            UpdatePersonalAccDataClient();
            LoadInfoTxtBox();
        }

        private void ChangeInfoLablePatronymic_Click(object sender, EventArgs e)
        {

        }

        public ClientsTable client { get; set; }
        public ClientsTable PrevClient { get; set; }

        private void LoadInfoTxtBox()
        {
            client = view.GetClientByID(Program.CurrentClietnPersonalAcc);
            ChangeInfoTxtBoxName.Text = client.Name;
            ChangeInfoTxtBoxSurname.Text = client.Surname;
            ChangeInfoTxtBoxPatronymic.Text = client.Patronymic;
            DataPickerDateOfBirth.Value = client.DateOfBirth;
            ChangeInfoTxtBoxPhone.Text = client.Phone;
            ChangeInfoTxtBoxEmail.Text = client.Email;
            ChangeInfoTxtBoxPasport.Text = client.Passport;
        }

        private void UpdateData()
        {
            UpdatePersonalAccDataClient();
            LoadInfoTxtBox();
        }

        private void SaveChanheInfoClientBtn_Click(object sender, EventArgs e)
        {
            model.UpdateClientInfo(Program.CurrentClietnPersonalAcc, ChangeInfoTxtBoxName.Text, ChangeInfoTxtBoxSurname.Text, ChangeInfoTxtBoxPatronymic.Text,
                DataPickerDateOfBirth.Value, ChangeInfoTxtBoxPhone.Text, ChangeInfoTxtBoxEmail.Text, ChangeInfoTxtBoxPasport.Text);
            PrevClient = client;
            UpdateData();

        }

        private void ChangeInfoCancelChanges_Click(object sender, EventArgs e)
        {
            model.UpdateClientInfo(Program.CurrentClietnPersonalAcc, PrevClient.Name, PrevClient.Surname, PrevClient.Patronymic,
            PrevClient.DateOfBirth, PrevClient.Phone, PrevClient.Email, PrevClient.Passport);
            UpdateData();
        }
    }
}

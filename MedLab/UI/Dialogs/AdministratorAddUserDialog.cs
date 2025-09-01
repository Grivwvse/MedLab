using DiplomProgramm.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProgramm.UI.Dialogs
{
    public partial class AdministratorAddUserDialog : Form
    {
        public AdministratorAddUserDialog()
        {
            InitializeComponent();
        }

        public Model model = new Model();
        private void AdministratorAddUserDialog_Load(object sender, EventArgs e)
        {
            ComboBoxRole.Items.Add("Регистратура");
            ComboBoxRole.Items.Add("Администратор");
            ComboBoxRole.Items.Add("Лаборант");
        }

        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            if (NameTxtBox.Text != "" & SurnameTxtBox.Text != "" & EmailTxtBox.Text != "" & PhoneTxtBox.Text != "" & LoginTxtBox.Text != "" & PasswordTxtBox.Text != "" & ComboBoxRole.SelectedIndex != -1)
            {


                try
                {
                    UsersTable user = new UsersTable();
                    user.Name = NameTxtBox.Text;
                    user.Surname = SurnameTxtBox.Text;
                    user.Email = EmailTxtBox.Text;
                    user.Phone = PhoneTxtBox.Text;
                    user.Login = LoginTxtBox.Text;
                    user.Password = PasswordTxtBox.Text;
                    user.RoleID = ComboBoxRole.SelectedIndex + 1;
                    model.CreateUser(user);


                }
                catch (Exception)
                {

                    MessageBox.Show("Проверьте правильность вводимых данных");
                }
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные!");
            }

        }

        private void ComboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

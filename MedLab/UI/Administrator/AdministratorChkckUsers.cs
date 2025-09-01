using DiplomProgramm.UI.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiplomProgramm.UI.Administrator
{
    public partial class AdministratorChkckUsers : DiplomProgramm.UI.Templates.AdministratorMainTemplate
    {
        public AdministratorChkckUsers()
        {
            InitializeComponent();
        }

        private void AdministratorChkckUsers_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtn("UsersAdminBtn");
            ChooseDatasourceComboBox.Items.Add("Активные пользователи");
            ChooseDatasourceComboBox.Items.Add("Не Активные пользователи");
            ChooseDatasourceComboBox.Items.Add("Все пользователи");

            ChooseDatasourceComboBox.SelectedIndex = 0;
            UpdateDatagrid();
        }

        public void UpdateDatagrid()
        {
            UserDataGridView.DataSource = view.GetUsersForAdmin(ChooseDatasourceComboBox.SelectedIndex);
            UserDataGridView.Columns[0].HeaderText = "Номер пользователя";
            UserDataGridView.Columns[1].HeaderText = "Номер роли";
            UserDataGridView.Columns[2].Visible = false;
            UserDataGridView.Columns[4].HeaderText = "Фамилия";
            UserDataGridView.Columns[3].HeaderText = "Имя";
            UserDataGridView.Columns[5].HeaderText = "Почта";
            UserDataGridView.Columns[6].HeaderText = "Телефон";
            UserDataGridView.Columns[7].HeaderText = "Логин";
            UserDataGridView.Columns[8].HeaderText = "Пароль";
        }

        private void DelUserBtn_Click(object sender, EventArgs e)
        {
            int UserID = -2;
            try
            {
                int SelectedRow = UserDataGridView.CurrentCell.RowIndex;
                var row = UserDataGridView.Rows[SelectedRow];
                UserID = (int)row.Cells[0].Value;
            }
            catch (Exception)
            {

                MessageBox.Show("Произошла ошибка при удалении сервиса");
            }
            if (UserID != -2)
            {
                if (model.DelUserById(UserID) == true)
                {
                    UpdateDatagrid();
                }
            }
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            AdministratorAddUserDialog administratorAddUserDialog = new AdministratorAddUserDialog();
            var result = administratorAddUserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateDatagrid();
            }


        }

        private void ChooseDatasourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }
    }
}

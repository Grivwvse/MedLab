using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiplomProgramm.UI.Administrator
{
    public partial class AdministratorPermissions : DiplomProgramm.UI.Templates.AdministratorMainTemplate
    {
        public AdministratorPermissions()
        {
            InitializeComponent();
        }
        public int ValueID { get; set; } = -2;

        private void AdministratorPermissions_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtn("PermissionsAdminBtn");
            ComboBoxPermissionFor.Items.Add("Пользователей");
            ComboBoxPermissionFor.Items.Add("Ролей системы");

            ComboBoxPermissions.Items.Add("Стандартные пара доступа");
            ComboBoxPermissions.Items.Add("Заблокировать");

            ComboBoxPermissionFor.SelectedIndex = 0;
            UpdateDatagrid();
            AddEventBtn.Enabled = false;
        }

        private void ComboBoxPermissionFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }
        public void UpdateDatagrid()
        {
            if (ComboBoxPermissionFor.SelectedIndex == 0)
            {
                DataGridViewUserRole.DataSource = null;
                DataGridViewUserRole.DataSource = view.GetUsersForAdmin(2);
                DataGridViewUserRole.Columns[0].HeaderText = "Номер пользователя";
                DataGridViewUserRole.Columns[1].HeaderText = "Номер роли";
                DataGridViewUserRole.Columns[2].Visible = false;
                DataGridViewUserRole.Columns[4].HeaderText = "Фамилия";
                DataGridViewUserRole.Columns[3].HeaderText = "Имя";
                DataGridViewUserRole.Columns[5].HeaderText = "Почта";
                DataGridViewUserRole.Columns[6].HeaderText = "Телефон";
                DataGridViewUserRole.Columns[7].HeaderText = "Логин";
                DataGridViewUserRole.Columns[8].HeaderText = "Пароль";
            }
            else if (ComboBoxPermissionFor.SelectedIndex == 1)
            {
                DataGridViewUserRole.DataSource = null;
                DataGridViewUserRole.DataSource = view.AdminGetAllRoles();
                DataGridViewUserRole.Columns[0].HeaderText = "Номер роли";
                DataGridViewUserRole.Columns[1].HeaderText = "Номер прав доступа";
                DataGridViewUserRole.Columns[2].HeaderText = "Наименование";
            }
           
        }

        private void DataGridViewUserRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            if (ComboBoxPermissions.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали новые права доступа!");
            }
            else
            {

                try
                {
                    if (ValueID != -2)
                    {
                        if (ComboBoxPermissionFor.SelectedIndex == 0)
                        {
                            if (ComboBoxPermissions.SelectedIndex == 0)
                            {
                                model.ChangePermissionToUserByUserID(ValueID, "Default");
                            }
                            else if (ComboBoxPermissions.SelectedIndex == 1)
                            {
                                model.ChangePermissionToUserByUserID(ValueID, "NoAccess");
                            }
                        }
                        else if (ComboBoxPermissionFor.SelectedIndex == 1)
                        {
                            if (ComboBoxPermissions.SelectedIndex == 0)
                            {
                                model.ChangePermissionToRoleByRoleID(ValueID, "Default");
                            }
                            else if (ComboBoxPermissions.SelectedIndex == 1)
                            {
                                model.ChangePermissionToRoleByRoleID(ValueID, "NoAccess");
                            }
                        }
                    }
                    MessageBox.Show("Права доступа сохраненны!");
                }
                catch (Exception)
                {

                    MessageBox.Show("Права доступа не удалось сохраненить!");
                }
            }
            
            
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            AddEventBtn.Enabled = true;
            string userPermission = "";
            string rolePermission = "";

            try
            {
                int SelectedRow = DataGridViewUserRole.CurrentCell.RowIndex;
                var row = DataGridViewUserRole.Rows[SelectedRow];
                ValueID = (int)row.Cells[0].Value;
            }
            catch (Exception)
            {

                MessageBox.Show("Произошла ошибка при удалении сервиса");
            }
            if (ValueID != -2)
            {
                if (ComboBoxPermissionFor.SelectedIndex == 0)
                {
                    userPermission = view.GetUserPermissionById(ValueID);
                    if (userPermission == "Default")
                    {
                        PermissionNowTxtBox.Text = "Стандартные права";
                    }
                    else if (userPermission == "NoAccess")
                    {
                        PermissionNowTxtBox.Text = "Аккаунт заблокирован";
                    }


                }
                else if (ComboBoxPermissionFor.SelectedIndex == 1)
                {
                    rolePermission = view.GetRolePermissionById(ValueID);
                    if (rolePermission == "Default")
                    {
                        PermissionNowTxtBox.Text = "Роль активна";
                    }
                    else if (rolePermission == "NoAccess")
                    {
                        PermissionNowTxtBox.Text = "Роль заблокирована";
                    }
                }

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Номер права доступа 1 - обычные права" + "\n" + "Номер права доступа 3 - права без доступа в систему");
        }
    }
}

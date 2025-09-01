using DiplomProgramm.Core;
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
    public partial class AdministratorServices : DiplomProgramm.UI.Templates.AdministratorMainTemplate
    {
        public AdministratorServices()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddNewService addNewService = new AddNewService();
            addNewService.Show();
            this.Hide();
        }

        private void AdministratorServices_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtn("ServiceAdminBtn");
            UpdateDatagrid();
            ChooseDatasourceComboBox.Items.Add("Услуги компании");
            ChooseDatasourceComboBox.Items.Add("Персональные услуги");
            ChooseDatasourceComboBox.Items.Add("Все");
            ChooseDatasourceComboBox.SelectedIndex = 0;
        }

        private void AdministratorServices_Activated(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        public void UpdateDatagrid()
        {
            if (ChooseDatasourceComboBox.SelectedIndex == 0)
            {
                ServicesGridView.DataSource = view.ShowAvailableServices();
            }
            else if (ChooseDatasourceComboBox.SelectedIndex == 1)
            {
                ServicesGridView.DataSource = view.ShowAvailablePersonalServices();
            }
            else if (ChooseDatasourceComboBox.SelectedIndex == 2)
            {
                ServicesGridView.DataSource = view.ShowAvailableALLServices();
            }
            if (ServicesGridView.DataSource != null)
            {
                ServicesGridView.Columns[0].HeaderText = "Номер услуги";
                ServicesGridView.Columns[1].HeaderText = "Наименование";
                ServicesGridView.Columns[2].Visible = false;
                ServicesGridView.Columns[3].HeaderText = "Цена";
                ServicesGridView.Columns[4].HeaderText = "Доступность";
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int ServiceID = -2;
            try
            {
                int SelectedRow = ServicesGridView.CurrentCell.RowIndex;
                var row = ServicesGridView.Rows[SelectedRow];
                ServiceID = (int)row.Cells[0].Value;
            }
            catch (Exception)
            {

                MessageBox.Show("Произошла ошибка при удалении сервиса");
            }
            if (ServiceID != -2)
            {
                if (model.HideServiceByServiceID(ServiceID) == true)
                {
                    UpdateDatagrid();
                }
            }


        }

        private void ServicesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChooseDatasourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        private void ViewServiceBtn_Click(object sender, EventArgs e)
        {
            int ServiceID = -2;
            try
            {
                int SelectedRow = ServicesGridView.CurrentCell.RowIndex;
                var row = ServicesGridView.Rows[SelectedRow];
                ServiceID = (int)row.Cells[0].Value;
            }
            catch (Exception)
            {

                MessageBox.Show("Произошла ошибка при удалении сервиса");
            }
            if (ServiceID != -2)
            {
                AdministratorSeeAnalyzesOfCurrentService ASAOCS = new AdministratorSeeAnalyzesOfCurrentService(ServiceID);
                ASAOCS.Show();

            }
        }
    }
}

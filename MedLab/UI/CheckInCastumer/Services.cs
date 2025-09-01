using DiplomProgramm.UI.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiplomProgramm.UI.CheckInCastumer
{
    public partial class Services : DiplomProgramm.Form1
    {
        public Services()
        {
            
            Program.CurrentOpenPage = "Services";
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtn("ServicesBtn");
            ServicesGridView.DataSource = view.ShowAvailableServices();
            UpdateDatagrid();
        }
        
        public void UpdateDatagrid()
        {
            ServicesGridView.Columns[0].HeaderText = "Номер услуги";
            ServicesGridView.Columns[1].HeaderText = "Наименование";
            ServicesGridView.Columns[2].Visible = false;
            ServicesGridView.Columns[3].HeaderText = "Цена";
            ServicesGridView.Columns[4].HeaderText = "Доступность";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<ServicesTable> service = view.SearchServices(SearchTxtBox.Text);
            List<ServicesTable> Nulll = view.ShowAvailableServices();
            if (!(service.Count == 0))
            {
                ServicesGridView.DataSource = service;
                UpdateDatagrid();
            }
            else
            {
                ServicesGridView.DataSource = Nulll;
                UpdateDatagrid();
                MessageBox.Show("Услуг с таким наименованием не найдено!");
            }
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

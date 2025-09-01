using DiplomProgramm.UI.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiplomProgramm.UI.CheckInCastumer.ClientsPersonalAcc
{
    public partial class Receptions : DiplomProgramm.UI.Templates.ClientsPersonalAccTemplate
    {
        public Receptions()
        {
            Program.SecondaryCurrentOpenPage = "Receptions";
            InitializeComponent();
        }

        private void Receptions_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtnMenu("ReceptionsBtn");
            UpdatePersonalAccDataClient();
            UpdateDataGridView();
            guna2Button1.Enabled = false;


        }

        private void AddNewOrderBtn_Click(object sender, EventArgs e)
        {
            AddReceprionDialog addReceprionDialog = new AddReceprionDialog();
            addReceprionDialog.Show();
        }

        private void DataGridViewReceprionShowAllClientsReceptionsTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRow = DataGridViewReceprionShowAllClientsReceptionsTT.CurrentCell.RowIndex;
            var DateSelIndex = DataGridViewReceprionShowAllClientsReceptionsTT.Rows[SelectedRow];
            string OrderId = (string)DateSelIndex.Cells[5].Value;
            if (OrderId == "Результаты готовы")
            {
                guna2Button1.Enabled = true;
            }
        }

        public void UpdateDataGridView()
        {
            DataGridViewReceprionShowAllClientsReceptionsTT.DataSource = view.ShowAllTimeTableForCurrentClient();
            DataGridViewReceprionShowAllClientsReceptionsTT.Columns[0].HeaderText = "Дата взятия образца";
            DataGridViewReceprionShowAllClientsReceptionsTT.Columns[1].HeaderText = "Номер записи";
            DataGridViewReceprionShowAllClientsReceptionsTT.Columns[2].HeaderText = "Наименование услуги";
            DataGridViewReceprionShowAllClientsReceptionsTT.Columns[3].HeaderText = "ФИО клиента";
            DataGridViewReceprionShowAllClientsReceptionsTT.Columns[4].HeaderText = "Дата создания";
            DataGridViewReceprionShowAllClientsReceptionsTT.Columns[5].HeaderText = "Результаты";

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int SelectedRow = DataGridViewReceprionShowAllClientsReceptionsTT.CurrentCell.RowIndex;
            var DateSelIndex = DataGridViewReceprionShowAllClientsReceptionsTT.Rows[SelectedRow];
            int OrderId = (int)DateSelIndex.Cells[1].Value;
            string FilePath = view.GetResultFilePathByOrderID(OrderId);
            Process.Start($@"{FilePath}");
        }

        private void DataGridViewReceprionShowAllClientsReceptionsTT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRow = DataGridViewReceprionShowAllClientsReceptionsTT.CurrentCell.RowIndex;
            var DateSelIndex = DataGridViewReceprionShowAllClientsReceptionsTT.Rows[SelectedRow];
            string Result = (string)DateSelIndex.Cells[5].Value;
            if (Result == "Результатов нет")
            {
                guna2Button1.Enabled = false;
            }
            else
            {
                guna2Button1.Enabled = true;
            }
        }
    }
}

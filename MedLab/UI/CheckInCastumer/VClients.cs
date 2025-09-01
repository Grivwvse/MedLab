using DiplomProgramm.UI.CheckInCastumer.ClientsPersonalAcc;
using DiplomProgramm.UI.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DiplomProgramm.Core;
using DiplomProgramm.UI.Dialogs;

namespace DiplomProgramm.UI.CheckInCastumer
{
    public partial class VClients : DiplomProgramm.Form1
    {
        public VClients()
        {
            Program.CurrentOpenPage = "VClients";
            InitializeComponent();
        }

        private void VClients_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtn("VClientsBtn");
            guna2DataGridView1.DataSource = view.ReturnAllClients();
            DataGridUI();
        }

        private void DataGridUI()
        {
            guna2DataGridView1.Columns.Remove("ContractID");


            guna2DataGridView1.Columns[0].HeaderText = "Номер";
            guna2DataGridView1.Columns[1].HeaderText = "Имя";
            guna2DataGridView1.Columns[2].HeaderText = "Фамилия";
            guna2DataGridView1.Columns[3].HeaderText = "Отчество";
            guna2DataGridView1.Columns[4].HeaderText = "Дата рождения";
            guna2DataGridView1.Columns[5].HeaderText = "Телефон";
            guna2DataGridView1.Columns[6].HeaderText = "Почта";
            guna2DataGridView1.Columns[7].HeaderText = "Номер паспорта";
        }

        public void UpdateDGV()
        {
            guna2DataGridView1.DataSource = view.ReturnAllClients();
            DataGridUI();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int SelectedRow = guna2DataGridView1.CurrentCell.RowIndex;
            var ChoosenClient = guna2DataGridView1.Rows[SelectedRow];
            Program.CurrentClietnPersonalAcc = (int)ChoosenClient.Cells[0].Value;
            Program.Instanses.OpenSecondaryForm("Events");
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = view.ReturnAllSearchClients(SearchTxtBox.Text);
            DataGridUI();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddNewOrderBtn_Click(object sender, EventArgs e)
        {
            RegisterNewClientDialog registerNewClient = new RegisterNewClientDialog();
            registerNewClient.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            int SelectedRow = guna2DataGridView1.CurrentCell.RowIndex;
            var ChoosenClient = guna2DataGridView1.Rows[SelectedRow];
            Program.CurrentClietnPersonalAcc = (int)ChoosenClient.Cells[0].Value;
            Program.Instanses.OpenSecondaryForm("Events");
        }
    }
}

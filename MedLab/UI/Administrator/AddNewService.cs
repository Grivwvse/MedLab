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
    public partial class AddNewService : DiplomProgramm.UI.Templates.AdministratorMainTemplate
    {
        public AddNewService()
        {
            InitializeComponent();
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region Instances
        public List<AnalyzesTable> analyzesTable = new List<AnalyzesTable>();
        public List<AnalyzesTable> analyzes = new List<AnalyzesTable>();
        public List<AnalyzesTable> DatagridSource = new List<AnalyzesTable>();
        public List<AnalyzesTable> RefreshDGV = new List<AnalyzesTable>();
        public ServicesTable service = new ServicesTable();
        #endregion

        public void SetVisualDataGridHeader()
        {
            AllAnalizesDatagrid.Columns[0].HeaderText = "Номер анализа";
            AllAnalizesDatagrid.Columns[1].HeaderText = "Наименование";
            AllAnalizesDatagrid.Columns[2].HeaderText = "Нормальное значение";
            AllAnalizesDatagrid.Columns[3].HeaderText = "цена";

            // NewPersonalServiceDataGridViewAnalyzes.Columns[0].Width = 40;
            if (AddedAnalyzesDataGrid.DataSource != null)
            {
                //NewPersonalServiceDataGridViewAddedServices.Columns[0].Width = 40;

                AddedAnalyzesDataGrid.Columns[0].HeaderText = "Номер анализа";
                AddedAnalyzesDataGrid.Columns[1].HeaderText = "Наименование";
                AddedAnalyzesDataGrid.Columns[2].HeaderText = "Нормальное значение";
                AddedAnalyzesDataGrid.Columns[3].HeaderText = "цена";
            }


        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            int SelectedRow = AllAnalizesDatagrid.CurrentCell.RowIndex;
            var row = AllAnalizesDatagrid.Rows[SelectedRow];
            int AnalyzeID = (int)row.Cells[0].Value;

            AnalyzesTable analyzesTable = view.GetAnalyzeByID(AnalyzeID);
            if (analyzesTable != null)
            {
                analyzes.Add(analyzesTable);
                AddedAnalyzesDataGrid.DataSource = RefreshDGV;
                AddedAnalyzesDataGrid.DataSource = analyzes;
                DatagridSource.RemoveAt(SelectedRow);
                AllAnalizesDatagrid.DataSource = RefreshDGV;
                AllAnalizesDatagrid.DataSource = DatagridSource;
                SetVisualDataGridHeader();
            }
        }

        private void AddNewService_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtn("ServiceAdminBtn");
            UpdateDatagrid();
            SetVisualDataGridHeader();
        }

        public void UpdateDatagrid()
        {
            DatagridSource = view.GetAllAnalyzes();
            AllAnalizesDatagrid.DataSource = DatagridSource;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            int SelectedRow = AddedAnalyzesDataGrid.CurrentCell.RowIndex;
            var row = AddedAnalyzesDataGrid.Rows[SelectedRow];
            int AnalyzeID = (int)row.Cells[0].Value;

            AnalyzesTable analyzesTable = view.GetAnalyzeByID(AnalyzeID);
            if (analyzesTable != null)
            {
                DatagridSource.Add(analyzesTable);
                AllAnalizesDatagrid.DataSource = RefreshDGV;
                AllAnalizesDatagrid.DataSource = DatagridSource;
                analyzes.RemoveAt(SelectedRow);
                AddedAnalyzesDataGrid.DataSource = RefreshDGV;
                AddedAnalyzesDataGrid.DataSource = analyzes;
                SetVisualDataGridHeader();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddNewAnalyze addNewService = new AddNewAnalyze();
            DialogResult dResult = addNewService.ShowDialog();
            if (dResult == System.Windows.Forms.DialogResult.OK)
            {
                UpdateDatagrid();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (TxtBoxNameService.Text != "" & TxtBoxCostService.Text != "" & analyzes.Count != 0)
            {
                int uselessvar = 0;
                try
                {
                    Convert.ToInt32(TxtBoxCostService.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Вы ввели не правильное значение при написании цены услуги!");
                    uselessvar = 1;
                }
                if (uselessvar == 0)
                {
                    service.Aviability = true;
                    service.Name = TxtBoxNameService.Text;
                    service.Cost = Convert.ToInt32(TxtBoxCostService.Text);
                    service.Description = "";
                    Program.CurrentPersonalServiceId = model.CreateNewService(analyzes, service);
                    MessageBox.Show("Услуга успешно созданна!");
                    AdministratorServices administratorServices = new AdministratorServices();
                    administratorServices.Activate();
                    administratorServices.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Вы не ввели всю необходимую информацию!");
            }


        }

        private void CauntSaleChckBox_CheckedChanged(object sender, EventArgs e)
        {
            int MainCost = 0;
            for (int i = 0; i < analyzes.Count; i++)
            {
                MainCost = MainCost + analyzes[i].Cost;
            }
            TxtBoxCostService.Text = Convert.ToString(MainCost);
        }
    }
}

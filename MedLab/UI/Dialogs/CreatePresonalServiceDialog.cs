using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiplomProgramm.Core;
using View = DiplomProgramm.Core.View;

namespace DiplomProgramm.UI.Dialogs
{
    public partial class CreatePresonalServiceDialog : Form
    {
        public CreatePresonalServiceDialog()
        {
            InitializeComponent();
        }
        #region Instances
        View view = new View();
        Model model = new Model();
        #endregion
        #region Fields
        List<AnalyzesTable> analyzes = new List<AnalyzesTable>();
        ServicesTable service = new ServicesTable();
        List<AnalyzesTable> DatagridSource = new List<AnalyzesTable>();
        public List<AnalyzesTable> RefreshDGV = new List<AnalyzesTable>();
        #endregion
        private void CreatePresonalServiceDialog_Load(object sender, EventArgs e)
        {   DatagridSource = view.GetAllAnalyzes();
            NewPersonalServiceDataGridViewAnalyzes.DataSource = DatagridSource;
            SetVisualDataGridHeader();
        }

        public void SetVisualDataGridHeader()
        {
            NewPersonalServiceDataGridViewAnalyzes.Columns[0].HeaderText = "Номер анализа";
            NewPersonalServiceDataGridViewAnalyzes.Columns[1].HeaderText = "Наименование";
            NewPersonalServiceDataGridViewAnalyzes.Columns[2].HeaderText = "Нормальное значение";
            NewPersonalServiceDataGridViewAnalyzes.Columns[3].HeaderText = "цена";

           // NewPersonalServiceDataGridViewAnalyzes.Columns[0].Width = 40;
            if (NewPersonalServiceDataGridViewAddedServices.DataSource != null)
            {
                //NewPersonalServiceDataGridViewAddedServices.Columns[0].Width = 40;

                NewPersonalServiceDataGridViewAddedServices.Columns[0].HeaderText = "Номер анализа";
                NewPersonalServiceDataGridViewAddedServices.Columns[1].HeaderText = "Наименование";
                NewPersonalServiceDataGridViewAddedServices.Columns[2].HeaderText = "Нормальное значение";
                NewPersonalServiceDataGridViewAddedServices.Columns[3].HeaderText = "цена";
            }

            
        }

        private void SaveNewPersonalService_Click(object sender, EventArgs e)
        {
            if (analyzes.Count != 0)
            {
                int MainCost = 0;
                for (int i = 0; i < analyzes.Count; i++)
                {
                    MainCost = MainCost + analyzes[i].Cost;
                }
                service.Aviability = true;
                service.Name = "Персональная услуга";
                service.Cost = MainCost;
                service.Description = "";
                Program.CurrentPersonalServiceId = model.CreateNewService(analyzes, service);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни одного анализа!");
            }

        }

        private void AddAnalyzeToserviceButton1_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void NewPersonalServiceDataGridViewAddedServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ВудуеуAnalyzeToserviceButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            int SelectedRow = NewPersonalServiceDataGridViewAnalyzes.CurrentCell.RowIndex;
            var row = NewPersonalServiceDataGridViewAnalyzes.Rows[SelectedRow];
            int AnalyzeID = (int)row.Cells[0].Value;

            AnalyzesTable analyzesTable = view.GetAnalyzeByID(AnalyzeID);
            if (analyzesTable != null)
            {
                analyzes.Add(analyzesTable);
                NewPersonalServiceDataGridViewAddedServices.DataSource = RefreshDGV;
                NewPersonalServiceDataGridViewAddedServices.DataSource = analyzes;
                DatagridSource.RemoveAt(SelectedRow);
                NewPersonalServiceDataGridViewAnalyzes.DataSource = RefreshDGV;
                NewPersonalServiceDataGridViewAnalyzes.DataSource = DatagridSource;
                SetVisualDataGridHeader();
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            int SelectedRow = NewPersonalServiceDataGridViewAddedServices.CurrentCell.RowIndex;
            var row = NewPersonalServiceDataGridViewAddedServices.Rows[SelectedRow];
            int AnalyzeID = (int)row.Cells[0].Value;

            AnalyzesTable analyzesTable = view.GetAnalyzeByID(AnalyzeID);
            if (analyzesTable != null)
            {
                DatagridSource.Add(analyzesTable);
                NewPersonalServiceDataGridViewAnalyzes.DataSource = RefreshDGV;
                NewPersonalServiceDataGridViewAnalyzes.DataSource = DatagridSource;
                analyzes.RemoveAt(SelectedRow);
                NewPersonalServiceDataGridViewAddedServices.DataSource = RefreshDGV;
                NewPersonalServiceDataGridViewAddedServices.DataSource = analyzes;
                SetVisualDataGridHeader();
            }
        }

        private void NewPersonalServiceDataGridViewAnalyzes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

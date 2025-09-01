using DiplomProgramm.ClassesDV;
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
    public partial class InputResultsToDBDialog : Form
    {
        public InputResultsToDBDialog(List<LAAnalayzesResults> analayzesResultS, int OrderID)
        {
            analayzesResults = analayzesResultS;
            this.OrderID = OrderID;
            InitializeComponent();
        }

        public List<LAAnalayzesResults> analayzesResults { get; set; }
        public int OrderID = 0;
        View view = new View();
        Model model = new Model();
        ClientsTable client = new ClientsTable();
        OrdersTable order = new OrdersTable();
        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputResultsToDBDialog_Load(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        private void UpdateDatagrid()
        {
            LaborantInputAnalyzesListDataGridView.DataSource = null;
            LaborantInputAnalyzesListDataGridView.DataSource = analayzesResults;
            LaborantInputAnalyzesListDataGridView.Columns[0].HeaderText = "Код";
            LaborantInputAnalyzesListDataGridView.Columns[1].HeaderText = "Анализ";
            LaborantInputAnalyzesListDataGridView.Columns[2].HeaderText = "Результат";
            LaborantInputAnalyzesListDataGridView.Columns[3].HeaderText = "Норма,Ед изм.";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int ResultID = view.GetLastResultID(OrderID) + 1;

            for (int i = 0; i < LaborantInputAnalyzesListDataGridView.RowCount; i++)
            {
                string Result = LaborantInputAnalyzesListDataGridView.Rows[i].Cells[2].Value.ToString();
                int AnalyzeID = Convert.ToInt32(LaborantInputAnalyzesListDataGridView.Rows[i].Cells[0].Value.ToString());
                model.SaveResults(ResultID, Result, AnalyzeID, OrderID);
            }
            if (LaborantInputAnalyzesListDataGridView.Rows != null)
            {
                client = view.GetClientInfoFromOrderID(Program.CurrentScanOrderID);
                order = view.GetOrderByID(Program.CurrentScanOrderID);
                var items = new Dictionary<string, string>
            {
                {"<DateComeIn>", order.DateComeIn.ToShortDateString()},
                {"<ClientFIO>", $"{client.Surname} {client.Name} {client.Patronymic}"},
                {"<DateGetResult>", DateTime.Now.ToShortDateString()},
                {"<DateOfDirth>",client.DateOfBirth.ToShortDateString() },
               
            };

                WordHelper WH = new WordHelper("DocumentsTemplates/Results.docx");

                
                analayzesResults.Insert(0,(new LAAnalayzesResults(1, "1", "1", "1")));
                UpdateDatagrid();
                string NewFileName = WH.ExportResultsToWord(LaborantInputAnalyzesListDataGridView, @"D:\Шарага\проекты вижлы\DiplomProgramm\DocumentsTemplates\Results.docx", items);
                string[] words = NewFileName.Split('.');

                if (order.SendEmail == true)
                {
                    MailClass mailClass = new MailClass($@"{words[0]}.PDF", $"{client.Email}");
                    mailClass.SendMessage();
                }
                model.SavseResultsFileNameToDB(ResultID, ($"{words[0]}.PDF"));
            }
            MessageBox.Show("Результаты успешно загруженны!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void LaborantInputAnalyzesListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

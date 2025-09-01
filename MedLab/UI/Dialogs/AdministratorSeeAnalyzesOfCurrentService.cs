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
    public partial class AdministratorSeeAnalyzesOfCurrentService : Form
    {
        public AdministratorSeeAnalyzesOfCurrentService(int ServiceID)
        {
            this.SericeId = ServiceID;
            InitializeComponent();
        }
        View view = new View();
        public int SericeId = new int();
        private void AdministratorSeeAnalyzesOfCurrentService_Load(object sender, EventArgs e)
        {

            DataGridViewAnalyzerAdmin.DataSource = view.GetAllAnalyzesFromCurrentServices(SericeId);
            DataGridViewAnalyzerAdmin.Columns[0].HeaderText = "Номер анализа";
            DataGridViewAnalyzerAdmin.Columns[1].HeaderText = "Наименование";
            DataGridViewAnalyzerAdmin.Columns[2].HeaderText = "Нормальное значение";
            DataGridViewAnalyzerAdmin.Columns[3].HeaderText = "цена";
            label1.Text = $"Просмотр услуги № {SericeId}";
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

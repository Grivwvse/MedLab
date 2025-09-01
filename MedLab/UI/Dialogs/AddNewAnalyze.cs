using DiplomProgramm.Core;
using DiplomProgramm.UI.Administrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProgramm.UI.Dialogs
{
    public partial class AddNewAnalyze : Form
    {
        Model model = new Model();
        public AddNewAnalyze()
        {
            InitializeComponent();
        }

        private void SaveReceptionBtn_Click(object sender, EventArgs e)
        {
            if (TxtBoxName.Text != "" & TxtBoxNormValue.Text != "" & TxtBoxCost.Text != "")
            {
                int uselessvar = 0;
                try
                {
                    Convert.ToInt32(TxtBoxCost.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Вы ввели не правильное значение при написании цены услуги!");
                    uselessvar = 1;
                }
                if (uselessvar == 0)
                {
                    model.CreateNewAnalyze(TxtBoxName.Text, TxtBoxNormValue.Text, Convert.ToInt32(TxtBoxCost.Text));
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Анализ успешно сохранен");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Вы не ввели все необходимые данные!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
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
    }
}

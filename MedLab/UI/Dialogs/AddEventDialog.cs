using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiplomProgramm.UI.Administrator;
using DiplomProgramm.Core;
using View = DiplomProgramm.Core.View;

namespace DiplomProgramm.UI.Dialogs
{
    public partial class AddEventDialog : Form
    {
        public AddEventDialog()
        {
            InitializeComponent();
        }

        #region Instances
        View view = new View();
        #endregion

        private void AddEventDialog_Load(object sender, EventArgs e)
        {
            ComboBoxImportance.Items.Add("Обычный");
            ComboBoxImportance.Items.Add("Средний");
            ComboBoxImportance.Items.Add("Высокий");

            ComboBoxVisibleFor.Items.Add("Для Всех");
            ComboBoxVisibleFor.Items.Add("Для Регистратуры");
            ComboBoxVisibleFor.Items.Add("Для Лаборатории");
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddEventBtn_ClickAsync(object sender, EventArgs e)
        {
            if (ComboBoxImportance.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали важность события!");
            }
            else if (ComboBoxVisibleFor.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали кто может просматривать событие!");
            }
            else if (TxtBoxEventName.Text == "")
            {
                MessageBox.Show("Вы не ввелитест события!");
            }
            else
            {
                view.AddGlobalEvent(ComboBoxVisibleFor.SelectedIndex, ComboBoxImportance.SelectedIndex, DataPickerLastDateVisibleFor.Value, TxtBoxEventName.Text);
                ProgressBarSavingEvent.Maximum = 26;
                timer1.Enabled = true;
                Program.Instanses.UpdateAdministratorEventDatagridViw();
            }
        }

        private void ProgressBarSavingEvent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBarSavingEvent.Value > 25)
            {
                timer1.Enabled = false;
                MessageBox.Show("Событие успешно добавленно!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ProgressBarSavingEvent.Value += 1;
            }
            
        }

        private void DataPickerLastDateVisibleFor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxImportance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxVisibleFor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

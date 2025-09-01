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

namespace DiplomProgramm.UI.Administrator
{
    public partial class AdministratorM : Form
    {
        public AdministratorM()
        {
            InitializeComponent();
        }
        #region Instances
        View view = new View();
        #endregion

        private void Administrator_Load(object sender, EventArgs e)
        {
            FillListBoxEvents();
            EventsBtn.BackColor = Color.Gray;
        }

        public void FillListBoxEvents()
        {
            List<GlobalEventsTable> globalEvents = view.ShowActiveEvents();
            EventsDataGridView.DataSource = view.ShowActiveEvents();
            for (int i = 0; i < globalEvents.Count; i++)
            {
                if (globalEvents[i].Importance == 1 )
                {
                    EventsDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(242,136,75);
                    EventsDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(242,136,75);
                }
                else if (globalEvents[i].Importance == 2)
                {
                    EventsDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(242, 92, 75);
                    EventsDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 92, 75);
                }
            }

            EventsDataGridView.Columns.Add("Own","Фамилия");
            for (int i = 0; i < EventsDataGridView.RowCount; i++)
            {
                var ui = EventsDataGridView.Rows[i];
                int UserId = (int)ui.Cells["UserID"].Value;

                EventsDataGridView["Own", i].Value = view.GetCurrentCellValueFIOAdministratorForm(UserId);
            }
            EventsDataGridView.Columns.Remove("UserID");
            EventsDataGridView.Columns.Remove("Importance");

            DataGridViewColumn column = EventsDataGridView.Columns["Name"];
            column.Width = 400;
            EventsDataGridView.Columns[0].HeaderText = "Номер События";
            EventsDataGridView.Columns[1].HeaderText = "Описание События";
            EventsDataGridView.Columns[2].HeaderText = "Дата Создания";
            EventsDataGridView.Columns[3].HeaderText = "Дата Завершения";
            EventsDataGridView.Columns[4].HeaderText = "Для кого";
            EventsDataGridView.Columns[5].HeaderText = "Фамилия";
        }



        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizedBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EventsBtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdministratorServices administratorServices = new AdministratorServices();
            administratorServices.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            view.ShowAddEventDialog();
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int EventID = 0;
            int SelectedRow = EventsDataGridView.CurrentCell.RowIndex;
            var client = EventsDataGridView.Rows[SelectedRow];
            try
            {
                EventID = (int)client.Cells[0].Value;

            }
            catch (Exception)
            {

                MessageBox.Show("Можно удалять только одно событие за сеанс, если хотите удалить еще одно, перезайдите!");
            }
            MessageBox.Show("Событие успешно удалено!");
            view.DelGlobalEvent(EventID);
            
            FillListBoxEvents();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AdministratorChkckUsers ACU = new AdministratorChkckUsers();
            ACU.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AdministratorPermissions administratorPermissions = new AdministratorPermissions();
            administratorPermissions.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AFeedback aFeedback = new AFeedback();
            aFeedback.Show();
            this.Close();
        }
    }
}

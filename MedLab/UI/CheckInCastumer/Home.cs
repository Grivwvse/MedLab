using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiplomProgramm.UI.CheckInCastumer
{
    public partial class Home : DiplomProgramm.Form1
    {

        public Home()
        {
            
            Program.CurrentOpenPage = "Home";
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtn("HomeBtn");
            WelcomeLable.Text = WelcomeLable.Text + view.GetCurrentUserName() + "!";
            FillListBoxEvents();
        }

        public void FillListBoxEvents()
        {
            List<GlobalEventsTable> globalEvents = view.ShowActiveEventsCheckInCastumer();
            ReceptionDataGridViewEvents.DataSource = view.ShowActiveEventsCheckInCastumer();
            if (ReceptionDataGridViewEvents.RowCount > 0)
            {
                for (int i = 0; i < globalEvents.Count; i++)
                {
                    if (globalEvents[i].Importance == 1)
                    {
                        ReceptionDataGridViewEvents.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(242, 136, 75);
                        ReceptionDataGridViewEvents.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 136, 75);
                    }
                    else if (globalEvents[i].Importance == 2)
                    {
                        ReceptionDataGridViewEvents.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(242, 92, 75);
                        ReceptionDataGridViewEvents.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 92, 75);
                    }
                }
            }
            ReceptionDataGridViewEvents.Columns.Add("Own", "Фамилия");
            for (int i = 0; i < ReceptionDataGridViewEvents.RowCount; i++)
            {
                var ui = ReceptionDataGridViewEvents.Rows[i];
                int UserId = (int)ui.Cells["UserID"].Value;

                ReceptionDataGridViewEvents["Own", i].Value = view.GetCurrentCellValueFIOAdministratorForm(UserId);
            }
            ReceptionDataGridViewEvents.Columns.Remove("UserID");
            ReceptionDataGridViewEvents.Columns.Remove("Importance");

            DataGridViewColumn column = ReceptionDataGridViewEvents.Columns["Name"];
            column.Width = 400;
            ReceptionDataGridViewEvents.Columns[0].HeaderText = "Номер События";
            ReceptionDataGridViewEvents.Columns[1].HeaderText = "Описание События";
            ReceptionDataGridViewEvents.Columns[2].HeaderText = "Дата Создания";
            ReceptionDataGridViewEvents.Columns[3].HeaderText = "Дата Завершения";
            ReceptionDataGridViewEvents.Columns[4].HeaderText = "Для кого";
            ReceptionDataGridViewEvents.Columns[5].HeaderText = "Фамилия";
        }


        public void OpenNewForm(string ShowFormStr)
        {
            if (ShowFormStr == "VClients")
            {
                Home f2 = (Home)Application.OpenForms["Home"];
                VClients f3 = new VClients();
                //Form1 form1 = new Form1();
                
                f2.Close();
                f3.Show();
                f3.Location = f2.Location;
                f3.Size = f2.Size;

            }


        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WelcomeLable_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

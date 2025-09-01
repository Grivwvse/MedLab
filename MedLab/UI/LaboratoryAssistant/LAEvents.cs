using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiplomProgramm.UI.LaboratoryAssistant
{
    public partial class LAEvents : DiplomProgramm.UI.Templates.LaboratoryAssistantMainTemplate
    {
        public LAEvents()
        {
            InitializeComponent();
        }

        private void LAEvents_Load(object sender, EventArgs e)
        {
            WelcomeLable.Text = WelcomeLable.Text + view.GetCurrentUserName() + "!";
            FillListBoxEvents();
            ChangeBackgroundColourBtn("HomeBtn");
        }

        public void FillListBoxEvents()
        {
            List<GlobalEventsTable> globalEvents = view.ShowActiveEventsLaboratoryAssistant();
            LaboratoryDataGridViewEvents.DataSource = view.ShowActiveEventsLaboratoryAssistant();
            if (LaboratoryDataGridViewEvents.RowCount > 0)
            {
                for (int i = 0; i < globalEvents.Count; i++)
                {
                    if (globalEvents[i].Importance == 1)
                    {
                        LaboratoryDataGridViewEvents.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(242, 136, 75);
                        LaboratoryDataGridViewEvents.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 136, 75);
                    }
                    else if (globalEvents[i].Importance == 2)
                    {
                        LaboratoryDataGridViewEvents.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(242, 92, 75);
                        LaboratoryDataGridViewEvents.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 92, 75);
                    }
                }
            }
            LaboratoryDataGridViewEvents.Columns.Add("Own", "Фамилия");
            for (int i = 0; i < LaboratoryDataGridViewEvents.RowCount; i++)
            {
                var ui = LaboratoryDataGridViewEvents.Rows[i];
                int UserId = (int)ui.Cells["UserID"].Value;

                LaboratoryDataGridViewEvents["Own", i].Value = view.GetCurrentCellValueFIOAdministratorForm(UserId);
            }
            LaboratoryDataGridViewEvents.Columns.Remove("UserID");
            LaboratoryDataGridViewEvents.Columns.Remove("Importance");

            DataGridViewColumn column = LaboratoryDataGridViewEvents.Columns["Name"];
            column.Width = 400;
            LaboratoryDataGridViewEvents.Columns[0].HeaderText = "Номер События";
            LaboratoryDataGridViewEvents.Columns[1].HeaderText = "Описание События";
            LaboratoryDataGridViewEvents.Columns[2].HeaderText = "Дата Создания";
            LaboratoryDataGridViewEvents.Columns[3].HeaderText = "Дата Завершения";
            LaboratoryDataGridViewEvents.Columns[4].HeaderText = "Для кого";
            LaboratoryDataGridViewEvents.Columns[5].HeaderText = "Фамилия";
        }
    }
}

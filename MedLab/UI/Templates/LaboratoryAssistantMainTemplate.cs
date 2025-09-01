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
using DiplomProgramm.UI.CheckInCastumer;
using DiplomProgramm.UI.LaboratoryAssistant;
using View = DiplomProgramm.Core.View;

namespace DiplomProgramm.UI.Templates
{
    public partial class LaboratoryAssistantMainTemplate : Form
    {
        public LaboratoryAssistantMainTemplate()
        {
            InitializeComponent();
        }
        #region Instances
        public View view = new View();
        public Model model = new Model();
        #endregion

        private void LaboratoryAssistantMainTemplate_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtn("HomeBtn");
        }

        public void ChangeBackgroundColourBtn(string value)
        {
            if (value == "HomeBtn")
            {
                HomeBtn.BackColor = Color.Gray;
                //ClientBtn.BackColor = Color.Transparent;
                //ServicesBtn.BackColor = Color.Transparent;
            }
            else if (value == "ScanBtn")
            {
                HomeBtn.BackColor = Color.Transparent;
                //ServicesBtn.BackColor = Color.Transparent;
                ScanBtn.BackColor = Color.Gray;
            }
            else if (value == "ServicesBtn")
            {
                HomeBtn.BackColor = Color.Transparent;
                //ClientBtn.BackColor = Color.Transparent;
                //ServicesBtn.BackColor = Color.Gray;
            }
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

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            LASearchClients lASearchClients = new LASearchClients();
            lASearchClients.Show();
            this.Hide();

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            LAEvents lAEvents = new LAEvents();
            lAEvents.Show();
            this.Hide();
        }

        private void Label_NameProgramm_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

using DiplomProgramm.UI.CheckInCastumer;
using DiplomProgramm.UI.UISettings;
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

namespace DiplomProgramm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Instances
        public UISettings UIS = new UISettings();
        public View view = new View();
        public Model model = new Model();
        #endregion


        public void ChangeBackgroundColourBtn(string value)
        {
            if (value == "HomeBtn")
            {
                HomeBtn.BackColor = Color.Gray;
                ClientBtn.BackColor = Color.Transparent;
                //ServicesBtn.BackColor = Color.Transparent;
            }
            else if (value == "VClientsBtn")
            {
                HomeBtn.BackColor = Color.Transparent;
                //ServicesBtn.BackColor = Color.Transparent;
                ClientBtn.BackColor = Color.Gray;
            }
            else if (value == "ServicesBtn")
            {
                HomeBtn.BackColor = Color.Transparent;
                ClientBtn.BackColor = Color.Transparent;
                //ServicesBtn.BackColor = Color.Gray;
            }
        }




        private void CloseAppBtn_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            Program.Instanses.UpdateInstanceHome("VClients");
            ChangeBackgroundColourBtn("VClientsBtn");
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        { 
            Program.Instanses.UpdateInstanceHome("Home");
            ChangeBackgroundColourBtn("HomeBtn");

        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            Program.Instanses.UpdateInstanceHome("Services");
            ChangeBackgroundColourBtn("ServicesBtn");
        }

        private void PannelMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_NameProgramm_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Program.Instanses.UpdateInstanceHome("Services");
            ChangeBackgroundColourBtn("ServicesBtn");
        }
    }
}

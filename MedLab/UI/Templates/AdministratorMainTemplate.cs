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
using DiplomProgramm.UI.Administrator;
using View = DiplomProgramm.Core.View;

namespace DiplomProgramm.UI.Templates
{
    public partial class AdministratorMainTemplate : Form
    {
        public AdministratorMainTemplate()
        {
            InitializeComponent();
        }

        private void AdministratorMainTemplate_Load(object sender, EventArgs e)
        {
           
        }
        #region Instances
        public View view = new View();
        public Model model = new Model();
        #endregion

        public void ChangeBackgroundColourBtn(string value)
        {
            if (value == "ServiceAdminBtn")
            {
                ServiceAdminBtn.BackColor = Color.Gray;
                UsersAdminBtn.BackColor = Color.Transparent;
                PermissionsAdminBtn.BackColor = Color.Transparent;
            }
            else if (value == "UsersAdminBtn")
            {
                PermissionsAdminBtn.BackColor = Color.Transparent;
                ServiceAdminBtn.BackColor = Color.Transparent;
                UsersAdminBtn.BackColor = Color.Gray;
            }
            else if (value == "PermissionsAdminBtn")
            {
                ServiceAdminBtn.BackColor = Color.Transparent;
                UsersAdminBtn.BackColor = Color.Transparent;
                PermissionsAdminBtn.BackColor = Color.Gray;
            }
            else if (value == "AFeedbackbtn")
            {
                ServiceAdminBtn.BackColor = Color.Transparent;
                UsersAdminBtn.BackColor = Color.Transparent;
                PermissionsAdminBtn.BackColor = Color.Transparent;
                guna2Button1.BackColor = Color.Gray;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdministratorServices administratorServices = new AdministratorServices();
            administratorServices.Show();
            this.Hide();
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AdministratorChkckUsers ACU = new AdministratorChkckUsers();
            ACU.Show();
            this.Hide();
        }

        private void EventsBtn_Click(object sender, EventArgs e)
        {
            AdministratorM admin = new AdministratorM();
            admin.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AdministratorPermissions administratorPermissions = new AdministratorPermissions();
            administratorPermissions.Show();
            this.Hide();
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

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AFeedback aFeedback = new AFeedback();
            aFeedback.Show();
            this.Hide();
        }
    }
}

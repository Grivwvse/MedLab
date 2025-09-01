using DiplomProgramm.UI.CheckInCastumer;
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
using System.Diagnostics;
using ZXing;

namespace DiplomProgramm.UI.Аuthorization
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        #region Instances
        View view = new View();
        #endregion

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            bool Value = view.Authentification(LoginTxtBox.Text, PasswdTxtBox.Text);
            if (Value == true)
            {
                this.Hide();
            }
            
        }

        public void CloseAuthBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MailClass mail = new MailClass();
            //mail.SendMessage();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}

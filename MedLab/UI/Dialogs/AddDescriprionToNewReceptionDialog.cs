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
    public partial class AddDescriprionToNewReceptionDialog : Form
    {
        public AddDescriprionToNewReceptionDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDescriptionToNewOrderBtn_Click(object sender, EventArgs e)
        {
            int CountOfSymbolsInTxtBox = ReceptionDescriptionTxtBox.Text.ToCharArray().Count();
            if (CountOfSymbolsInTxtBox > 300)
            {
                MessageBox.Show("Максимально число символов - 300, вы привысили это значение!");
            }
            else
            {
                Program.NewReceptionDescription = ReceptionDescriptionTxtBox.Text;
                MessageBox.Show("Описание добавленно!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void AddDescriprionToNewReceptionDialog_Load(object sender, EventArgs e)
        {

        }
    }
}

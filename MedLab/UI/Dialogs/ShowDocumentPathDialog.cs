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
    public partial class ShowDocumentPathDialog : Form
    {
        public ShowDocumentPathDialog()
        {
            InitializeComponent();
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextBoxPath_TextChanged(object sender, EventArgs e)
        {

        }

        public void FillTxtBox(string path)
        {
            TextBoxPath.Text = path;
        }
    }
}

using DiplomProgramm.Core;
using DiplomProgramm.UI.CheckInCastumer;
using DiplomProgramm.UI.CheckInCastumer.ClientsPersonalAcc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View = DiplomProgramm.Core.View;

namespace DiplomProgramm.UI.Dialogs
{
    public partial class RegisterNewClientDialog : Form
    {
        public RegisterNewClientDialog()
        {
            InitializeComponent();
        }
        #region Instances
        View view = new View();
        Model model = new Model();
        #endregion
        public int DocumentNumber = 0;
        public DateTime Date = new DateTime();
        public string link = "";

        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegisterNewClientDialog_Load(object sender, EventArgs e)
        {
            SaveReceptionBtn.Enabled = false;
            CopyLinkDocument.Enabled = false;
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            UnlockRegisterBtn();
        }
        private void UnlockRegisterBtn()
        {
            if (guna2CheckBox1.Checked & guna2CheckBox2.Checked)
            {
                SaveReceptionBtn.Enabled = true;
            }
            else
            {
                SaveReceptionBtn.Enabled = false;
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для создания НОВОГО клиента выполните следующие действия:" + "\n" + "1. Выишите необходимые данные для регистрации в соответствующие поля,Проверьте правильность данных" + "\n"
                + "2. Нажмите на кнопку Договор" + "\n" + "3.Откроется заполненный документ" + "\n" + " *Если документ не открылся и программа не выдала ошибку, тогда скопируйте путь к файлу, " +
                "нажав на кнопку ССЫЛКА и вставьте в адресную строку проводника и нажмите ENTER" + "\n" + "4.Распечатайте и одтайде клиенту на подпись"
                + "\n" + "После подписи документа нажмите на две кнопки ДОКУМЕНТ ПОДПИСАН, после чего разблокируется кнопка СОХРАНИТЬ, нажмите на нее" + "\n" + "После чего клиент будет успешно занесен в базу данных");
        }

        private void DogovorPrintBtn_Click(object sender, EventArgs e)
        {
            if (ClientFIOTxtBox.Text != "" & PassportTxtBox.Text != "" & PhoneTxtBox.Text != "" & EmailTxtBox.Text != "" & GivenByTxtBox.Text != "" & DataPickerDateOfBirth.Value.ToShortDateString() != "05.05.2022")
            {
                Date = DateTime.Now;
                string date = Date.ToShortDateString();

                model.SaveContractData(date);
                DocumentNumber = view.GetDocumentNumber();

                Date = DataPickerDateOfBirth.Value;
                string dateofbirth = Date.ToShortDateString();

                Date = Convert.ToDateTime(date);

                string PassportNumber = PassportTxtBox.Text;
                string[] spearator = PassportNumber.Split(' ');
                string PassportFirstNumber = spearator[0];
                string PassportSecoundNumber = "";
                if (spearator.Length < 2)
                {
                    PassportSecoundNumber = "";
                }
                else
                {
                    PassportSecoundNumber = spearator[1];
                }


                string docNumber = Convert.ToString(DocumentNumber);

                WordHelper wordHelper = new WordHelper("DocumentsTemplates/contract-and-blank.docx");
                var items = new Dictionary<string, string>
            {
                {"<DogovorNumber>", docNumber},
                {"<Date>", date},
                {"<DateOfBirth>", dateofbirth},
                {"<PassportGivenBy>", GivenByTxtBox.Text},
                {"<ClientFIO>", ClientFIOTxtBox.Text},
                {"<PassportFirstN>",PassportFirstNumber },
                {"<PassportSectN>",PassportSecoundNumber },
                {"<PassportNumber>",PassportNumber },
                {"<Phone>",PhoneTxtBox.Text },
                {"<Email>",EmailTxtBox.Text },
            };

                link = wordHelper.Process(items);
                if (link != "Error")
                {
                    Process.Start($@"{link}");
                    CopyLinkDocument.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при работе с документом, проверьте, что не используете его сейчас!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UnlockRegisterBtn();
            }
            else
            {
                MessageBox.Show("Вы не ввели все необходимые данные!");
            }
          
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            UnlockRegisterBtn();
        }

        private void SaveReceptionBtn_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            string FIO = ClientFIOTxtBox.Text;
            string[] spearator = FIO.Split(' ');
            model.CreateClient(spearator[1], spearator[0], spearator[2], DataPickerDateOfBirth.Value, PhoneTxtBox.Text, EmailTxtBox.Text, PassportTxtBox.Text, DocumentNumber);
            VClients vclients = new VClients();
            vclients.UpdateDGV();
            this.Hide();
        }

        private void CopyLinkDocument_Click(object sender, EventArgs e)
        {
            Clipboard.SetText($"{link}");
        }
    }
}

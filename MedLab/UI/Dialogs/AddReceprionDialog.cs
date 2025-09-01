using DiplomProgramm.Core;
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
using ZXing;
using View = DiplomProgramm.Core.View;

namespace DiplomProgramm.UI.Dialogs
{
    public partial class AddReceprionDialog : Form
    {
        public AddReceprionDialog()
        {
            InitializeComponent();
        }
        private void AddReceprionDialog_Load(object sender, EventArgs e)
        {
            
            DataGridViewServices.DataSource = view.ShowAvailableServices();
            DataGridViewServices.Columns[0].HeaderText = "Номер услуги";
            DataGridViewServices.Columns[1].HeaderText = "Наименование";
            DataGridViewServices.Columns[2].Visible = false;
            DataGridViewServices.Columns[3].HeaderText = "Цена";
            DataGridViewServices.Columns[4].HeaderText = "Доступность";
            //SaveReceptionBtn.Enabled = false;
            //AddDescriptionToNewOrderBtn.Enabled = false;
        }
        #region Instances
        View view = new View();
        #endregion
        List<ServicesTable> servicesTables = new List<ServicesTable>();
        private void MinimazedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBarSavingEvent.Value > 25)
            {
                timer1.Enabled = false;
                MessageBox.Show("Событие успешно добавленно!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ProgressBarSavingEvent.Value += 1;
            }

        }

        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для создания записи:" + "\n" + "1.Выбрать нужную дату, для этого нажмите на ораньжевый прямоугольник, под словами ДАТА ЗАПИСИ" + "\n"
                + "Откроется окно выбора даты, выберете Дату сдачи анализов" + "\n" + "2.В соседнем прямоугольнике под под словами ВРЕМЯ ЗАПИСИ выберете время сдачи анализов"
                + "\n" + "* Если нужного времени в списке нету, значит оно уже занято другой записью" + "\n" + "3.Выберете, щелкнул мышкой по услуге в списке" + "\n" +
                "*Если не можете найти услугу, то воспользуйтесь поиском по Названию услуги" + "\n" + "*Если так и не смогли найти услугу, то скорее всего Администратор удалил ее" + "\n" 
                +"4.Если требуется добавть какое-то описание для услуги, то нажмите на кнопку +ОПИСАНИЕ, откроется окно, впишите в текстовое поле нового окна описание и в этом же окне нажмите на кнопку +ДОБАВИТЬ" + "\n"+
                "5.Последним действием является сохранение новой записи, для этого нажмите на кнопку СОХРАНИТЬ и запись будет успешно добавленна");
        }

        private void SaveReceptionBtn_Click(object sender, EventArgs e)
        {
            int ServiceID = 0;
            if (Program.CurrentPersonalServiceId == 0)
            {
                int SelectedRow = DataGridViewServices.CurrentCell.RowIndex;
                var client = DataGridViewServices.Rows[SelectedRow];
                ServiceID = (int)client.Cells[0].Value;
            }
            else
            {
                ServiceID = Program.CurrentPersonalServiceId;
            }


            string[] HoursAndMinutes = ComboBoxFreeTimeOnThisDate.Text.Split(':');
            int Hours = Convert.ToInt32(HoursAndMinutes[0]);
            int Minutes = Convert.ToInt32(HoursAndMinutes[1]);

            DateTime AddReceptionDate = new DateTime(DataPickerLastDateVisitingTakeAnalize.Value.Year, DataPickerLastDateVisitingTakeAnalize.Value.Month, DataPickerLastDateVisitingTakeAnalize.Value.Day, Hours, Minutes, 00);
            view.AddNewReceptionToDB(ServiceID, AddReceptionDate, CheckBoxSendResultEmail.Checked);
            Receptions receptions = new Receptions();
            receptions.UpdateDataGridView();
            ProgressBarSavingEvent.Maximum = 26;
            timer1.Enabled = true;
        }

        private void DataPickerLastDateVisitingTakeAnalize_ValueChanged(object sender, EventArgs e)
        {
            
            List<DateTime> FreeTime = view.ShowFreeTimeOnCurrentDate(DataPickerLastDateVisitingTakeAnalize.Value);
            for (int i = 0; i < FreeTime.Count; i++)
            {
                if (FreeTime[i].Minute == 0)
                {
                    ComboBoxFreeTimeOnThisDate.Items.Add($"{FreeTime[i].Hour}" + ":" + $"{FreeTime[i].Minute}0");
                }
                else ComboBoxFreeTimeOnThisDate.Items.Add($"{FreeTime[i].Hour}" +":" + $"{FreeTime[i].Minute}");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<ServicesTable> service = view.SearchServices(SearchTxtBox.Text);
            List<ServicesTable> Nulll = view.ShowAvailableServices();
            if (!(service.Count == 0))
            {
                DataGridViewServices.DataSource = service;
            }
            else
            {
                DataGridViewServices.DataSource = Nulll;
                MessageBox.Show("Услуг с таким наименованием не найдено!");
            }
            
        }

        private void AddDescriptionToNewOrderBtn_Click(object sender, EventArgs e)
        {
            AddDescriprionToNewReceptionDialog Dialog = new AddDescriprionToNewReceptionDialog();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (Dialog.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                MessageBox.Show("Отмененно");
            }
            Dialog.Dispose();
        }

        private void ComboBoxFreeTimeOnThisDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string checkResukt = "";
            
            if (ComboBoxFreeTimeOnThisDate.SelectedIndex == -1)
            {
                if (DataPickerLastDateVisitingTakeAnalize.Value.ToShortDateString() == "05.05.2022")
                {
                    MessageBox.Show("Вы не выбрали дату и время!");
                }
                else
                {
                    MessageBox.Show("Вы не выбрали время записи!");
                }
            }
            else if (DataPickerLastDateVisitingTakeAnalize.Value < DateTime.Now)
            {
                MessageBox.Show("Вы выбрали некорректную дату!");
            }
            else
            {               
            
                string Description = "";
                string Description1 = "";
                string Description2 = "";

                DateTime Date = DateTime.Now;
                string date = Date.ToShortDateString();

                ContractsTable Contract = view.GetDataContract();
                string ContractID = Convert.ToString(Contract.ContractID);
                string ContractDatetime = Convert.ToString(Contract.ContractDate);

                ClientsTable client = view.GetClientInfo();
                string ClientFIO = (client.Surname + " " + client.Name + " " + client.Patronymic);

                Date = client.DateOfBirth;
                string dateofbirth = Date.ToShortDateString();

                int serviceID = 0;
                if (Program.CurrentPersonalServiceId == 0)
                {
                    int SelectedRow = DataGridViewServices.CurrentCell.RowIndex;
                    var DateSelIndex = DataGridViewServices.Rows[SelectedRow];
                    serviceID = (int)DateSelIndex.Cells[0].Value;
                }
                else
                {
                    serviceID = Program.CurrentPersonalServiceId;
                }

                List<AnalyzesTable> analyzes = view.GetAllAnalyzesFromCurrentServices(serviceID);
                for (int i = 0; i < analyzes.Count; i++)
                {
                    if (i == 0)
                    {
                        Description = ($"{Description} " + $"{analyzes[i].Name}");
                    }
                    else
                    {
                        Description = ($"{Description}, " + $"{analyzes[i].Name}");
                    }

                }

                string[] wordsDesc = Description.Split(',');
                if (wordsDesc.Length > 3)
                {
                    int Middle = wordsDesc.Length / 2;
                    for (int i = 0; i <= Middle; i++)
                    {
                        Description1 += wordsDesc[i] + ",";
                    }

                    for (int i = Middle + 1; i < wordsDesc.Length; i++)
                    {
                        Description2 += wordsDesc[i] + ",";
                    }
                }
                else
                {
                    Description1 = Description;

                }

                ServicesTable service = view.GetServiceInfo(serviceID);
                if (service.Aviability == true)
                {
                    string ServID = Convert.ToString(service.ServiceID);

                    service.Description = Description;
                    string NameService = service.Name;
                    string serviceIID = Convert.ToString(service.ServiceID);

                    Date = DataPickerLastDateVisitingTakeAnalize.Value;
                    string dateComeIn = Date.ToShortDateString();

                    string serviceCost = Convert.ToString(service.Cost);

                    WordHelper wordHelper = new WordHelper(@"D:\Шарага\проекты вижлы\DiplomProgramm\DocumentsTemplates\ClientsAnalyzeList.docx");
                    var items = new Dictionary<string, string>
                    {
                        {"<Datenow>", date},
                        {"<Date>", ContractDatetime},
                        {"<DogovorNumber>", ContractID},
                        {"<ClientFIO>", ClientFIO},
                        {"<DateOfBirth>", dateofbirth },
                        {"<Pol>","-" },
                        {"<Phone>", client.Phone },
                        {"<ServiceIDd>", serviceIID },
                        {"<ServiceNamee>", NameService },
                        {"<ServiceDecription>", $"{Description1}" },
                        {"<ServiceDecription1>", $"{Description2}" },
                        {"<DateComeIn>", dateComeIn },
                        {"<ServiceCost>", serviceCost },
                        {"<Email>", client.Email },
                    };

                    string link = wordHelper.Process(items);
                    if (link != "Error")
                    {

                        //SaveReceptionBtn.Enabled = true;
                        int DataToEncode = view.GetLastOrderID() + 1;
                        ChangeImageWord changeImageWord = new ChangeImageWord($"{link}", DataToEncode);
                        changeImageWord.UpdateDoc();
                        Process.Start($@"{link}");
                        checkResukt = "OK";
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при работе с документом, проверьте, что не используете его сейчас!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Данная услуга не доступна!");
                }

                if (checkResukt == "OK")
                {
                    int ServiceID = 0;
                    if (Program.CurrentPersonalServiceId == 0)
                    {
                        int SelectedRow = DataGridViewServices.CurrentCell.RowIndex;
                        var client1 = DataGridViewServices.Rows[SelectedRow];
                        ServiceID = (int)client1.Cells[0].Value;
                    }
                    else
                    {
                        ServiceID = Program.CurrentPersonalServiceId;
                    }


                    string[] HoursAndMinutes = ComboBoxFreeTimeOnThisDate.Text.Split(':');
                    int Hours = Convert.ToInt32(HoursAndMinutes[0]);
                    int Minutes = Convert.ToInt32(HoursAndMinutes[1]);

                    DateTime AddReceptionDate = new DateTime(DataPickerLastDateVisitingTakeAnalize.Value.Year, DataPickerLastDateVisitingTakeAnalize.Value.Month, DataPickerLastDateVisitingTakeAnalize.Value.Day, Hours, Minutes, 00);
                    view.AddNewReceptionToDB(ServiceID, AddReceptionDate, CheckBoxSendResultEmail.Checked);
                    Receptions receptions = new Receptions();
                    receptions.UpdateDataGridView();
                    ProgressBarSavingEvent.Maximum = 26;
                    timer1.Enabled = true;
                    MessageBox.Show("Успешно!");
                    this.Hide();
                }

            }

        }

        private void CheckBoxSendResultEmail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CreatePresonalServiceDialog createPresonalServiceDialog = new CreatePresonalServiceDialog();
            var result = createPresonalServiceDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataGridViewServices.DataSource = servicesTables;
            }
            
        }
    }
}

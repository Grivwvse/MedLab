using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using DiplomProgramm.ClassesDV;
using DiplomProgramm.UI.Dialogs;

namespace DiplomProgramm.UI.LaboratoryAssistant
{
    public partial class LASearchClients : DiplomProgramm.UI.Templates.LaboratoryAssistantMainTemplate
    {
        public VideoCaptureDevice videoSource;
        public FilterInfoCollection videoDevice;
        private ZXing.BarcodeReader reader;
        delegate void SetStringDelegate(string param);
        private int OrderId = 0;

        #region Instances
        ScannerSettingsDialog scannerSettingsDialog = new ScannerSettingsDialog();
        #endregion
        #region Fields
        public OrdersTable order = new OrdersTable();
        List<ResultsTable> results = new List<ResultsTable>();
        List<LAAnalayzesResults> aAnalayzesResults = new List<LAAnalayzesResults>();
        List<LAAnalayzesResults> RefreshDatagrid = new List<LAAnalayzesResults>();
        #endregion
        public LASearchClients()
        {
            InitializeComponent();
        }

        private void LASearchClients_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColourBtn("ScanBtn");
            SaveReceptionBtn.Enabled = false;
            StopScanBtn.Enabled = false;

            //Scaner
            reader = new ZXing.BarcodeReader();
            reader.Options.PossibleFormats = new List<ZXing.BarcodeFormat>();
            reader.Options.PossibleFormats.Add(ZXing.BarcodeFormat.All_1D);
        }

        public void UpdateDataGridView()
        {
            results.Clear();
            aAnalayzesResults.Clear();
            OrderId = Convert.ToInt32(TextBoxScannerData.Text);
            order = view.GetOrderByID(OrderId);
            int ServiceID = order.ServiceID;
            ServicesTable services = view.GetServiceByID(ServiceID);
            List<AnalyzesTable> analyzes = view.GetAllAnalyzesFromCurrentServices(ServiceID);
            if (order.ResultID != null)
            {
                int ResultId = (int)order.ResultID;
                results = view.GetResultsByResultID(ResultId);
            }

            if (services != null & analyzes.Count != 0)
            {
                if (results.Count != 0)
                {
                    for (int i = 0; i < analyzes.Count; i++)
                    {
                        aAnalayzesResults.Add(new LAAnalayzesResults(analyzes[i].AnalyzeID, analyzes[i].Name, results[i].Result, analyzes[i].NormValue));
                    }
                }
                else
                {
                    for (int i = 0; i < analyzes.Count; i++)
                    {
                        aAnalayzesResults.Add(new LAAnalayzesResults(analyzes[i].AnalyzeID, analyzes[i].Name, "Данных нет", analyzes[i].NormValue));
                    }
                }
                LaborantViewAnalyzesListDataGridView.DataSource = RefreshDatagrid;
                //LaborantViewAnalyzesListDataGridView.Refresh();
                LaborantViewAnalyzesListDataGridView.DataSource = aAnalayzesResults;
                LaborantViewAnalyzesListDataGridView.Columns[0].HeaderText = "Код";
                LaborantViewAnalyzesListDataGridView.Columns[1].HeaderText = "Анализ";
                LaborantViewAnalyzesListDataGridView.Columns[2].HeaderText = "Результат";
                LaborantViewAnalyzesListDataGridView.Columns[3].HeaderText = "Норма,Ед изм.";
            }
            

        }

        private void SetResult(string result)
        {
            if (!InvokeRequired)
                TextBoxScannerData.Text = result;
            else
                Invoke(new SetStringDelegate(SetResult), new object[] { result });
        }

        private void ScanSettingsBtn_Click(object sender, EventArgs e)
        {
            if (videoSource == null)
            {
                scannerSettingsDialog.Show();
            }
            else
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                scannerSettingsDialog.Show();
            }
            
        }

        private void ButtonStartScan_Click(object sender, EventArgs e)
        {
            if (scannerSettingsDialog.videoSource == null)
            {
                MessageBox.Show("Для начала выберите в настройках видеокамеру!", "Critical Warning");
            }
            else
            {
                videoSource = scannerSettingsDialog.videoSource;
                videoSource.NewFrame += new NewFrameEventHandler(videoNewFrame);
                videoSource.Start();
            }

        }

        private void videoNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            PictureBoxCameraImage.Image = bitmap;

            ZXing.Result result = reader.Decode((Bitmap)eventArgs.Frame.Clone());
            if (result != null)
            {
                SetResult(result.Text);
            }
        }

        private void PictureBoxCameraImage_Click(object sender, EventArgs e)
        {

        }

        private void LASearchClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void TextBoxScannerData_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxScannerData.Text != "")
            {
                int OrderId = Convert.ToInt32(TextBoxScannerData.Text);
                order = view.GetOrderByID(OrderId);
                if (order != null)
                {
                    SaveReceptionBtn.Enabled = true;
                    OrderNumberLable.Text = "Заказ №" + order.OrderID;
                    UpdateDataGridView();
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LaborantViewAnalyzesListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveReceptionBtn_Click(object sender, EventArgs e)
        {
            Program.CurrentScanOrderID = OrderId;
            InputResultsToDBDialog inputResultsToDBDialog = new InputResultsToDBDialog(aAnalayzesResults, order.OrderID);
            var result = inputResultsToDBDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateDataGridView();
            }
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (scannerSettingsDialog.videoSource == null)
            {
                MessageBox.Show("Для начала выберите в настройках видеокамеру!", "Critical Warning");
            }
            else
            {
                videoSource = scannerSettingsDialog.videoSource;
                videoSource.NewFrame += new NewFrameEventHandler(videoNewFrame);
                videoSource.Start();
                StopScanBtn.Enabled = true;
            }
        }

        private void StopScanBtn_Click(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.WaitForStop();
            StopScanBtn.Enabled = false;
        }
    }
}

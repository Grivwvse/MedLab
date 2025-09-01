using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace DiplomProgramm.UI.Dialogs
{
    public partial class ScannerSettingsDialog : Form
    {
        public FilterInfoCollection videoDevices;
        public VideoCaptureDevice videoSource;
        public ScannerSettingsDialog()
        {
            InitializeComponent();
        }

        private void ScannerSettingsDialog_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    listBoxChooseInputDevice.Items.Add(device.Name);
                }
                // можно поменять чтобы default былл такой то девайс по счету
                listBoxChooseInputDevice.SelectedIndex = 0;
            }

        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ChooseVideoDeviceBtn_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevices[listBoxChooseInputDevice.SelectedIndex].MonikerString);
            MessageBox.Show("Настройки успешно сохранены!");
            this.Hide();
        }

        private void SaveReceptionBtn_Click(object sender, EventArgs e)
        {

        }

        private void MinimazedBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

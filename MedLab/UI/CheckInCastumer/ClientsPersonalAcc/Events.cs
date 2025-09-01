using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiplomProgramm.UI.CheckInCastumer.ClientsPersonalAcc
{
    public partial class Events : DiplomProgramm.UI.Templates.ClientsPersonalAccTemplate
    {
        public Events()
        {
            Program.SecondaryCurrentOpenPage = "Events";
            ChangeBackgroundColourBtnMenu("EventsBtn");
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {

            UpdatePersonalAccDataClient();
            List<ResultsTable> results = new List<ResultsTable>();
            List<OrdersTable> orders = view.GetAllOrdersFromClientsID();
            List<ServicesTable> services = new List<ServicesTable>();
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].ResultID != null)
                {
                    results.Add(view.GetResultById((int)orders[i].ResultID));
                    services.Add(view.GetServiceByID((int)orders[i].ServiceID));
                    if (i == 0)
                    {
                        listBoxClientEvents.Items.Add("Дата \t     Запись№ \t Услуга ");
                    }
                    listBoxClientEvents.Items.Add($"{results[i].CreationDate.ToShortDateString()} \t {orders[i].OrderID} \t {services[i].Name} \t Пришли результаты!");
                }

            }
            
        }
    }
}

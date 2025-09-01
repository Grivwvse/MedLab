using DiplomProgramm.UI.CheckInCastumer;
using DiplomProgramm.UI.CheckInCastumer.ClientsPersonalAcc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProgramm.UI.UISettings
{
    public class UISettings
    {

        #region Instances


        #endregion
        private string _currentOpenForm;

        public string CurrentOpenForm
        {
            get { return _currentOpenForm; }
            set { _currentOpenForm = value; }
        }

        /// <summary>
        /// Функкция Смены форм
        /// </summary>
        /// <param name="hideForm">Форма текущая, которую нужно скрыть</param>
        /// <param name="showForm">Форма, которую нужно открыть</param>
        public void OpenPagesLogic(string hideForm, string showForm)
        {

            if (hideForm == "Home" & showForm == "VClients")
            {
                Home HideForm = (Home)Application.OpenForms["Home"];
                VClients ShowForm = new VClients();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "Home" & showForm == "Services")
            {
                Home HideForm = (Home)Application.OpenForms["Home"];
                Services ShowForm = new Services();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "VClients" & showForm == "Home")
            {
                VClients HideForm = (VClients)Application.OpenForms["VClients"];
                Home ShowForm = new Home();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "VClients" & showForm == "Services")
            {
                VClients HideForm = (VClients)Application.OpenForms["VClients"];
                Services ShowForm = new Services();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "VClients" & showForm == "VClients")
            {
                VClients HideForm = (VClients)Application.OpenForms["VClients"];
                VClients ShowForm = new VClients();
                OpenSamePage(ShowForm, HideForm);
            }
            else if (hideForm == "Services" & showForm == "Home")
            {
                Services HideForm = (Services)Application.OpenForms["Services"];
                Home ShowForm = new Home();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "Services" & showForm == "VClients")
            {
                Services HideForm = (Services)Application.OpenForms["Services"];
                VClients ShowForm = new VClients();
                OpenSamePage(HideForm, ShowForm);
            }

            else if (hideForm == "Events" & showForm == "Receptions")
            {
                Events HideForm = (Events)Application.OpenForms["Events"];
                Receptions ShowForm = new Receptions();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "Events" & showForm == "ChangeInfo")
            {
                Events HideForm = (Events)Application.OpenForms["Events"];
                ChangeInfo ShowForm = new ChangeInfo();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "Receptions" & showForm == "Receptions")
            {
                Receptions HideForm = (Receptions)Application.OpenForms["Receptions"];
                Receptions ShowForm = new Receptions();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "Receptions" & showForm == "ChangeInfo")
            {
                Receptions HideForm = (Receptions)Application.OpenForms["Receptions"];
                ChangeInfo ShowForm = new ChangeInfo();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "Receptions" & showForm == "Events")
            {
                Receptions HideForm = (Receptions)Application.OpenForms["Receptions"];
                Events ShowForm = new Events();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "ChangeInfo" & showForm == "Events")
            {
                ChangeInfo HideForm = (ChangeInfo)Application.OpenForms["ChangeInfo"];
                Events ShowForm = new Events();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "ChangeInfo" & showForm == "Receptions")
            {
                ChangeInfo HideForm = (ChangeInfo)Application.OpenForms["ChangeInfo"];
                Receptions ShowForm = new Receptions();
                OpenSamePage(HideForm, ShowForm);
            }
            else if (hideForm == "VClients" & showForm == "Events")
            {
                VClients HideForm = (VClients)Application.OpenForms["VClients"];
                Events ShowForm = new Events();
                OpenSamePage(HideForm, ShowForm);
            }

          

            else
            {
                MessageBox.Show("Не предвиденная ошибка (0x001), обратитесь к системному администратору");
            }

        }
        /// <summary>
        /// Метод реализации полученных данных с OpenPagesLogic
        /// </summary>
        /// <param name="HideForm">Текущая форма</param>
        /// <param name="ShowForm">Новая форма</param>
        protected void OpenPages(Form HideForm, Form ShowForm)
        {

            HideForm.Close();
            ShowForm.Show();
            ShowForm.Location = HideForm.Location;
            ShowForm.Size = HideForm.Size;

        }
        protected void OpenSamePage(Form HideForm,Form ShowForm)
        {
            if (HideForm == null)
            {
                FormCollection formsList = Application.OpenForms;
                
                for (int i = 0; i < formsList.Count; i++)
                {
                    if (formsList[i].Name != "Authorization")
                    {
                        formsList[i].Close();
                    }
                    
                }
                ShowForm.Show();

            }
            else if (HideForm != null & ShowForm != null)
            {
                OpenPages(HideForm, ShowForm);
            }


        }


    }
}

using DiplomProgramm.UI.Administrator;
using DiplomProgramm.UI.CheckInCastumer;
using DiplomProgramm.UI.UISettings;
using DiplomProgramm.UI.Аuthorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProgramm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
        public static int CurrentUser { get; set; }
        public static int CurrentClietnPersonalAcc { get; set; }
        public static string CurrentOpenPage { get; set; }
        public static string SecondaryCurrentOpenPage { get; set; }
        public static string NewReceptionDescription { get; set; }
        public static int CurrentPersonalServiceId { get; set; } = 0;
        public static int CurrentScanOrderID { get; set; } = 0;
        public static class Instanses
        {
            /// <summary>
            /// Переходный метод для основного меню (Кастыль для перехода между формами)
            /// </summary>
            /// <param name="ShowFormStr">Наименование формы, которую нужно открыть</param>
            public static void UpdateInstanceHome(string ShowFormStr)
            {
                UISettings UIS = new UISettings();
                UIS.OpenPagesLogic(CurrentOpenPage, ShowFormStr);
            }

            public static void SecondaryMenu(string ShowSecondaryFromStr)
            {
                UISettings UIS = new UISettings();
                UIS.OpenPagesLogic(SecondaryCurrentOpenPage, ShowSecondaryFromStr);
            }

            public static void OpenSecondaryForm(string ShowSecondaryFromStr)
            {
                UISettings UIS = new UISettings();
                UIS.OpenPagesLogic("VClients", ShowSecondaryFromStr);
            }

            public static void UpdateAdministratorDGVEvents()
            {
                AdministratorM administrator = new AdministratorM();
                administrator.FillListBoxEvents();
            }

            public static void UpdateAdministratorEventDatagridViw()
            {
                AdministratorM administrator = new AdministratorM();
                administrator.FillListBoxEvents();
            }

        }
        
    }
}

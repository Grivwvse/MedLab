using DiplomProgramm.ClassesDV;
using DiplomProgramm.UI.Administrator;
using DiplomProgramm.UI.CheckInCastumer;
using DiplomProgramm.UI.Dialogs;
using DiplomProgramm.UI.LaboratoryAssistant;
using DiplomProgramm.UI.Аuthorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProgramm.Core
{
    public class View
    {
        #region Instances
        //TimeTableReception timeTableReception = new TimeTableReception();
        #endregion
        public List<ClientsTable> ReturnAllClients()
        {
            using (DBConnection db = new DBConnection())
            {
                List<ClientsTable> LU = db.ClientsTable.ToList();
                return LU;
            }
        }
        /// <summary>
        /// Функция поиска клиентов по имени - фамилии - номеру паспорта
        /// </summary>
        /// <param name="SearchParametr">анные из текстбокса</param>
        /// <returns></returns>
        public List<ClientsTable> ReturnAllSearchClients(string SearchParametr)
        {
            using (DBConnection db = new DBConnection())
            {
                List<ClientsTable> LU = db.ClientsTable.Where(x=> x.Surname == SearchParametr).ToList();

                if (LU.Count == 0)
                {
                    LU = db.ClientsTable.Where(x => x.Name == SearchParametr).ToList();

                    if (LU.Count == 0)
                    {
                        LU = db.ClientsTable.Where(x => x.Passport == SearchParametr).ToList();

                        if (LU.Count == 0)
                        {
                            LU = ReturnAllClients();
                            return LU;
                        }
                        else
                        {
                            return LU;
                        }
                    }
                    else
                    {
                        return LU;
                    }
                }
                else
                {
                    return LU;
                }
                
            }
        }

        public ClientsTable GetClientByID(int ClientID)
        {
            using (DBConnection db = new DBConnection())
            {
                ClientsTable client = db.ClientsTable.Where(x => x.ClientID == ClientID).FirstOrDefault();
                return client;
            }
        }

        public bool Authentification(string login, string password)
        {
            bool returnValue;
            //юзинг - безопасный воид коннектион
            using (DBConnection db = new DBConnection())
            {
                UsersTable userA = db.UsersTable.FirstOrDefault(x => x.Login == login && x.Password == password);
                if (!(userA == null))
                {
                    Authorization authorization = new Authorization();
                    authorization.Hide();
                    Program.CurrentUser = userA.UserID;
                    returnValue = CheckRole(userA);
                    return returnValue;


                }
                else
                {
                    MessageBox.Show("Проверьте правильность введенных данных!");
                    return false;
                }

            }

        }

        private bool CheckRole(UsersTable user)
        {
            using (DBConnection db = new DBConnection())
            {
                int RoleUserID = user.RoleID;
                RoleTable role = db.RoleTable.Where(x => x.RoleID == RoleUserID).FirstOrDefault();
                int PermissionID = role.PermissionID;
                PermissionTable permission = db.PermissionTable.Where(x => x.PermissionID == PermissionID).FirstOrDefault();

                if (permission.PermissionCode == 459518)
                {
                    if (user.RoleID == 1)
                    {
                        Home form1 = new Home();
                        form1.ChangeBackgroundColourBtn("HomeBtn");
                        form1.Show();
                        return true;
                    }
                    else if (user.RoleID == 2)
                    {
                        AdministratorM administrator = new AdministratorM();
                        administrator.Show();
                        return true;
                    }
                    else if (user.RoleID == 3)
                    {
                        LAEvents lAEvents = new LAEvents();
                        lAEvents.Show();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("Администратор запретил вам вход в систему!");
                    return false;
                }
            }
        }

        public string GetCurrentUserName()
        {
            using (DBConnection db = new DBConnection())
            {
                UsersTable user = db.UsersTable.Where(x => x.UserID == Program.CurrentUser).FirstOrDefault();
                return user.Name;
            }
        }

        public List<GlobalEventsTable> ShowActiveEvents()
        {
            using (DBConnection db = new DBConnection())
            {
                List<GlobalEventsTable> globalEventsTables = db.GlobalEventsTable.Where(x => x.Duration > DateTime.Now).ToList();

                //foreach (var item in globalEventsTables)
                //{
                //    if (item.Duration < DateTime.Now)
                //    {
                //        globalEventsTables.Remove(item);
                //    }
                //}
                return globalEventsTables;
            }
        }

        public List<GlobalEventsTable> ShowActiveEventsCheckInCastumer()
        {
            using (DBConnection db = new DBConnection())
            {
                List<GlobalEventsTable> globalEventsTables = db.GlobalEventsTable.Where(x=> x.ShowIn == "Reception" || x.ShowIn == "all" & x.Duration > DateTime.Now).ToList();
                for (int i = 0; i < globalEventsTables.Count; i++)
                {
                    if (globalEventsTables[i].Duration < DateTime.Now)
                    {
                        globalEventsTables.Remove(globalEventsTables[i]);
                    }

                }
                return globalEventsTables;
            }
        }

        public List<GlobalEventsTable> ShowActiveEventsLaboratoryAssistant()
        {
            using (DBConnection db = new DBConnection())
            {
                List<GlobalEventsTable> globalEventsTables = db.GlobalEventsTable.Where(x => x.ShowIn == "Laboratory" || x.ShowIn == "all" & x.Duration > DateTime.Now).ToList();
                for (int i = 0; i < globalEventsTables.Count; i++)
                {
                    if (globalEventsTables[i].Duration < DateTime.Now)
                    {
                        globalEventsTables.Remove(globalEventsTables[i]);
                    }

                }
                return globalEventsTables;
            }
        }

        public string GetCurrentCellValueFIOAdministratorForm(int id)
        {
            using (DBConnection db = new DBConnection())
            {
                UsersTable user = db.UsersTable.Where(x => x.UserID == id).FirstOrDefault();
                return user.Surname;
            }
        }


        /// <summary>
        /// Открытие диалога, зачем я его сюда запихнул? - Не знаю
        /// </summary>
        public void ShowAddEventDialog()
        {
            AddEventDialog Dialog = new AddEventDialog();

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

        public void AddGlobalEvent(int VisibleFor, int Importance, DateTime DateEndEvent, string MainTextEvent)
        {
            string Visible = "all";
            if (VisibleFor == 1)
            {
                Visible = "Reception";
            }
            else if (VisibleFor == 2)
            {
                Visible = "Laboratory";
            }

            using (DBConnection db = new DBConnection())
            {
                GlobalEventsTable globalEventsTable = new GlobalEventsTable();
                globalEventsTable.UserID = Program.CurrentUser;
                globalEventsTable.Importance = Importance;
                globalEventsTable.Name = MainTextEvent;
                globalEventsTable.CreationDate = DateTime.Now;
                globalEventsTable.Duration = DateEndEvent;
                globalEventsTable.ShowIn = Visible;
                db.GlobalEventsTable.Add(globalEventsTable);
                db.SaveChanges();

            }

            Program.Instanses.UpdateAdministratorDGVEvents();

        }

        public void DelGlobalEvent(int EventId)
        {
            using (DBConnection db = new DBConnection())
            {
                GlobalEventsTable globalEventsTable = db.GlobalEventsTable.FirstOrDefault(x => x.EventID == EventId);
                db.GlobalEventsTable.Remove(globalEventsTable);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Timetable
        /// </summary>
        /// <returns></returns>
        public List<TimeTableReception> ShowAllTimeTableForCurrentClient()
        {
            using (DBConnection db = new DBConnection())
            {
                //Получаем данные клиента, а именно его ФИО
                ClientsTable client = db.ClientsTable.Where(x => x.ClientID == Program.CurrentClietnPersonalAcc).FirstOrDefault();
                if (client.Name == null)
                {
                    MessageBox.Show("Не удалось найти клиента, системный сбой, обратитесь к администратору");
                }
                //Получаем данные Заказов
                List<OrdersTable> orders = db.OrdersTable.Where(x => x.ClientID == Program.CurrentClietnPersonalAcc).ToList();

                //Получаем данные об услугах, а именно его наименование услуги
                List<ServicesTable> services = new List<ServicesTable>();
                for (int i = 0; i < orders.Count; i++)
                {
                    int ServiceID = orders[i].ServiceID;
                    ServicesTable service = db.ServicesTable.Where(x => x.ServiceID == ServiceID).FirstOrDefault();
                    services.Add(service);
                }

                //Создание расписания
                List<TimeTableReception> timeTable = new List<TimeTableReception>();
                for (int i = 0; i < orders.Count; i++)
                {
                    string ResultTimetable = "";
                    if (orders[i].ResultID == null)
                    {
                        ResultTimetable = "Результатов нет";
                    }
                    else
                    {
                        ResultTimetable = "Результаты готовы";
                    }
                    timeTable.Add(new TimeTableReception(orders[i].DateComeIn, orders[i].OrderID, services[i].Name, (client.Surname + client.Name + client.Patronymic), orders[i].CreationDate, ResultTimetable));
                    //timeTable[i].DateComeIn = orders[i].DateComeIn;
                    //timeTable[i].ServiceID = orders[i].ServiceID;
                    //timeTable[i].ServiceName = services[i].Name;адо 
                    //timeTable[i].ClientFIO = (client.Surname + client.Name + client.Patronymic);
                    //timeTable[i].CreationDate = orders[i].CreationDate;
                }

                return timeTable;
            }
        }
        public List<DateTime> ShowFreeTimeOnCurrentDate(DateTime PickedDate)
        {
            DateTime UselessVar = new DateTime(2022, 01, 01, 08, 00, 00);
            List<DateTime> Timetable = new List<DateTime>();
            for (int i = 0; i < 72; i++)
            {
                
                Timetable.Add(UselessVar);
                UselessVar = UselessVar.AddMinutes(10);
            }

            using (DBConnection db = new DBConnection())
            {
                List<OrdersTable> orders = db.OrdersTable.Where(x => x.DateComeIn.Month == PickedDate.Month & x.DateComeIn.Day == PickedDate.Day & x.DateComeIn.Year == PickedDate.Year).ToList();
                for (int i = 0; i < orders.Count; i++)
                {
                    for (int j = 0; j < Timetable.Count; j++)
                    {
                        if (orders[i].DateComeIn.Minute == Timetable[j].Minute & orders[i].DateComeIn.Hour == Timetable[j].Hour)
                        {
                            Timetable.RemoveAt(j);
                        }
                    }
                }
            }
            return Timetable;
        }
        public List<ServicesTable> ShowAvailableServices()
        {
            using (DBConnection db = new DBConnection())
            {
                List<ServicesTable> services = db.ServicesTable.Where(x => x.Aviability == true).ToList();
                List<int> indexToDel = new List<int>();
                List<ServicesTable> servicesWithoutPersonal = new List<ServicesTable>();

                for (int i = 0; i < services.Count; i++)
                {
                    if (services[i].Name != "Персональная услуга")
                    {
                        servicesWithoutPersonal.Add(services[i]);
                    }
                }


                return servicesWithoutPersonal;
            }
        }
        public List<ServicesTable> ShowServicesBySearchNVailable(string Name)
        {
            using (DBConnection db = new DBConnection())
            {
                List<ServicesTable> services = db.ServicesTable.Where(x => x.Aviability == true & x.Name == Name).ToList();
                return services;
            }
        }
        public void AddNewReceptionToDB(int ServiceID, DateTime DateComeIn, bool SandToEmail)
        {
            int ErrorOccure = 0;
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    OrdersTable order = new OrdersTable();
                    order.ClientID = Program.CurrentClietnPersonalAcc;
                    order.ServiceID = ServiceID;
                    order.CreationDate = DateTime.Now;
                    order.DateComeIn = DateComeIn;
                    order.Status = "Активен";
                    order.SendEmail = SandToEmail;
                    order.UserID = Program.CurrentUser;
                    if (!(Program.NewReceptionDescription == null))
                    {
                        order.Description = Program.NewReceptionDescription;
                    } 
                    db.OrdersTable.Add(order);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла системная ошибка при добавлении нового заказа");
                ErrorOccure = 1;
            }
            if (ErrorOccure == 0)
            {
                MessageBox.Show("Новая запись успешно добавленна!");
            }
        }
        public int GetDocumentNumber()
        {
            using (DBConnection db = new DBConnection())
            {
                List<ContractsTable> contracts = db.ContractsTable.ToList();
                if (contracts.Count == 0)
                {
                    return 1;
                }
                else
                {
                    return ((contracts[(contracts.Count - 1)].ContractID));
                }
                
            }
        }

        public ContractsTable GetDataContract()
        {
            using (DBConnection db = new DBConnection())
            {
                ClientsTable client = db.ClientsTable.Where(x => x.ClientID == Program.CurrentClietnPersonalAcc).FirstOrDefault();
                int ContractID = client.ContractID;
                ContractsTable contract = db.ContractsTable.Where(x => x.ContractID == ContractID).FirstOrDefault();
                return contract;
            }
        }

        public ClientsTable GetClientInfo()
        {
            using (DBConnection db = new DBConnection())
            {
                ClientsTable client = db.ClientsTable.Where(x => x.ClientID == Program.CurrentClietnPersonalAcc).FirstOrDefault();
                return client;
            }
        }

        public ClientsTable GetClientInfoByID(int clientID)
        {
            using (DBConnection db = new DBConnection())
            {
                ClientsTable client = db.ClientsTable.Where(x => x.ClientID == clientID).FirstOrDefault();
                return client;
            }
        }

        public ServicesTable GetServiceInfo(int ServiceID)
        {
            using (DBConnection db = new DBConnection())
            {
                ServicesTable services = db.ServicesTable.Where(x => x.ServiceID == ServiceID).FirstOrDefault();
                return services;
            }
        }
        public int GetLastOrderID()
        {
            using (DBConnection db = new DBConnection())
            {
                List<OrdersTable> orders = db.OrdersTable.ToList();
                if (orders.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return ((orders[(orders.Count - 1)].OrderID));
                }

            }
        }
        
        public OrdersTable GetOrderByID(int OrderID)
        {
            using (DBConnection db = new DBConnection())
            {
                OrdersTable order = db.OrdersTable.Where(x => x.OrderID == OrderID).FirstOrDefault();
                return order;
            }
        }

        public ServicesTable GetServiceByID(int ServiceID)
        {
            using (DBConnection db = new DBConnection())
            {
                ServicesTable service = db.ServicesTable.Where(x => x.ServiceID == ServiceID).FirstOrDefault();
                return service;

            }
        }

        public List<AnalyzesTable> GetAllAnalyzesFromCurrentServices(int ServiceID)
        {
            using (DBConnection db = new DBConnection())
            {
                List<AnalyzesTable> analyzesTables = new List<AnalyzesTable>();
                List<ServicesAnalyzesTable> servicesAnalyzes = db.ServicesAnalyzesTable.Where(x => x.IDService == ServiceID).ToList();
                if (servicesAnalyzes !=null)
                {
                    foreach (var item in servicesAnalyzes)
                    {
                        int AnalyzeID = item.IDAnalyze;
                        AnalyzesTable analyzesTable = db.AnalyzesTable.Where(x => x.AnalyzeID == AnalyzeID).FirstOrDefault();
                        if (analyzesTable != null)
                        {
                            analyzesTables.Add(analyzesTable);
                        }
                    }
                }
                return analyzesTables;
            }
        }

        public List<ResultsTable> GetResultsByResultID(int ResultID)
        {
            using (DBConnection db = new DBConnection())
            {
                List<ResultsTable> results = db.ResultsTable.Where(x => x.ResultID == ResultID).ToList();
                return results;
            }
        }
        public int GetLastResultID(int orderID)
        {
            using (DBConnection db = new DBConnection())
            {
                OrdersTable order = new OrdersTable();
                ResultsTable result = new ResultsTable();
                List<ResultsTable> Lresunt = new List<ResultsTable>();

                // Если в Orders Запись результатов присутствует(ResID)?
                order = db.OrdersTable.Where(x => x.OrderID == orderID).FirstOrDefault();

                //Если Присутствуют
                if (order.ResultID != null)
                {
                    int ResultID = (int)order.ResultID;
                    return (ResultID - 1);
                }
                //Если Отсутствуют
                else
                {
                    Lresunt = db.ResultsTable.ToList();
                    //Если Это НЕ первая запись в таблицу резуьтатов
                    if (Lresunt.Count != 0)
                    {
                        return (Lresunt.Count - 1);
                    }
                    //Если Это Первая запись в таблицу резуьтатов
                    else
                    {
                        return 0;
                    }
                }

            }
        }

        public List<AnalyzesTable> GetAllAnalyzes()
        {
            using (DBConnection db = new DBConnection())
            {
                List<AnalyzesTable> analyzes = db.AnalyzesTable.ToList();
                return analyzes;
            }
        }

        public AnalyzesTable GetAnalyzeByID(int AnalyzeID)
        {
            using (DBConnection db = new DBConnection())
            {
                AnalyzesTable analyzes = db.AnalyzesTable.Where(x => x.AnalyzeID == AnalyzeID).FirstOrDefault();
                return analyzes;
            }
        }
        public ClientsTable GetClientInfoFromOrderID(int orderID)
        {
            using (DBConnection db = new DBConnection())
            {
                OrdersTable order = db.OrdersTable.Where(x => x.OrderID == orderID).FirstOrDefault();
                ClientsTable Client = GetClientInfoByID(order.ClientID);
                return Client;
            }
        }

        public void OpenResultDocument(int OrderID)
        {

        }

        public List<OrdersTable> GetAllOrdersFromClientsID()
        {
            using (DBConnection db = new DBConnection())
            {
                List<OrdersTable> orders = db.OrdersTable.Where(x => x.ClientID == Program.CurrentClietnPersonalAcc).ToList();
                return orders; 
            }
        }

        public ResultsTable GetResultById(int ResultID)
        {
            using (DBConnection db = new DBConnection())
            {
                ResultsTable result = db.ResultsTable.Where(x => x.ResultID == ResultID).FirstOrDefault();
                return result;
            }
        }

        public string GetResultFilePathByOrderID(int orderID)
        {
            using (DBConnection db = new DBConnection())
            {
                OrdersTable order = db.OrdersTable.Where(x => x.OrderID == orderID).FirstOrDefault();
                int ResultId = (int)order.ResultID;
                ResultsTable result = db.ResultsTable.Where(x => x.ResultID == ResultId).FirstOrDefault();
                return result.ResultFileName;
            }
        }

        public List<ServicesTable> ShowAvailableALLServices()
        {
            using (DBConnection db = new DBConnection())
            {
                List<ServicesTable> service = db.ServicesTable.ToList();
                return service;
            }
        }       
        public List<ServicesTable> ShowAvailablePersonalServices()
        {
            using (DBConnection db = new DBConnection())
            {
                List<ServicesTable> service = db.ServicesTable.Where(x=> x.Name == "Персональная услуга").ToList();
                return service;
            }
        }

        public List<UsersTable> GetUsersForAdmin(int SearchParam)
        {
            using (DBConnection db = new DBConnection())
            {
                RoleTable role = db.RoleTable.Where(x => x.Name == "Administrator").FirstOrDefault();
                int AdministratorRole = role.RoleID;
                List<UsersTable> users = new List<UsersTable>();
                List<UsersTable> usersToReturnActive = new List<UsersTable>();
                List<UsersTable> usersToReturnDisabled = new List<UsersTable>();
                RoleTable Role = new RoleTable();
                PermissionTable permission = new PermissionTable();

                users = db.UsersTable.Where(x => x.RoleID != AdministratorRole).ToList();
                foreach (var item in users)
                {
                    string UserLogin = item.Login;
                    int RoleUserID = item.RoleID;
                    Role = db.RoleTable.Where(x => x.RoleID == RoleUserID).FirstOrDefault();
                    int PermissionID = Role.PermissionID;
                    permission = db.PermissionTable.Where(x => x.PermissionID == PermissionID).FirstOrDefault();
                    int PermissionCode = permission.PermissionCode;
                    if (PermissionCode == 115576)
                    {
                        usersToReturnDisabled.Add(item);
                    }
                    else if (PermissionCode == 459518)
                    {
                        usersToReturnActive.Add(item);
                    }

                }

                if (SearchParam == 0)
                {
                    return usersToReturnActive;
                }
                else if (SearchParam == 1)
                {
                    return usersToReturnDisabled;
                }
                else if (SearchParam == 2)
                {

                    return users;
                }
                else
                {
                    return users;
                }
                
            }
        }

        public List<RoleTable> AdminGetAllRoles()
        {
            using (DBConnection db = new DBConnection())
            {
                List<RoleTable> roles = db.RoleTable.Where(x=> x.Name != "Administrator").ToList();
                return roles;
            }
        }

        public string GetUserPermissionById(int UserID)
        {
            using (DBConnection db = new DBConnection())
            {
                UsersTable user = db.UsersTable.Where(x=> x.UserID == UserID).FirstOrDefault();
                int RoleId = user.RoleID;
                RoleTable role = db.RoleTable.Where(x => x.RoleID == RoleId).FirstOrDefault();
                int permissionID = role.PermissionID;
                PermissionTable permission = db.PermissionTable.Where(x => x.PermissionID == permissionID).FirstOrDefault();
                return permission.Name;
            }
        }

        public string GetRolePermissionById(int RoleID)
        {
            using (DBConnection db = new DBConnection())
            {
                RoleTable role = db.RoleTable.Where(x => x.RoleID == RoleID).FirstOrDefault();
                int permissionID = role.PermissionID;
                PermissionTable permission = db.PermissionTable.Where(x => x.PermissionID == permissionID).FirstOrDefault();
                return permission.Name;
            }
        }
        public List<ServicesTable> SearchServices(string ServiceName)
        {
            using (DBConnection db = new DBConnection())
            {
                List<ServicesTable> services = db.ServicesTable.Where(x => x.Name == ServiceName & x.Aviability == true).ToList();
                return services;
            }
        }

        


    }
}

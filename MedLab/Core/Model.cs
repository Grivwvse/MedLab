using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProgramm.Core
{
    public class Model
    {
        public void UpdateClientInfo(int id, string Name, string Surname, string Patronymic, DateTime DateOfbirth, string Phone, string Email, string Pasport)
        {
            using (DBConnection db = new DBConnection())
            {
                ClientsTable client = db.ClientsTable.FirstOrDefault(x => x.ClientID == id);
                client.Name = Name;
                client.Surname = Surname;
                client.Patronymic = Patronymic;
                client.DateOfBirth = DateOfbirth;
                client.Phone = Phone;
                client.Email = Email;
                client.Passport = Pasport;
                db.SaveChanges();
            }
        }
        public void CreateClient(string Name, string Surname, string Patronymic, DateTime DateOfBirth, string Phone, string Email, string Passport, int DocumentNumber)
        {
            
            using (DBConnection db = new DBConnection())
            {
                List<ContractsTable> contracts = db.ContractsTable.ToList();
                int ContractID = contracts[contracts.Count -1].ContractID;
                ContractsTable contract = db.ContractsTable.Where(x => x.ContractID == ContractID).FirstOrDefault();
                if (contract.ContractID == DocumentNumber)
                {
                    ClientsTable client = new ClientsTable();
                    client.Name = Name;
                    client.Surname = Surname;
                    client.Patronymic = Patronymic;
                    client.DateOfBirth = DateOfBirth;
                    client.Phone = Phone;
                    client.Email = Email;
                    client.ContractID = DocumentNumber;
                    client.Passport = Passport;
                    db.ClientsTable.Add(client);
                    db.SaveChanges();
                    MessageBox.Show("Клиент успешно добавлен!");
                }
                else
                {
                    MessageBox.Show("Произошла ошибка, повторите попытку позже!");
                }
            }
            
        }

        public void SaveContractData(string DateDogovor)
        {
            using (DBConnection db = new DBConnection())
            {
                DateTime date = Convert.ToDateTime(DateDogovor);
                ContractsTable contract = new ContractsTable();
                contract.ContractDate = date;
                contract.IsActive = true;
                db.ContractsTable.Add(contract);
                db.SaveChanges();
            }
        }

        public void SaveResults(int ResultID, string result, int AnalyzeID, int OrderID)
        {
            using (DBConnection db = new DBConnection())
            {
                ResultsTable results = new ResultsTable();
                ResultsTable Results = new ResultsTable();
                results = db.ResultsTable.Where(x => x.ResultID == ResultID & x.AnalyzeID == AnalyzeID).FirstOrDefault();
                if (results != null)
                {
                    ResultsTable Result = db.ResultsTable.Where(x => x.ResultID == ResultID & x.AnalyzeID == AnalyzeID).FirstOrDefault();
                    Result.Result = result;
                    db.SaveChanges();
                }
                else
                {
                    Results.ResultID = ResultID;
                    Results.Result = result;
                    Results.AnalyzeID = AnalyzeID;
                    Results.CreationDate = DateTime.Now;
                    db.ResultsTable.Add(Results);
                    db.SaveChanges();

                    OrdersTable order = db.OrdersTable.Where(x => x.OrderID == OrderID).FirstOrDefault();
                    order.ResultID = ResultID;
                    db.SaveChanges();
                }

            }
        }

        public int CreateNewService(List<AnalyzesTable> analyzes, ServicesTable services)
        {
            List<ServicesTable> Lservices = new List<ServicesTable>();
            ServicesTable Serv = services;

            ServicesAnalyzesTable servicesAnalyzes = new ServicesAnalyzesTable();

            using (DBConnection db = new DBConnection())
            {
                
                db.ServicesTable.Add(Serv);
                db.SaveChanges();

                Lservices = db.ServicesTable.ToList();
                int ServiceId = Lservices[Lservices.Count -1].ServiceID ;
                for (int i = 0; i < analyzes.Count; i++)
                {
                    
                    servicesAnalyzes.IDAnalyze = analyzes[i].AnalyzeID;
                    servicesAnalyzes.IDService = ServiceId;
                    xuyeputala(servicesAnalyzes);
                }
                return ServiceId;

            }
        }
        public void xuyeputala(ServicesAnalyzesTable servicesAnalyzes)
        {
            using (DBConnection db = new DBConnection())
            {
                db.ServicesAnalyzesTable.Add(servicesAnalyzes);
                db.SaveChanges();
            }

        }

        public void SavseResultsFileNameToDB(int ResultID, string fileName)
        {
            using (DBConnection db = new DBConnection())
            {
                ResultsTable result = db.ResultsTable.Where(x => x.ResultID == ResultID).FirstOrDefault();
                result.ResultFileName = $"{fileName}";
                db.SaveChanges();
            }
        }

        public void CreateNewAnalyze(string Name, string NormValue, int Cost)
        {
            using (DBConnection db = new DBConnection())
            {
                AnalyzesTable analyze = new AnalyzesTable();
                analyze.Name = Name;
                analyze.NormValue = NormValue;
                analyze.Cost = Cost;
                db.AnalyzesTable.Add(analyze);
                db.SaveChanges();
            }
        }

        public bool HideServiceByServiceID(int ServiceID)
        {
            using (DBConnection db = new DBConnection())
            {
                
                ServicesTable service = db.ServicesTable.Where(x => x.ServiceID == ServiceID).FirstOrDefault();
                service.Aviability = false;
                db.SaveChanges();
                return true;
            }
        }

        public bool DelUserById(int UserId)
        {
            using (DBConnection db = new DBConnection())
            {
                UsersTable user = db.UsersTable.Where(x => x.UserID == UserId).FirstOrDefault();
                if (user != null)
                {
                    db.UsersTable.Remove(user);
                }
                db.SaveChanges();
                return true;
            }
        }

        public void CreateUser(UsersTable user)
        {
            using (DBConnection db = new DBConnection())
            {
                db.UsersTable.Add(user);
                db.SaveChanges();
            }
        }

        public void ChangePermissionToRoleByRoleID(int RoleID, string PermissionName)
        {
            using (DBConnection db = new DBConnection())
            {
                PermissionTable permission = db.PermissionTable.Where(x => x.Name == PermissionName).FirstOrDefault();
                int permissionidNew = permission.PermissionID;
                RoleTable role = db.RoleTable.Where(x => x.RoleID == RoleID).FirstOrDefault();
                role.PermissionID = permissionidNew;
                db.SaveChanges();
                
            }
        }

        public void ChangePermissionToUserByUserID(int UserID, string PermissionName)
        {
            using (DBConnection db = new DBConnection())
            {
                PermissionTable permission = db.PermissionTable.Where(x => x.Name == PermissionName).FirstOrDefault();
                int permissionidNew = permission.PermissionID;
                RoleTable role = db.RoleTable.Where(x => x.PermissionID == permissionidNew).FirstOrDefault();
                UsersTable users = db.UsersTable.Where(x => x.UserID == UserID).FirstOrDefault();
                if (PermissionName == "Default")
                {
                    if (users.PreviousRoleID != null)
                    {
                        users.RoleID = (int)users.PreviousRoleID;
                        users.PreviousRoleID = null;
                    }
                }
                else if (PermissionName == "NoAccess")
                {
                    if (users.PreviousRoleID == null)
                    {
                        users.PreviousRoleID = users.RoleID;
                        users.RoleID = role.RoleID;
                    }
                }
                
                db.SaveChanges();
            }
        }



    }
}
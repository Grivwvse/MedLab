using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProgramm.ClassesDV
{
    public class TimeTableReception
    {
        public DateTime DateComeIn { get; set; }
        //public int OrderID { get; set; }
        //public int ClientID { get; set; }
        public int OrderID { get; set; }
        public string ServiceName { get; set; }
        public string ClientFIO { get; set; }
        public DateTime CreationDate { get; set; }
        public string Result { get; set; }

        public TimeTableReception(DateTime DateComeIn, int OrderID, string ServiceName, string ClientFIO, DateTime CreationDate, string Result)
        {
            this.DateComeIn = DateComeIn;
            this.OrderID = OrderID;
            this.ServiceName = ServiceName;
            this.ClientFIO = ClientFIO;
            this.CreationDate = CreationDate;
            this.Result = Result;
        }

    }
}

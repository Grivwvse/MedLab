using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProgramm.ClassesDV
{
    public class LAAnalayzesResults
    {
        public int AnalyzeID { get; set; }
        public string AnalyzeName { get; set; }
        public string Result { get; set; }
        public string NormValue { get; set; }

        public LAAnalayzesResults(int AnalyzeID, string AnalyzeName, string Result, string NormValue)
        {
            this.AnalyzeID = AnalyzeID;
            this.AnalyzeName = AnalyzeName;
            this.Result = Result;
            this.NormValue = NormValue;
        }
    }
}

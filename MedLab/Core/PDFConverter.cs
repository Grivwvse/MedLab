using System;
using Spire.Doc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Doc.Documents;

namespace DiplomProgramm.Core
{
    public  class PDFConverter
    {
        public void Convert(string FilePath)
        {
            Document document = new Document();
            document.LoadFromFile($@"{FilePath}");

            string[] words = FilePath.Split('.');
            //Convert Word to PDF
            document.SaveToFile($"{words[0]}.PDF", FileFormat.PDF);

            //Launch Document
            //System.Diagnostics.Process.Start("toPDF.PDF");
        }
    }
}

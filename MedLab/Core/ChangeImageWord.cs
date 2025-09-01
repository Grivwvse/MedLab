using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using Word = Microsoft.Office.Interop.Word;

namespace DiplomProgramm.Core
{
    class ChangeImageWord
    {
        #region Constructor
        public ChangeImageWord(string DocPath, int DataToEncode)
        {
            WordApp = new Microsoft.Office.Interop.Word.Application();
            filename = $@"{DocPath}";
            CodeImageName = $"{DocPath}";
            DataToEncodeStr = Convert.ToString(DataToEncode);
        }
        #endregion

        #region Fields
        private string DataToEncodeStr = "";
        private Word.Application WordApp;
        private object missing = System.Reflection.Missing.Value;
        private object yes = true;
        private object no = false;
        private Word.Document d;
        private object filename;
        private string CodeImageName = "";
        #endregion

        #region Methods
        public void UpdateDoc()
        {
            BarcodeWriter writer = new BarcodeWriter { Format = BarcodeFormat.CODE_128};
            Image CodeImage = writer.Write($"{DataToEncodeStr}");

            string[] spearator = CodeImageName.Split('.');
            string FName = spearator[0];

            string ImageFullName = ($@"{FName}.png");


            CodeImage.Save($@"{ImageFullName}");

            d = WordApp.Documents.Open(ref filename, ref missing, ref no, ref missing,
               ref missing, ref missing, ref missing, ref missing, ref missing,
               ref missing, ref missing, ref yes, ref missing, ref missing, ref missing, ref missing);
            List<Word.Range> ranges = new List<Microsoft.Office.Interop.Word.Range>();
            foreach (Word.InlineShape s in d.InlineShapes)
            {
                if (s.Type == Microsoft.Office.Interop.Word.WdInlineShapeType.wdInlineShapePicture)
                {
                    ranges.Add(s.Range);
                    s.Delete();
                }
            }
            foreach (Word.Range r in ranges)
            {
                r.InlineShapes.AddPicture($@"{ImageFullName}", ref missing, ref missing, ref missing);
            }
            WordApp.Quit(ref yes, ref missing, ref missing);
        }
        #endregion
    }
}

using DiplomProgramm.UI.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using SautinSoft.Document;
using DiplomProgramm.ClassesDV;
using DiplomProgramm.Core;
using Microsoft.Office.Interop.Word;

namespace DiplomProgramm.Core
{
    class WordHelper
    {
        private FileInfo _fileInfo;

        public  WordHelper(string fileName)
        {
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("File not Found");
            }
        }

        internal string Process(Dictionary<string, string> items)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);
                }

                Object newFileName = Path.Combine(("C:/ДокументыДиплом"), DateTime.Now.ToString("yyyMMddHHmmss") + _fileInfo.Name);
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();

                //ShowDocumentPathDialog showDocumentPathDialog = new ShowDocumentPathDialog();
                //showDocumentPathDialog.Show();
                //showDocumentPathDialog.FillTxtBox($"{newFileName}");

                return $"{newFileName}";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return "Error";
            }
            finally
            {
                if (app != null)
                {
                    app.Quit();
                }
            }


        }

        public string ExportResultsToWord(DataGridView DGV, string pathFile, Dictionary<string, string> items)
        {
            int DGVROWSCOUNT = DGV.Rows.Count;
            DataGridView dataTable = new DataGridView();
            dataTable = DGV;
            //dataTable.Rows.Insert(0, "one", "two", "three", "four");
            int dataTableRowsCount = dataTable.Rows.Count;


            // создаем и заполняем таблицу

            Word._Application wordApplication = new Word.Application();
            try
            {

            Word._Document wordDocument = null;
            wordApplication.Visible = false;

            Object defaultTableBehavior = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitWindow;
            Object missing = Type.Missing;
            var templatePathObj = pathFile;

            try
            {
                wordDocument = wordApplication.Documents.Add(templatePathObj);
            }
            catch (Exception )
            {
                if (wordDocument != null)
                {
                    wordDocument.Close(false);
                    wordDocument = null;
                }
                wordApplication.Quit();
                wordApplication = null;
                throw;
            }

           

            foreach (var item in items)
            {
                Word.Find find = wordApplication.Selection.Find;
                find.Text = item.Key;
                find.Replacement.Text = item.Value;

                Object wrap = Word.WdFindWrap.wdFindContinue;
                Object replace = Word.WdReplace.wdReplaceAll;

                find.Execute(FindText: Type.Missing,
                    MatchCase: false,
                    MatchWholeWord: false,
                    MatchWildcards: false,
                    MatchSoundsLike: missing,
                    MatchAllWordForms: false,
                    Forward: true,
                    Wrap: wrap,
                    Format: false,
                    ReplaceWith: missing, Replace: replace);
            }

            wordApplication.Selection.Find.Execute("<TableResult>");
            Word.Range wordRange = wordApplication.Selection.Range;

            var wordTable = wordDocument.Tables.Add(wordRange,
                dataTable.Rows.Count, dataTable.Columns.Count, ref defaultTableBehavior, ref autoFitBehavior);



            for (var j = 0; j < dataTable.Rows.Count; j++)
            {
                for (var k = 0; k < dataTable.Columns.Count; k++)
                {
                    wordTable.Cell(j + 1, k + 1).Range.Text = dataTable.Rows[j].Cells[k].Value.ToString();// .Cells[k].Value.ToString();
                }
            }

            //header row style
            wordDocument.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
            wordDocument.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
            wordDocument.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;



            //add header row manually
            for (int c = 0; c <= dataTable.Columns.Count - 1; c++)
            {
                wordDocument.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dataTable.Columns[c].HeaderText;
            }

            //Меняем стили созданных таблиц
            Object style = "Классическая таблица 1";
            wordTable.set_Style(ref style);
            style = "Список-таблица 1 светлая";
            Object applystyle = true;
            wordTable.set_Style(ref style);
            wordTable.ApplyStyleFirstColumn = false;
            wordTable.ApplyStyleHeadingRows = true;
            wordTable.ApplyStyleLastRow = true;
            wordTable.ApplyStyleLastColumn = false;
            //save the file



            Object newFileName = Path.Combine(("C:/ДокументыДиплом"), DateTime.Now.ToString("yyyMMddHHmmss") + "Results.docx");
            wordDocument.SaveAs2(newFileName);
            wordDocument.Close();
            PDFConverter pDFConverter = new PDFConverter();
            pDFConverter.Convert((string)newFileName);
            return (string)newFileName;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                wordApplication.Quit();
            }
        }

    }
}

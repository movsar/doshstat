using BrightIdeasSoftware;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFrequencies
{
    public class Utils
    {
        public static string WorkDirPath;
        // Tab History
        public static List<xTextFile> history;

        List<string> all_files; // For search files method
        public static List<xTextFile> fList; // Hold the files
        private static string appName = "wFrequencies";
        private static string separator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;

        public static void Exporter(ObjectListView olv, string filepath)
        {
            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.
                Create(filepath, SpreadsheetDocumentType.Workbook);

            // Add a WorkbookPart to the document.
            WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            Worksheet worksheet = new Worksheet();
            SheetData sheetData = new SheetData();
            
            // Add Sheets to the Workbook.
            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.
                AppendChild<Sheets>(new Sheets());

            // Append a new worksheet and associate it with the workbook.
            Sheet sheet = new Sheet() {
                Id = spreadsheetDocument.WorkbookPart.
                GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "mySheet"
            };
            sheets.Append(sheet);


            Row row = new Row();

            Cell cell = new Cell() {
                CellReference = "A1",
                DataType = CellValues.String,
                CellValue = new CellValue("Cell1")
            };

            Cell cell2 = new Cell() {
                CellReference = "B1",
                DataType = CellValues.String,
                CellValue = new CellValue("Cell2")
            };
            row.Append(cell);
            row.Append(cell2);

            sheetData.Append(row);
            worksheet.Append(sheetData);

            worksheetPart.Worksheet = worksheet;
            workbookpart.Workbook.Save();

            // Close the document.
            spreadsheetDocument.Close();
        }


        public static void StgSet(string name, int value)
        {
            Properties.Settings.Default[name] = value;
            Properties.Settings.Default.Save();
        }
        public static void StgSet(string name, string value)
        {
            Properties.Settings.Default[name] = value;
            Properties.Settings.Default.Save();
        }

        public static int StgGetInt(string name)
        {
            return Convert.ToInt32(Properties.Settings.Default[name]);
        }
        public static string StgGetString(string name)
        {
            return Convert.ToString(Properties.Settings.Default[name]);
        }

        public static DialogResult msgQuestion(String txt)
        {
            return MessageBox.Show(txt, appName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
        public static DialogResult msgConfirmation(String txt)
        {
            return MessageBox.Show(txt, appName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }
        public static DialogResult msgCriticalError(String txt)
        {
            return MessageBox.Show(txt, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult msgExclamation(String txt)
        {
            return MessageBox.Show(txt, appName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void msgAccessDenied()
        {
            MessageBox.Show("У вас недостаточно привилегий", appName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void msgInformation(String txt)
        {
            MessageBox.Show(txt, appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static int GetColumnIndex(ListView lv, string colTitle)
        {
            foreach (ColumnHeader col in lv.Columns) {
                if (col.Text.ToLower().Equals(colTitle.ToLower())) {
                    return col.Index;
                }
            }
            return -1;
        }
        public static ListViewItem GetLVIByValue(ListView lv, string colTitle, string value)
        {
            int colIndex = GetColumnIndex(lv, colTitle);
            foreach (ListViewItem li in lv.Columns[colIndex].ListView.Items) {
                if (li.Text.ToLower().Equals(value.ToLower())) {
                    return li;
                }
            }
            return null;
        }
        public static ListViewItem GetLVIByValue(ListView lv, int colIndex, string value)
        {
            foreach (ListViewItem li in lv.Columns[colIndex].ListView.Items) {
                if (li.Text.ToLower().Equals(value.ToLower())) {
                    return li;
                }
            }
            return null;
        }



        public static void ErrLog(Exception ex)
        {
            using (StreamWriter sw = new StreamWriter("wfrequencies.log", true)) {
                sw.WriteLine(GetCurrentDateTime() + " : " + ex.Message);
                sw.WriteLine(ex.StackTrace.ToString());
                sw.WriteLine();
            }
        }
        public static void ErrLog(String caption, String msg)
        {
            using (StreamWriter sw = new StreamWriter("wfrequencies.log", true)) {
                sw.WriteLine(GetCurrentDateTime() + " : " + caption);
                sw.WriteLine(msg);
                sw.WriteLine();
            }
        }
        public static void Logging(String ex)
        {
            Debug.WriteLine("Internal String Error" + ex);
        }
        public static void Logging(string format, params object[] args)
        {
            Debug.WriteLine(format, args);
        }
        public static string GetCurrentDate()
        {
            return DateTime.Now.ToString("dd.MM.yyyy");
        }
        public static string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("dd.MM.yyyy hh:MM:ss");
        }
        public static void FullExcelExport(List<xTextFile> list, string defaultFileName)
        {
            StringBuilder sb = new StringBuilder();

            //Making columns!
            sb.Append("ID" + separator);
            sb.Append("Имя файла" + separator);
            sb.Append("Слово" + separator);
            sb.Append("Частота" + separator);
            sb.Append("Дата и Время" + separator);
            sb.AppendLine();

            //Looping through items and subitems
            foreach (xTextFile xtFile in list.Where(file => (file.isSelected))) {
                try {
                    foreach (xWordFrequencies xwf in xtFile.frequencies) {
                        sb.Append(xtFile.fileId + separator);
                        sb.Append(xtFile.fileName + separator);
                        sb.Append(xwf.word + separator);
                        sb.Append(xwf.frequency + separator);
                        sb.Append(xtFile.created_at);
                        sb.AppendLine();
                    }
                } catch (NullReferenceException nrex) {
                    ErrLog(nrex);
                }
            }


            SaveFileDialog saveFileDialog1 = new SaveFileDialog() {
                Filter = "CSV Format|*.csv",
                FileName = defaultFileName + ".csv",
                Title = "Экспорт ... "
            };
            DialogResult dResult = saveFileDialog1.ShowDialog();
            if (dResult == DialogResult.OK) {
                File.WriteAllText(saveFileDialog1.FileName, sb.ToString(), Encoding.UTF8);
                Process.Start(saveFileDialog1.FileName);
            }
        }

        public static void OlvToExcelExport(ObjectListView olv, string defaultFileName)
        {
            StringBuilder sb = new StringBuilder();

            //Making columns!
            foreach (ColumnHeader ch in olv.Columns) {
                sb.Append(ch.Text + separator);
            }

            sb.AppendLine();

            //Looping through items and subitems
            foreach (ListViewItem lvi in olv.Items) {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems) {
                    if (lvs.Text.Trim() == string.Empty)
                        sb.Append(" " + separator);
                    else
                        sb.Append(string.Format("\"{0}\"" + separator, lvs.Text));
                }
                sb.AppendLine();
            }


            SaveFileDialog saveFileDialog1 = new SaveFileDialog() {
                Filter = "CSV Format|*.csv",
                FileName = defaultFileName + ".csv",
                Title = "Экспорт ... "
            };
            DialogResult dResult = saveFileDialog1.ShowDialog();
            if (dResult == DialogResult.OK) {
                File.WriteAllText(saveFileDialog1.FileName, sb.ToString(), Encoding.UTF8);
                Process.Start(saveFileDialog1.FileName);
            }

        }
        public List<string> FindFilesRecursively(string filter)
        {
            all_files = new List<string>();

            // Get files from this dir
            foreach (string f in Directory.GetFiles(WorkDirPath, filter)) { all_files.Add(f); }

            // And from its children
            _findFilesRecursively(filter);
            return all_files;
        }
        private void _findFilesRecursively(string filter)
        {
            // Get files from this dir's children
            foreach (string d in Directory.GetDirectories(WorkDirPath)) {
                foreach (string f in Directory.GetFiles(d, filter)) {
                    all_files.Add(f);
                }
                _findFilesRecursively(filter);
            }
        }
    }
}

using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;

namespace wFrequencies
{
    public class Utils
    {
        public static string WorkDirPath;
        // Tab History
        public static List<xTextFile> history;
        public static List<xWordFrequencies> frequencies;

        List<string> all_files; // For search files method
        public static List<xTextFile> fList; // Hold the files
        private static string appName = "wFrequencies";
        private static string separator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;

        public static void ExcelExport(ObjectListView olv, string defaultName, bool withStyle)
        {
            SLDocument sl = new SLDocument();
            SLStyle style = sl.CreateStyle();

            for (int i = 1; i <= olv.Columns.Count; ++i) {
                sl.SetCellValue(1, i, olv.Columns[i - 1].Text);
            }

            for (int i = 1; i <= olv.Columns.Count; ++i) {
                for (int j = 1; j <= olv.Items.Count; ++j) {
                    string cellVal = olv.Items[j - 1].SubItems[i - 1].Text;

                    sl.SetCellValue(j + 1, i, cellVal);

                    if (withStyle) {
                        System.Drawing.Color backColor = olv.Items[j - 1].BackColor;
                        System.Drawing.Color foreColor = olv.Items[j - 1].ForeColor;
                        style.Fill.SetPattern(PatternValues.Solid, backColor, foreColor);
                        sl.SetCellStyle(j + 1, i, style);
                    }
                }
            }

            SLTable tbl = sl.CreateTable(1, 1, olv.Items.Count + 1, olv.Columns.Count);
            if (!withStyle) tbl.SetTableStyle(SLTableStyleTypeValues.Medium4);

            tbl.Sort(1, false);
            sl.InsertTable(tbl);


            SaveFileDialog saveFileDialog1 = new SaveFileDialog() {
                Filter = "XLS Format|*.xlsx",
                FileName = defaultName + " " + GetCurrentDate() + ".xlsx",
                Title = "Экспорт ... "
            };

            DialogResult dResult = saveFileDialog1.ShowDialog();
            if (dResult == DialogResult.OK) {
                sl.SaveAs(saveFileDialog1.FileName);
                Process.Start(saveFileDialog1.FileName);
            }
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

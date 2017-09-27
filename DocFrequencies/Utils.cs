using BrightIdeasSoftware;
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
        List<string> all_files; // For search files method
        public static List<xTextFile> fList; // Hold the files
        private static string appName = "wFrequencies";

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
            using (StreamWriter sw = new StreamWriter("wfrequencies.log", true))
            {
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
            sb.Append("ID файла" + ",");
            sb.Append("Имя файла" + ",");
            sb.Append("Слово" + ",");
            sb.Append("Частота" + ",");

            sb.AppendLine();

            //Looping through items and subitems
            foreach (xTextFile xtFile in list.Where(file => (file.isSelected))) {
                try {
                    foreach (xWordFrequencies xwf in xtFile.frequencies) {
                        sb.Append(xtFile.fileId + ",");
                        sb.Append(xtFile.fileName + ",");
                        sb.Append(xwf.word + ",");
                        sb.Append(xwf.frequency + ",");
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
        public static void ExcelExport(List<xTextFile> list, string defaultFileName)
        {
            StringBuilder sb = new StringBuilder();

            //Making columns!
            sb.Append("ID файла" + ",");
            sb.Append("Имя файла" + ",");
            sb.Append("Слово" + ",");
            sb.Append("Частота" + ",");

            sb.AppendLine();

            //Looping through items and subitems
            foreach (xTextFile xtFile in list.Where(file => (file.isSelected))) {
                sb.Append(xtFile.fileId + ",");
                sb.Append(xtFile.fileName + ",");
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
        public static void OlvToExcelExport(ObjectListView olv, string defaultFileName)
        {
            StringBuilder sb = new StringBuilder();

            //Making columns!
            foreach (ColumnHeader ch in olv.Columns) {
                sb.Append(ch.Text + ",");
            }

            sb.AppendLine();

            //Looping through items and subitems
            foreach (ListViewItem lvi in olv.Items) {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems) {
                    if (lvs.Text.Trim() == string.Empty)
                        sb.Append(" ,");
                    else
                        sb.Append(string.Format("\"{0}\",", lvs.Text));
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

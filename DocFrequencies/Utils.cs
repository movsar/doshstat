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

        public static void OlvToExcelExport(ObjectListView olv)
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
                Title = "Экспорт ... "
            };
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "") {
                File.WriteAllText(saveFileDialog1.FileName, sb.ToString(), Encoding.UTF8);
                Process.Start(saveFileDialog1.FileName);
            }

        }

        public static void fillTheFrequencies(xTextFile xFile)
        {
            string contents = xFile.Processor.GetAllText(xFile.filePath);
            Debug.WriteLine("characters count: " + contents.Length);
            xFile.frequencies = new List<xWordFrequencies>();
            var words = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

            var wordPattern = new Regex(@"\w+");
            xFile.wordsCount = 0;
            foreach (Match match in wordPattern.Matches(contents)) {
                xFile.wordsCount++;
                int currentCount = 0;
                words.TryGetValue(match.Value, out currentCount);
                currentCount++;
                words[match.Value] = currentCount;
            }

            //    xFile.wordsCount = wordPattern.Matches(contents).Count;
            Debug.WriteLine("words count: " + xFile.wordsCount);

            foreach (var row in words.OrderByDescending(pair => pair.Value)) {
                xWordFrequencies xwf = new xWordFrequencies();
                xwf.word = row.Key.ToLower();
                xwf.word = xwf.word.Substring(0, 1).ToUpper() + xwf.word.Substring(1);
                xwf.frequency = row.Value;
                xFile.frequencies.Add(xwf);
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

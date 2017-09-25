using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace wFrequencies
{
    public class Utils
    {
        public static string WorkDirPath;
        List<string> all_files; // For search files method


        public static List<xTextFile> fList; // Hold the files



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

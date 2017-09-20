using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFrequencies
{
    public class Utils
    {
        public static string WorkDirPath;
        List<string> all_files;

        public static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
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
            foreach (string d in Directory.GetDirectories(WorkDirPath))
            {
                foreach (string f in Directory.GetFiles(d, filter))
                {
                    all_files.Add(f);
                }
                _findFilesRecursively(filter);
            }
        }
    }
}

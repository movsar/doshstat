using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace wFrequencies
{
    public partial class frmMain : Form
    {
       

        public frmMain()
        {

            /*  ANNOTATION
             *  The software should be able to read pdf,doc,txt and odf
             *  The software should take all files in the input folder and read them one at a time
             *  The software should prepare lists of words with their frequencie
             *  The software should be awesome
             *  
             *  TODO:
             *  1.  Import doc, docx reader library
             *  2.  Import pdf reader library
             *  3.  Import odf reader library
             *  4.  Create functions for each supporting format
             *  5.  Create open file dialog to show the location of files
             *  6.  List the files filtering the extension
             *  7.  Take a file, read all of its contents
             *  8.  Scan through file and create a list of frequencies for each file
             *  9.  Sum-up the frequency files
             *  10. Voila!
            */

            InitializeComponent();
        }

        public void UpdateStatus(string status)
        {
            lblStatus.Text = status;
        }

        public void UpdateProgress(int ProgressPercentage)
        {

        }
        private void loadFiles()
        {
            Utils.fList = new List<xTextFile>();

            foreach (string file in Directory.EnumerateFiles(Utils.WorkDirPath, "*.*", SearchOption.AllDirectories)
            .Where(s => s.EndsWith(".doc") || s.EndsWith(".docx") || s.EndsWith(".odt") || s.EndsWith(".pdf") || s.EndsWith(".txt") || s.EndsWith(".xls") || s.EndsWith(".rtf") || s.EndsWith(".htm") || s.EndsWith(".html"))) {
                Utils.fList.Add(new xTextFile(file));
            }

            olvFiles.SetObjects(Utils.fList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utils.WorkDirPath = Environment.CurrentDirectory + "\\input\\";
            txtWorkingDir.Text = Utils.WorkDirPath;

            loadFiles();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Do not allow the user to create new files via the FolderBrowserDialog.
            fbWorkingDir.ShowNewFolderButton = false;
            fbWorkingDir.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = fbWorkingDir.ShowDialog();
            if (result == DialogResult.OK) {
                Utils.WorkDirPath = fbWorkingDir.SelectedPath;
                txtWorkingDir.Text = Utils.WorkDirPath;
                loadFiles();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtWorkingDir.Enabled = false;
            btnBrowse.Enabled = false;
            btnStart.Enabled = false;

            string everything = "";


           

            foreach (xTextFile xFile in Utils.fList) {
                everything += xFile.Processor.GetAllText();
            }

            var frequencies = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
            count(everything, frequencies);

            everything = "";

            lblStatus.Text = "Считаю частотность";
            Refresh();


            foreach (var frequencyRow in frequencies.OrderByDescending(pair => pair.Value)) {
                string word = frequencyRow.Key.ToLower();
                word = word.Substring(0, 1).ToUpper() + word.Substring(1);

                everything += word + spacer(30 - word.Length) + frequencyRow.Value + "\r\n";
            }

            File.WriteAllText("output.txt", everything, Encoding.UTF8);

            lblStatus.Text = "Работа выполнена";
            Process.Start("notepad", (new DirectoryInfo(Utils.WorkDirPath)).FullName + "\\..\\output.txt");

            lblInfo.Text = "Файл c результатами находится по адресу: " + (new DirectoryInfo(Utils.WorkDirPath)).Parent.FullName + "\\output.txt";
            Refresh();

            txtWorkingDir.Enabled = true;
            btnBrowse.Enabled = true;
            btnStart.Enabled = true;
        }

        private string spacer(int count)
        {
            string spaces = "";
            for (int i = 0; i < count; i++) spaces += " ";
            return spaces;
        }

        private void count(string content, Dictionary<string, int> words)
        {
            var wordPattern = new Regex(@"\w+");

            foreach (Match match in wordPattern.Matches(content)) {
                int currentCount = 0;
                words.TryGetValue(match.Value, out currentCount);

                currentCount++;
                words[match.Value] = currentCount;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

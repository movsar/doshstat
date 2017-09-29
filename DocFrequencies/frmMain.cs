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
using BrightIdeasSoftware;
using System.Collections;

namespace wFrequencies
{
    public partial class FrmMain : Form
    {
        private bool isRunning = false;

        public FrmMain()
        {

            /*  ANNOTATION
             *  The software should be able to read pdf,doc,txt and odf
             *  The software should take all files in the input folder and read them one at a time
             *  The software should prepare lists of words with their frequencie
             *  The software should be awesome
             *  
             *  TODO:
             *  1.v  Import doc, docx reader library
             *  2.v  Import pdf reader library
             *  3.v  Import odf reader library
             *  4.v  Create functions for each supporting format
             *  5.v  Create open file dialog to show the location of files
             *  6.v  List the files filtering the extension
             *  7.v  Take a file, read all of its contents
             *  8.v  Scan through file and create a list of frequencies for each file
             *  9.v  Sum-up the frequency files
             *  10.v  Percentage
             *  11.v  Percentage in export and in selection
             *  12.  Общая частотность
             *  13.  Окно со статистикой сразу после Начать
             *  14.  Статистика по слову
            */

            InitializeComponent();

            // Load settings
            if (Utils.StgGetString("WorkingDir") == "") {
                Utils.WorkDirPath = Environment.CurrentDirectory;
            } else {
                Utils.WorkDirPath = Utils.StgGetString("WorkingDir");
            }

            Utils.StgSet("TxtCodepage", Convert.ToInt32(Properties.Settings.Default["TxtCodepage"]));
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
            this.Enabled = false;

            lblStatus.Text = "Загружаю список файлов";
            // Load all supported files from the chosen dretory 
            this.Enabled = true;

            Utils.fList = new List<xTextFile>();
            try {
                foreach (string file in Directory.EnumerateFiles(Utils.WorkDirPath, "*.*", SearchOption.AllDirectories)
          .Where(s => s.EndsWith(".doc") || s.EndsWith(".docx") || s.EndsWith(".odt") || s.EndsWith(".pdf") || s.EndsWith(".txt") || s.EndsWith(".xlsx") || s.EndsWith(".rtf") || s.EndsWith(".htm") || s.EndsWith(".html"))) {
                    Utils.fList.Add(new xTextFile(file));
                }

                olvFiles.SetObjects(Utils.fList);
                lblStatus.Text = "Готов";
            } catch (UnauthorizedAccessException unaex) {
                Utils.msgCriticalError("Недостаточно прав для обработки данной директори, запустите программу с правами администратора, или выберите другую папку");
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CtrlHistory myCtrlHistory = new CtrlHistory();
            myCtrlHistory.Dock = DockStyle.Fill;


            tbpHistory.Controls.Add(myCtrlHistory);

            DirectoryInfo dInfo = new DirectoryInfo(Utils.WorkDirPath);
            if (!dInfo.Exists) dInfo.Create();
            txtWorkingDir.Text = Utils.WorkDirPath;
            DbHelper.SetConnection();
            DbHelper.createTables();

            olvFiles.SubItemChecking += delegate (object olvCheckSender, SubItemCheckingEventArgs olvCheckArgs) {
                // Set false all the other categories
                xTextFile rowObject = ((xTextFile)olvCheckArgs.RowObject);
                rowObject.isFiction = false;
                rowObject.isPoetry = false;
                rowObject.isScientific = false;
                rowObject.isSocPol = false;
                rowObject.isReligious = false;

                // After completion it will set the new value
            };



            loadFiles();
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Do not allow the user to create new files via the FolderBrowserDialog.
            fbWorkingDir.ShowNewFolderButton = false;
            fbWorkingDir.SelectedPath = txtWorkingDir.Text;

            DialogResult result = fbWorkingDir.ShowDialog();
            if (result == DialogResult.OK) {
                Utils.WorkDirPath = fbWorkingDir.SelectedPath;
                txtWorkingDir.Text = Utils.WorkDirPath;

                // Save to settings
                Utils.StgSet("WorkingDir", Utils.WorkDirPath);

                // Load files list
                loadFiles();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning) {
                txtWorkingDir.Enabled = false;
                btnBrowse.Enabled = false;
                isRunning = true;
                bgwCounter.RunWorkerAsync();
                btnStart.BackColor = Color.IndianRed;
                btnStart.Text = "Cтоп";
                prbStatus.Visible = true;
            } else {
                if (bgwCounter.IsBusy) bgwCounter.CancelAsync();
                lblStatus.Text = "Отмена"; Update();
                onFinishCounting();
            }
        }

        private string spacer(int count)
        {
            string spaces = "";
            for (int i = 0; i < count; i++) spaces += " ";
            return spaces;
        }

        private void removeSelectedFromOlvFiles()
        {
            foreach (xTextFile xtf in (olvFiles.SelectedObjects)) {
                Utils.fList.Remove(xtf);
            }

            olvFiles.SetObjects(Utils.fList);
        }

        private void ctxRemoveFromtheList_Click(object sender, EventArgs e)
        {
            removeSelectedFromOlvFiles();
        }



        private void tbcHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMain.SelectedTab == tbcMain.TabPages[1]) {
            } else {

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (olvFiles.SelectedObjects.Count == 0);
        }

        private void olvFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && olvFiles.SelectedObjects.Count > 0) {
                removeSelectedFromOlvFiles();
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void bgwCounter_DoWork(object sender, DoWorkEventArgs e)
        {

            foreach (xTextFile xFile in Utils.fList) {
                if (bgwCounter.CancellationPending) {
                    bgwCounter.ReportProgress(-1, xFile);
                    return;
                }
                bgwCounter.ReportProgress(-2, xFile);

                string contents = xFile.Processor.GetAllText(xFile.filePath);


                xFile.charactersCount = contents.Length;

                xFile.frequencies = new List<xWordFrequencies>();
                var words = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

                var wordPattern = new Regex(@"\w+");
                xFile.wordsCount = wordPattern.Matches(contents).Count;

                int progress = 0;
                foreach (Match match in wordPattern.Matches(contents)) {
                    if (bgwCounter.CancellationPending) {
                        bgwCounter.ReportProgress(-1, xFile);
                        return;
                    }
                    progress++;
                    int currentCount = 0;
                    words.TryGetValue(match.Value, out currentCount);
                    bgwCounter.ReportProgress(progress, xFile);
                    currentCount++;
                    words[match.Value] = currentCount;
                }

                // Add words to object's list of words with frequencies
                foreach (var row in words.OrderByDescending(pair => pair.Value)) {
                    xWordFrequencies xwf = new xWordFrequencies();
                    xwf.word = row.Key.ToLower();
                    xwf.word = xwf.word.Substring(0, 1).ToUpper() + xwf.word.Substring(1);
                    xwf.frequency = row.Value;
                    float freq = xwf.frequency;

                    // Why it doesn't work with xwf.frequency?
                    xwf.percentage = (freq / xFile.wordsCount) * 100;
                    xFile.frequencies.Add(xwf);
                }
                xFile.uniqueWordsCount = xFile.frequencies.Count();
                xFile.SaveFileInfo();

            }

            bgwCounter.ReportProgress(-3, null);
        }

        private void bgwCounter_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            xTextFile xFile = (xTextFile)e.UserState;

            if (e.ProgressPercentage == -1) {
                // Is cancelled
                lblStatus.Text = "Отменено пользователем";
            } else if (e.ProgressPercentage == -2) {
                // Still reading
                if (!lblStatus.Text.Equals("Читаю: " + xFile.fileName)) {
                    lblStatus.Text = "Читаю: " + xFile.fileName; Update();
                }
            } else if (e.ProgressPercentage == -3) {
                // Has finished
                onFinishCounting();
            } else {
                // Counting
                prbStatus.Maximum = xFile.wordsCount;
                prbStatus.Value = e.ProgressPercentage;
                if ((prbStatus.Maximum != prbStatus.Value) || prbStatus.Maximum == 0) {
                    if (prbStatus.Visible == false) prbStatus.Visible = true;
                    if (!lblStatus.Text.Equals("Обрабатываю: " + xFile.fileName)) { lblStatus.Text = "Обрабатываю: " + xFile.fileName; Update(); }
                } else {
                    // Current file has been finished, let's move to the next
                    prbStatus.Value = 0;
                    prbStatus.Visible = false;
                }
            }
        }

        private void onFinishCounting()
        {
            isRunning = false;
            btnStart.BackColor = Color.LightGreen;
            txtWorkingDir.Enabled = true;
            btnBrowse.Enabled = true;
            btnStart.Text = "Старт";
            prbStatus.Visible = false;
            lblStatus.Text = "Работа выполнена";
        }

        private void сброситьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utils.msgConfirmation("Это действие приведет к полной очистке всей БД приложения, вы уверены?") == DialogResult.Yes) {
                DbHelper.dropTables();
                loadFiles();
                lblStatus.Text = "База данных успешно очищена!";
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DocProcessor.Dispose();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataExporter.Export(olvFiles, "exported.xlsx");
            Process.Start("exported.xlsx");
        }
    }
}
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
using System.Reflection;

namespace DoshStat
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
             *  12.v  Общая частотность
             *  13.v  Add date from and date to, to SELECT for all history requests
             *  14.v  Окно со статистикой сразу после Начать
             *  15.v  Excel выгружать числа как числа а не текст!
             *  16.v  Статистика по слову
             *  17.   Import DB             
             *  18.   Read line by line
             *  19.   Embed a log
             */

            InitializeComponent();

            // Load settings
            if (Utils.StgGetString("WorkingDir") == "")
            {
                Utils.WorkDirPath = Environment.CurrentDirectory;
            }
            else
            {
                Utils.WorkDirPath = Utils.StgGetString("WorkingDir");
            }

            Utils.StgSet("TxtCodepage", Convert.ToInt32(Properties.Settings.Default["TxtCodepage"]));
            chkSubdirectories.Checked = Utils.StgGetBool("ChkSubdirectories");
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
            try
            {
                foreach (string file in Directory.EnumerateFiles(Utils.WorkDirPath, "*.*", (chkSubdirectories.Checked) ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
          .Where(s => s.EndsWith(".doc") || s.EndsWith(".docx") || s.EndsWith(".odt") || s.EndsWith(".pdf") || s.EndsWith(".txt") || s.EndsWith(".xlsx") || s.EndsWith(".rtf") || s.EndsWith(".htm") || s.EndsWith(".html")))
                {
                    Utils.fList.Add(new xTextFile(file));
                }

                olvFiles.SetObjects(Utils.fList);
                lblStatus.Text = "Готов";
            }
            catch (UnauthorizedAccessException unaex)
            {
                Utils.ErrLog(unaex);

                var resources = new ComponentResourceManager(typeof(FrmMain));
                Utils.msgCriticalError(resources.GetString("NeedAdminPrivilegesError"));
                // "Недостаточно прав для обработки данной директори, запустите программу с правами администратора, или выберите другую папку");
            }

        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        CtrlHistory myCtrlHistory;
        CtrlWordAnalyzer myCtrlWordAnalyzer;
        // public static void setStatusMessage(string msg) // 

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "DoshStat ver." + AssemblyVersion;
            myCtrlHistory = new CtrlHistory();
            myCtrlHistory.Dock = DockStyle.Fill;
            tbpHistory.Controls.Add(myCtrlHistory);

            myCtrlWordAnalyzer = new CtrlWordAnalyzer();
            myCtrlWordAnalyzer.Dock = DockStyle.Fill;
            tbpSearch.Controls.Add(myCtrlWordAnalyzer);

            DirectoryInfo dInfo = new DirectoryInfo(Utils.WorkDirPath);
            if (!dInfo.Exists) dInfo.Create();
            txtWorkingDir.Text = Utils.WorkDirPath;
            DbHelper.SetConnection();
            DbHelper.createTables();

            olvFiles.SubItemChecking += delegate (object olvCheckSender, SubItemCheckingEventArgs olvCheckArgs)
            {
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
            // Refresh history list
            myCtrlHistory.loadHistory();

            olvFiles.PrimarySortColumn = olvFiles.GetColumn(0);
            olvFiles.PrimarySortOrder = SortOrder.Descending;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Do not allow the user to create new files via the FolderBrowserDialog.
            fbWorkingDir.ShowNewFolderButton = false;
            fbWorkingDir.SelectedPath = txtWorkingDir.Text;

            DialogResult result = fbWorkingDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                Utils.WorkDirPath = fbWorkingDir.SelectedPath;
                txtWorkingDir.Text = Utils.WorkDirPath;

                // Save to settings
                Utils.StgSet("WorkingDir", Utils.WorkDirPath);

                // Load files list
                loadFiles();
            }
        }
        Stopwatch watch;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                txtWorkingDir.Enabled = false;
                btnBrowse.Enabled = false;
                isRunning = true;
                bgwCounter.RunWorkerAsync();
                btnStart.BackColor = Color.IndianRed;
                btnStart.Text = "Cтоп";
                prbStatus.Visible = true;
                watch = Stopwatch.StartNew();
            }
            else
            {
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
            foreach (xTextFile xtf in (olvFiles.SelectedObjects))
            {
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
            if (tbcMain.SelectedTab == tbcMain.TabPages[1])
            {
            }
            else
            {

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ctxRemoveFromtheList.Enabled = (olvFiles.SelectedObjects.Count != 0);
        }

        private void olvFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && olvFiles.SelectedObjects.Count > 0)
            {
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

            foreach (xTextFile xFile in Utils.fList)
            {
                if (bgwCounter.CancellationPending)
                {
                    bgwCounter.ReportProgress(-1, xFile);
                    return;
                }
                bgwCounter.ReportProgress(-2, xFile);

                string contents = xFile.Processor.GetAllText(xFile.filePath);


                xFile.charactersCount = contents.Length;

                xFile.frequencies = new List<xWordFrequencies>();
                var words = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
                string stRegExp = Utils.StgGetString("TxtRegExp");
                var wordPattern = new Regex(stRegExp.Replace(@"\\", @"\").Trim());
                xFile.wordsCount = wordPattern.Matches(contents).Count;
                if (xFile.wordsCount == 0) continue;
                // Check if exists
                if (DbHelper.ifExists(xFile.charactersCount, xFile.wordsCount)) continue;

                int progress = 0;
                foreach (Match match in wordPattern.Matches(contents))
                {
                    if (bgwCounter.CancellationPending)
                    {
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
                int rank = 0;
                int prevFrequency = int.MaxValue;

                foreach (var row in words.OrderByDescending(pair => pair.Value))
                {
                    xWordFrequencies xwf = new xWordFrequencies();
                    xwf.word = row.Key.ToLower();
                    xwf.word = xwf.word.Substring(0, 1).ToUpper() + xwf.word.Substring(1);
                    xwf.frequency = row.Value;

                    if (rank != 1)
                    {
                        // It's not the first iteration
                        if (xwf.frequency != prevFrequency)
                        {
                            rank++;
                        }
                    }
                    else
                    {
                        rank++;
                    }

                    xwf.rank = rank;
                    prevFrequency = xwf.frequency;

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

            if (e.ProgressPercentage == -1)
            {
                // Is cancelled
                lblStatus.Text = "Отменено пользователем";
            }
            else if (e.ProgressPercentage == -2)
            {
                // Still reading
                if (!lblStatus.Text.Equals("Читаю: " + xFile.fileName))
                {
                    lblStatus.Text = "Читаю: " + xFile.fileName; Update();
                }
            }
            else if (e.ProgressPercentage == -3)
            {
                // Has finished
                onFinishCounting();
            }
            else
            {
                // Counting
                prbStatus.Maximum = xFile.wordsCount;
                prbStatus.Value = e.ProgressPercentage;
                if ((prbStatus.Maximum != prbStatus.Value) || prbStatus.Maximum == 0)
                {
                    if (prbStatus.Visible == false) prbStatus.Visible = true;
                    if (!lblStatus.Text.Equals("Обрабатываю: " + xFile.fileName)) { lblStatus.Text = "Обрабатываю: " + xFile.fileName; Update(); }
                }
                else
                {
                    // Current file has been finished, let's move to the next
                    prbStatus.Value = 0;
                    prbStatus.Visible = false;
                }
            }
        }

        private void onFinishCounting()
        {
            isRunning = false;
            // Пройденное время
            watch.Stop();


            btnStart.BackColor = Color.LightGreen;
            txtWorkingDir.Enabled = true;
            btnBrowse.Enabled = true;
            btnStart.Text = "Старт";
            prbStatus.Visible = false;
            lblStatus.Text = "Работа выполнена за " + watch.Elapsed.TotalSeconds.ToString("F") + "сек.";

            // Refresh history list
            myCtrlHistory.loadHistory();

            // Время сейчас
            DateTime dtTo = DateTime.Now;
            DateTime dtFrom = dtTo.Subtract(watch.Elapsed);

            Utils.history = DbHelper.GetHistory(dtFrom.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.ToString("yyyy-MM-dd HH:mm:ss"));
            if (Utils.history != null && Utils.StgGetBool("ShowResultsImmediately"))
            {
                FrmTotalDetails frmTotalDetails = new FrmTotalDetails();
                frmTotalDetails.Show();
            }
        }

        private void сброситьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utils.msgConfirmation("Это действие приведет к полной очистке всей БД приложения, вы уверены?") == DialogResult.Yes)
            {
                DbHelper.dropTables();
                lblStatus.Text = "База данных успешно очищена!";
                myCtrlHistory.clearHistory();
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

        private void экспортироватьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.ExcelExport(olvFiles, "Список файлов для обработки");
        }

        private void chkSubdirectories_CheckedChanged(object sender, EventArgs e)
        {
            Utils.StgSet("ChkSubdirectories", chkSubdirectories.Checked);
            loadFiles();
        }

        private void btnCleanUp_Click(object sender, EventArgs e)
        {
            DbHelper.Chistka();
        }

    }
}
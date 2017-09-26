﻿using System;
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


        public FrmMain()
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

            btnExport.Visible = false;
            btnFrequenciesToXML.Visible = false;
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
            // Convert doc to docx before we begin 
            DocProcessor.ConvertDocToDocx();
            // Load all supported files from the chosen dretory 
            this.Enabled = true;

            Utils.fList = new List<xTextFile>();

            foreach (string file in Directory.EnumerateFiles(Utils.WorkDirPath, "*.*", SearchOption.AllDirectories)
            .Where(s => s.EndsWith(".docx") || s.EndsWith(".odt") || s.EndsWith(".pdf") || s.EndsWith(".txt") || s.EndsWith(".xls") || s.EndsWith(".rtf") || s.EndsWith(".htm") || s.EndsWith(".html"))) {
                Utils.fList.Add(new xTextFile(file));
            }

            olvFiles.SetObjects(Utils.fList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utils.WorkDirPath = Environment.CurrentDirectory + "\\input\\";
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
            loadHistory();
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
                loadFiles();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtWorkingDir.Enabled = false;
            btnBrowse.Enabled = false;
            btnStart.Enabled = false;

            foreach (xTextFile xFile in Utils.fList) {
                Utils.processTheFile(xFile);

                xFile.uniqueWordsCount = xFile.frequencies.Count();
                xFile.SaveFileInfo();
                Debug.WriteLine("Ok");
            }

            //   File.WriteAllText("output.txt", everything, Encoding.UTF8);
            loadHistory();
            lblStatus.Text = "Работа выполнена";

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

        private void removeSelectedFromOlvFiles() {
            foreach (xTextFile xtf in (olvFiles.SelectedObjects)) {
                Utils.fList.Remove(xtf);
            }

            olvFiles.SetObjects(Utils.fList);
        }

        private void ctxRemoveFromtheList_Click(object sender, EventArgs e)
        {
            removeSelectedFromOlvFiles();
        }

        private void loadHistory() {
            history = DbHelper.GetHistory();
        }
        // Tab History
        List<xTextFile> history;
        private void tbcHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcHistory.SelectedTab == tbcHistory.TabPages[1]) {
                btnExport.Visible = true;
                btnFrequenciesToXML.Visible = true;
                // Tab History has been selected
            

                // Grouping by months=============================================
                OLVColumn clm = ((OLVColumn)olvHistory.Columns[5]);

                clm.GroupKeyGetter = delegate (object rowObject) {
                    xTextFile fm = (xTextFile)rowObject;
                    return fm.created_at.Substring(0, 10);
                };

                clm.GroupKeyToTitleConverter = delegate (object groupKey) {
                    DateTime dt = new DateTime();
                    dt = DateTime.ParseExact(groupKey.ToString(), "dd.MM.yyyy", null);
                    return groupKey.ToString();
                };
                //=================================================================

                // Set DateTime column as default for sorting to make it beautiful when it shows up for the first time!
                olvHistory.PrimarySortColumn = (olvHistory.GetColumn(5));
                olvHistory.SetObjects(history);

                olvHistory.SubItemChecking += delegate (object olvCheckSender, SubItemCheckingEventArgs olvCheckArgs) {
                    // Set false all the other categories
                    xTextFile rowObject = ((xTextFile)olvCheckArgs.RowObject);
                    rowObject.isSelected = !rowObject.isSelected;

                    // After completion it will set the new value
                };
            } else {
                btnExport.Visible = false;
                btnFrequenciesToXML.Visible = false;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (olvFiles.SelectedObjects.Count == 0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (tbcHistory.SelectedTab == tbcHistory.TabPages[0])
                loadFiles();
            else
                loadHistory();
        }

        private void olvHistory_DoubleClick(object sender, EventArgs e)
        {
            if (olvHistory.SelectedObject != null) {
                FrmFrequencies frmFreq = new FrmFrequencies((xTextFile)(olvHistory.SelectedObject));
                frmFreq.Show();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Utils.ExcelExport(history, "List Of Literature " + Utils.GetCurrentDate());
        }

        private void btnFrequenciesToXML_Click(object sender, EventArgs e)
        {
            Utils.FullExcelExport(history,"Full Export " + Utils.GetCurrentDate());
        }

        private void olvFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && olvFiles.SelectedObjects.Count>0 ) {
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
    }
}
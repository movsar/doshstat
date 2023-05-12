namespace DoshStat
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.fbWorkingDir = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxRemoveFromtheList = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортироватьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwCounter = new System.ComponentModel.BackgroundWorker();
            this.tbpHistory = new System.Windows.Forms.TabPage();
            this.tbpCount = new System.Windows.Forms.TabPage();
            this.chkSubdirectories = new System.Windows.Forms.CheckBox();
            this.olvFiles = new BrightIdeasSoftware.ObjectListView();
            this.olvClmFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFiction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmSocPol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmReligious = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPoetry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvScientific = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.txtWorkingDir = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fixCodepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tbpCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvFiles)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // fbWorkingDir
            // 
            resources.ApplyResources(this.fbWorkingDir, "fbWorkingDir");
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxRemoveFromtheList,
            this.экспортироватьСписокToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.myToolTip.SetToolTip(this.contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip"));
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ctxRemoveFromtheList
            // 
            resources.ApplyResources(this.ctxRemoveFromtheList, "ctxRemoveFromtheList");
            this.ctxRemoveFromtheList.Name = "ctxRemoveFromtheList";
            this.ctxRemoveFromtheList.Click += new System.EventHandler(this.ctxRemoveFromtheList_Click);
            // 
            // экспортироватьСписокToolStripMenuItem
            // 
            resources.ApplyResources(this.экспортироватьСписокToolStripMenuItem, "экспортироватьСписокToolStripMenuItem");
            this.экспортироватьСписокToolStripMenuItem.Name = "экспортироватьСписокToolStripMenuItem";
            this.экспортироватьСписокToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьСписокToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prbStatus,
            this.lblStatus});
            this.statusStrip1.Name = "statusStrip1";
            this.myToolTip.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // prbStatus
            // 
            resources.ApplyResources(this.prbStatus, "prbStatus");
            this.prbStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.prbStatus.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.prbStatus.Name = "prbStatus";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.языкToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.myToolTip.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // файлToolStripMenuItem
            // 
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            // 
            // закрытьToolStripMenuItem
            // 
            resources.ApplyResources(this.закрытьToolStripMenuItem, "закрытьToolStripMenuItem");
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            resources.ApplyResources(this.инструментыToolStripMenuItem, "инструментыToolStripMenuItem");
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixCodepageToolStripMenuItem,
            this.сброситьБДToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            // 
            // сброситьБДToolStripMenuItem
            // 
            resources.ApplyResources(this.сброситьБДToolStripMenuItem, "сброситьБДToolStripMenuItem");
            this.сброситьБДToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.сброситьБДToolStripMenuItem.Name = "сброситьБДToolStripMenuItem";
            this.сброситьБДToolStripMenuItem.Click += new System.EventHandler(this.сброситьБДToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            resources.ApplyResources(this.настройкиToolStripMenuItem, "настройкиToolStripMenuItem");
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // языкToolStripMenuItem
            // 
            resources.ApplyResources(this.языкToolStripMenuItem, "языкToolStripMenuItem");
            this.языкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem1,
            this.englishToolStripMenuItem1});
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            // 
            // русскийToolStripMenuItem1
            // 
            resources.ApplyResources(this.русскийToolStripMenuItem1, "русскийToolStripMenuItem1");
            this.русскийToolStripMenuItem1.Name = "русскийToolStripMenuItem1";
            this.русскийToolStripMenuItem1.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem1
            // 
            resources.ApplyResources(this.englishToolStripMenuItem1, "englishToolStripMenuItem1");
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            resources.ApplyResources(this.справкаToolStripMenuItem, "справкаToolStripMenuItem");
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            // 
            // оПрограммеToolStripMenuItem
            // 
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // bgwCounter
            // 
            this.bgwCounter.WorkerReportsProgress = true;
            this.bgwCounter.WorkerSupportsCancellation = true;
            this.bgwCounter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCounter_DoWork);
            this.bgwCounter.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCounter_ProgressChanged);
            // 
            // tbpHistory
            // 
            resources.ApplyResources(this.tbpHistory, "tbpHistory");
            this.tbpHistory.Name = "tbpHistory";
            this.myToolTip.SetToolTip(this.tbpHistory, resources.GetString("tbpHistory.ToolTip"));
            this.tbpHistory.UseVisualStyleBackColor = true;
            // 
            // tbpCount
            // 
            resources.ApplyResources(this.tbpCount, "tbpCount");
            this.tbpCount.Controls.Add(this.chkSubdirectories);
            this.tbpCount.Controls.Add(this.olvFiles);
            this.tbpCount.Controls.Add(this.txtWorkingDir);
            this.tbpCount.Controls.Add(this.lblInfo);
            this.tbpCount.Controls.Add(this.btnStart);
            this.tbpCount.Controls.Add(this.label1);
            this.tbpCount.Controls.Add(this.btnBrowse);
            this.tbpCount.Name = "tbpCount";
            this.myToolTip.SetToolTip(this.tbpCount, resources.GetString("tbpCount.ToolTip"));
            this.tbpCount.UseVisualStyleBackColor = true;
            // 
            // chkSubdirectories
            // 
            resources.ApplyResources(this.chkSubdirectories, "chkSubdirectories");
            this.chkSubdirectories.Checked = true;
            this.chkSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubdirectories.Name = "chkSubdirectories";
            this.myToolTip.SetToolTip(this.chkSubdirectories, resources.GetString("chkSubdirectories.ToolTip"));
            this.chkSubdirectories.UseVisualStyleBackColor = true;
            this.chkSubdirectories.CheckedChanged += new System.EventHandler(this.chkSubdirectories_CheckedChanged);
            // 
            // olvFiles
            // 
            resources.ApplyResources(this.olvFiles, "olvFiles");
            this.olvFiles.AllColumns.Add(this.olvClmFileName);
            this.olvFiles.AllColumns.Add(this.olvClmFiction);
            this.olvFiles.AllColumns.Add(this.olvClmSocPol);
            this.olvFiles.AllColumns.Add(this.olvClmReligious);
            this.olvFiles.AllColumns.Add(this.olvClmPoetry);
            this.olvFiles.AllColumns.Add(this.olvScientific);
            this.olvFiles.CellEditUseWholeCell = false;
            this.olvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmFileName,
            this.olvClmFiction,
            this.olvClmSocPol,
            this.olvClmReligious,
            this.olvClmPoetry,
            this.olvScientific});
            this.olvFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.olvFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFiles.FullRowSelect = true;
            this.olvFiles.GridLines = true;
            this.olvFiles.HideSelection = false;
            this.olvFiles.Name = "olvFiles";
            this.olvFiles.OverlayText.Text = resources.GetString("resource.Text");
            this.olvFiles.ShowGroups = false;
            this.myToolTip.SetToolTip(this.olvFiles, resources.GetString("olvFiles.ToolTip"));
            this.olvFiles.UseAlternatingBackColors = true;
            this.olvFiles.UseCompatibleStateImageBehavior = false;
            this.olvFiles.View = System.Windows.Forms.View.Details;
            this.olvFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.olvFiles_KeyUp);
            // 
            // olvClmFileName
            // 
            this.olvClmFileName.AspectName = "fileName";
            this.olvClmFileName.Groupable = false;
            resources.ApplyResources(this.olvClmFileName, "olvClmFileName");
            // 
            // olvClmFiction
            // 
            this.olvClmFiction.AspectName = "isFiction";
            this.olvClmFiction.CheckBoxes = true;
            this.olvClmFiction.Groupable = false;
            resources.ApplyResources(this.olvClmFiction, "olvClmFiction");
            this.olvClmFiction.Sortable = false;
            // 
            // olvClmSocPol
            // 
            this.olvClmSocPol.AspectName = "isSocPol";
            this.olvClmSocPol.CheckBoxes = true;
            this.olvClmSocPol.Groupable = false;
            resources.ApplyResources(this.olvClmSocPol, "olvClmSocPol");
            this.olvClmSocPol.Sortable = false;
            // 
            // olvClmReligious
            // 
            this.olvClmReligious.AspectName = "isReligious";
            this.olvClmReligious.CheckBoxes = true;
            this.olvClmReligious.Groupable = false;
            resources.ApplyResources(this.olvClmReligious, "olvClmReligious");
            this.olvClmReligious.Sortable = false;
            // 
            // olvClmPoetry
            // 
            this.olvClmPoetry.AspectName = "isPoetry";
            this.olvClmPoetry.CheckBoxes = true;
            this.olvClmPoetry.Groupable = false;
            resources.ApplyResources(this.olvClmPoetry, "olvClmPoetry");
            this.olvClmPoetry.Sortable = false;
            // 
            // olvScientific
            // 
            this.olvScientific.AspectName = "isScientific";
            this.olvScientific.CheckBoxes = true;
            this.olvScientific.Groupable = false;
            resources.ApplyResources(this.olvScientific, "olvScientific");
            this.olvScientific.Sortable = false;
            // 
            // txtWorkingDir
            // 
            resources.ApplyResources(this.txtWorkingDir, "txtWorkingDir");
            this.txtWorkingDir.Name = "txtWorkingDir";
            this.myToolTip.SetToolTip(this.txtWorkingDir, resources.GetString("txtWorkingDir.ToolTip"));
            // 
            // lblInfo
            // 
            resources.ApplyResources(this.lblInfo, "lblInfo");
            this.lblInfo.Name = "lblInfo";
            this.myToolTip.SetToolTip(this.lblInfo, resources.GetString("lblInfo.ToolTip"));
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Name = "btnStart";
            this.myToolTip.SetToolTip(this.btnStart, resources.GetString("btnStart.ToolTip"));
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.myToolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBrowse.Name = "btnBrowse";
            this.myToolTip.SetToolTip(this.btnBrowse, resources.GetString("btnBrowse.ToolTip"));
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbcMain
            // 
            resources.ApplyResources(this.tbcMain, "tbcMain");
            this.tbcMain.Controls.Add(this.tbpCount);
            this.tbcMain.Controls.Add(this.tbpHistory);
            this.tbcMain.Controls.Add(this.tbpSearch);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.myToolTip.SetToolTip(this.tbcMain, resources.GetString("tbcMain.ToolTip"));
            // 
            // tbpSearch
            // 
            resources.ApplyResources(this.tbpSearch, "tbpSearch");
            this.tbpSearch.Name = "tbpSearch";
            this.myToolTip.SetToolTip(this.tbpSearch, resources.GetString("tbpSearch.ToolTip"));
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // fixCodepageToolStripMenuItem
            // 
            resources.ApplyResources(this.fixCodepageToolStripMenuItem, "fixCodepageToolStripMenuItem");
            this.fixCodepageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fixCodepageToolStripMenuItem.Name = "fixCodepageToolStripMenuItem";
            this.fixCodepageToolStripMenuItem.Click += new System.EventHandler(this.fixCodepageToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbcMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.myToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbpCount.ResumeLayout(false);
            this.tbpCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvFiles)).EndInit();
            this.tbcMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog fbWorkingDir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxRemoveFromtheList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar prbStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgwCounter;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьСписокToolStripMenuItem;
        private System.Windows.Forms.TabPage tbpHistory;
        private System.Windows.Forms.TabPage tbpCount;
        private BrightIdeasSoftware.ObjectListView olvFiles;
        private BrightIdeasSoftware.OLVColumn olvClmFileName;
        private BrightIdeasSoftware.OLVColumn olvClmFiction;
        private BrightIdeasSoftware.OLVColumn olvClmSocPol;
        private BrightIdeasSoftware.OLVColumn olvClmReligious;
        private BrightIdeasSoftware.OLVColumn olvClmPoetry;
        private BrightIdeasSoftware.OLVColumn olvScientific;
        private System.Windows.Forms.TextBox txtWorkingDir;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpSearch;
        private System.Windows.Forms.CheckBox chkSubdirectories;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.ToolStripMenuItem языкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fixCodepageToolStripMenuItem;
    }
}


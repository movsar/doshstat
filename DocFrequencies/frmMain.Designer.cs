namespace wFrequencies
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
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwCounter = new System.ComponentModel.BackgroundWorker();
            this.tbpWordProcessor = new System.Windows.Forms.TabPage();
            this.tbpHistory = new System.Windows.Forms.TabPage();
            this.tbpCount = new System.Windows.Forms.TabPage();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtWorkingDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.olvFiles = new BrightIdeasSoftware.ObjectListView();
            this.olvClmFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFiction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmSocPol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmReligious = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPoetry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvScientific = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tbpCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvFiles)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxRemoveFromtheList,
            this.экспортироватьСписокToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ctxRemoveFromtheList
            // 
            this.ctxRemoveFromtheList.Name = "ctxRemoveFromtheList";
            this.ctxRemoveFromtheList.Size = new System.Drawing.Size(205, 22);
            this.ctxRemoveFromtheList.Text = "Удалить из списка";
            this.ctxRemoveFromtheList.Click += new System.EventHandler(this.ctxRemoveFromtheList_Click);
            // 
            // экспортироватьСписокToolStripMenuItem
            // 
            this.экспортироватьСписокToolStripMenuItem.Name = "экспортироватьСписокToolStripMenuItem";
            this.экспортироватьСписокToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.экспортироватьСписокToolStripMenuItem.Text = "Экспортировать список";
            this.экспортироватьСписокToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьСписокToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prbStatus,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(763, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prbStatus
            // 
            this.prbStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.prbStatus.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.prbStatus.Name = "prbStatus";
            this.prbStatus.Size = new System.Drawing.Size(200, 20);
            this.prbStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.lblStatus.Size = new System.Drawing.Size(250, 22);
            this.lblStatus.Text = "Готов";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сброситьБДToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // сброситьБДToolStripMenuItem
            // 
            this.сброситьБДToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.сброситьБДToolStripMenuItem.Name = "сброситьБДToolStripMenuItem";
            this.сброситьБДToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.сброситьБДToolStripMenuItem.Text = "Сброс БД";
            this.сброситьБДToolStripMenuItem.Click += new System.EventHandler(this.сброситьБДToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // bgwCounter
            // 
            this.bgwCounter.WorkerReportsProgress = true;
            this.bgwCounter.WorkerSupportsCancellation = true;
            this.bgwCounter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCounter_DoWork);
            this.bgwCounter.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCounter_ProgressChanged);
            // 
            // tbpWordProcessor
            // 
            this.tbpWordProcessor.Location = new System.Drawing.Point(4, 22);
            this.tbpWordProcessor.Name = "tbpWordProcessor";
            this.tbpWordProcessor.Size = new System.Drawing.Size(755, 449);
            this.tbpWordProcessor.TabIndex = 3;
            this.tbpWordProcessor.Text = "Анализ слова";
            this.tbpWordProcessor.ToolTipText = "Поиск по слову";
            this.tbpWordProcessor.UseVisualStyleBackColor = true;
            // 
            // tbpHistory
            // 
            this.tbpHistory.Location = new System.Drawing.Point(4, 22);
            this.tbpHistory.Name = "tbpHistory";
            this.tbpHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHistory.Size = new System.Drawing.Size(755, 449);
            this.tbpHistory.TabIndex = 1;
            this.tbpHistory.Text = "История";
            this.tbpHistory.UseVisualStyleBackColor = true;
            // 
            // tbpCount
            // 
            this.tbpCount.Controls.Add(this.olvFiles);
            this.tbpCount.Controls.Add(this.txtWorkingDir);
            this.tbpCount.Controls.Add(this.lblInfo);
            this.tbpCount.Controls.Add(this.btnStart);
            this.tbpCount.Controls.Add(this.label1);
            this.tbpCount.Controls.Add(this.btnBrowse);
            this.tbpCount.Location = new System.Drawing.Point(4, 22);
            this.tbpCount.Name = "tbpCount";
            this.tbpCount.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCount.Size = new System.Drawing.Size(755, 449);
            this.tbpCount.TabIndex = 0;
            this.tbpCount.Text = "Главная";
            this.tbpCount.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBrowse.Location = new System.Drawing.Point(678, 21);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 22);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Выбрать";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtWorkingDir
            // 
            this.txtWorkingDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingDir.Location = new System.Drawing.Point(2, 21);
            this.txtWorkingDir.Name = "txtWorkingDir";
            this.txtWorkingDir.Size = new System.Drawing.Size(672, 20);
            this.txtWorkingDir.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Папка с обрабатываемыми файлами";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Location = new System.Drawing.Point(678, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Location = new System.Drawing.Point(4, 46);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(665, 74);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Выберите папку с входными файлами\r\n *.doc, *.docx, *.pdf, *.txt, *.odt, *.xlsx, *" +
    ".rtf, *.htm, *.html";
            // 
            // olvFiles
            // 
            this.olvFiles.AllColumns.Add(this.olvClmFileName);
            this.olvFiles.AllColumns.Add(this.olvClmFiction);
            this.olvFiles.AllColumns.Add(this.olvClmSocPol);
            this.olvFiles.AllColumns.Add(this.olvClmReligious);
            this.olvFiles.AllColumns.Add(this.olvClmPoetry);
            this.olvFiles.AllColumns.Add(this.olvScientific);
            this.olvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.olvFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvFiles.FullRowSelect = true;
            this.olvFiles.GridLines = true;
            this.olvFiles.Location = new System.Drawing.Point(0, 86);
            this.olvFiles.Name = "olvFiles";
            this.olvFiles.ShowGroups = false;
            this.olvFiles.Size = new System.Drawing.Size(756, 365);
            this.olvFiles.TabIndex = 17;
            this.olvFiles.UseAlternatingBackColors = true;
            this.olvFiles.UseCompatibleStateImageBehavior = false;
            this.olvFiles.View = System.Windows.Forms.View.Details;
            this.olvFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.olvFiles_KeyUp);
            // 
            // olvClmFileName
            // 
            this.olvClmFileName.AspectName = "fileName";
            this.olvClmFileName.Groupable = false;
            this.olvClmFileName.Text = "Файл";
            this.olvClmFileName.Width = 369;
            // 
            // olvClmFiction
            // 
            this.olvClmFiction.AspectName = "isFiction";
            this.olvClmFiction.CheckBoxes = true;
            this.olvClmFiction.Groupable = false;
            this.olvClmFiction.Sortable = false;
            this.olvClmFiction.Text = "Художественная";
            // 
            // olvClmSocPol
            // 
            this.olvClmSocPol.AspectName = "isSocPol";
            this.olvClmSocPol.CheckBoxes = true;
            this.olvClmSocPol.Groupable = false;
            this.olvClmSocPol.Sortable = false;
            this.olvClmSocPol.Text = "Социально-политическая";
            // 
            // olvClmReligious
            // 
            this.olvClmReligious.AspectName = "isReligious";
            this.olvClmReligious.CheckBoxes = true;
            this.olvClmReligious.Groupable = false;
            this.olvClmReligious.Sortable = false;
            this.olvClmReligious.Text = "Религиозная";
            // 
            // olvClmPoetry
            // 
            this.olvClmPoetry.AspectName = "isPoetry";
            this.olvClmPoetry.CheckBoxes = true;
            this.olvClmPoetry.Groupable = false;
            this.olvClmPoetry.Sortable = false;
            this.olvClmPoetry.Text = "Поэтическая";
            // 
            // olvScientific
            // 
            this.olvScientific.AspectName = "isScientific";
            this.olvScientific.CheckBoxes = true;
            this.olvScientific.Groupable = false;
            this.olvScientific.Sortable = false;
            this.olvScientific.Text = "Научная";
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Controls.Add(this.tbpCount);
            this.tbcMain.Controls.Add(this.tbpHistory);
            this.tbcMain.Controls.Add(this.tbpWordProcessor);
            this.tbcMain.Location = new System.Drawing.Point(-1, 27);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(763, 475);
            this.tbcMain.TabIndex = 1;
            this.tbcMain.SelectedIndexChanged += new System.EventHandler(this.tbcHistory_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 531);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbcMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "wFrequencies";
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
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
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
        private System.Windows.Forms.TabPage tbpWordProcessor;
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
    }
}


namespace wFrequencies
{
    partial class frmMain
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
            this.tbcHistory = new System.Windows.Forms.TabControl();
            this.tbpCount = new System.Windows.Forms.TabPage();
            this.olvFiles = new BrightIdeasSoftware.ObjectListView();
            this.olvClmFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFiction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmSocPol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmReligious = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPoetry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvScientific = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkingDir = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbpHistory = new System.Windows.Forms.TabPage();
            this.olvHistory = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWordsCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmUniqueWords = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.prbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.contextMenuStrip1.SuspendLayout();
            this.tbcHistory.SuspendLayout();
            this.tbpCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvFiles)).BeginInit();
            this.tbpHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvHistory)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxRemoveFromtheList});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 26);
            // 
            // ctxRemoveFromtheList
            // 
            this.ctxRemoveFromtheList.Name = "ctxRemoveFromtheList";
            this.ctxRemoveFromtheList.Size = new System.Drawing.Size(174, 22);
            this.ctxRemoveFromtheList.Text = "Удалить из списка";
            this.ctxRemoveFromtheList.Click += new System.EventHandler(this.ctxRemoveFromtheList_Click);
            // 
            // tbcHistory
            // 
            this.tbcHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcHistory.Controls.Add(this.tbpCount);
            this.tbcHistory.Controls.Add(this.tbpHistory);
            this.tbcHistory.Location = new System.Drawing.Point(-1, 2);
            this.tbcHistory.Name = "tbcHistory";
            this.tbcHistory.SelectedIndex = 0;
            this.tbcHistory.Size = new System.Drawing.Size(687, 447);
            this.tbcHistory.TabIndex = 1;
            this.tbcHistory.SelectedIndexChanged += new System.EventHandler(this.tbcHistory_SelectedIndexChanged);
            // 
            // tbpCount
            // 
            this.tbpCount.Controls.Add(this.olvFiles);
            this.tbpCount.Controls.Add(this.lblInfo);
            this.tbpCount.Controls.Add(this.btnStart);
            this.tbpCount.Controls.Add(this.label1);
            this.tbpCount.Controls.Add(this.txtWorkingDir);
            this.tbpCount.Controls.Add(this.btnBrowse);
            this.tbpCount.Location = new System.Drawing.Point(4, 22);
            this.tbpCount.Name = "tbpCount";
            this.tbpCount.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCount.Size = new System.Drawing.Size(679, 421);
            this.tbpCount.TabIndex = 0;
            this.tbpCount.Text = "Подсчет";
            this.tbpCount.UseVisualStyleBackColor = true;
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
            this.olvFiles.Location = new System.Drawing.Point(0, 86);
            this.olvFiles.Name = "olvFiles";
            this.olvFiles.ShowGroups = false;
            this.olvFiles.Size = new System.Drawing.Size(680, 332);
            this.olvFiles.TabIndex = 17;
            this.olvFiles.UseCompatibleStateImageBehavior = false;
            this.olvFiles.View = System.Windows.Forms.View.Details;
            // 
            // olvClmFileName
            // 
            this.olvClmFileName.AspectName = "fileName";
            this.olvClmFileName.Groupable = false;
            this.olvClmFileName.Text = "Файл";
            this.olvClmFileName.Width = 300;
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
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Location = new System.Drawing.Point(4, 46);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(589, 36);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Выберите папку с входными файлами\r\n *.doc, *.docx, *.pdf, *.txt, *.odt, *.xlsx, *" +
    ".rtf, *.htm, *.html";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.Location = new System.Drawing.Point(602, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = false;
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
            // txtWorkingDir
            // 
            this.txtWorkingDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingDir.Location = new System.Drawing.Point(0, 21);
            this.txtWorkingDir.Name = "txtWorkingDir";
            this.txtWorkingDir.Size = new System.Drawing.Size(596, 20);
            this.txtWorkingDir.TabIndex = 11;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBrowse.Location = new System.Drawing.Point(602, 21);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 22);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Выбрать";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // tbpHistory
            // 
            this.tbpHistory.Controls.Add(this.olvHistory);
            this.tbpHistory.Location = new System.Drawing.Point(4, 22);
            this.tbpHistory.Name = "tbpHistory";
            this.tbpHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHistory.Size = new System.Drawing.Size(679, 421);
            this.tbpHistory.TabIndex = 1;
            this.tbpHistory.Text = "История";
            this.tbpHistory.UseVisualStyleBackColor = true;
            // 
            // olvHistory
            // 
            this.olvHistory.AllColumns.Add(this.olvColumn1);
            this.olvHistory.AllColumns.Add(this.olvClmCategory);
            this.olvHistory.AllColumns.Add(this.olvClmWordsCount);
            this.olvHistory.AllColumns.Add(this.olvClmUniqueWords);
            this.olvHistory.AllColumns.Add(this.olvClmDateTime);
            this.olvHistory.CellEditUseWholeCell = false;
            this.olvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvClmCategory,
            this.olvClmWordsCount,
            this.olvClmUniqueWords,
            this.olvClmDateTime});
            this.olvHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvHistory.FullRowSelect = true;
            this.olvHistory.Location = new System.Drawing.Point(3, 3);
            this.olvHistory.Name = "olvHistory";
            this.olvHistory.Size = new System.Drawing.Size(673, 415);
            this.olvHistory.TabIndex = 11;
            this.olvHistory.UseCompatibleStateImageBehavior = false;
            this.olvHistory.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "fileName";
            this.olvColumn1.Groupable = false;
            this.olvColumn1.Text = "Файл";
            this.olvColumn1.Width = 220;
            // 
            // olvClmCategory
            // 
            this.olvClmCategory.AspectName = "getCategoryName";
            this.olvClmCategory.Groupable = false;
            this.olvClmCategory.Text = "Категория";
            this.olvClmCategory.Width = 89;
            // 
            // olvClmWordsCount
            // 
            this.olvClmWordsCount.AspectName = "wordsCount";
            this.olvClmWordsCount.Groupable = false;
            this.olvClmWordsCount.Text = "Всего слов";
            this.olvClmWordsCount.Width = 89;
            // 
            // olvClmUniqueWords
            // 
            this.olvClmUniqueWords.AspectName = "uniqueWordsCount";
            this.olvClmUniqueWords.Groupable = false;
            this.olvClmUniqueWords.Text = "Уникальных слов";
            this.olvClmUniqueWords.Width = 129;
            // 
            // olvClmDateTime
            // 
            this.olvClmDateTime.AspectName = "created_at";
            this.olvClmDateTime.Text = "Дата и время";
            this.olvClmDateTime.Width = 138;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.prbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(140, 22);
            this.lblStatus.Text = "Статус";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prbStatus
            // 
            this.prbStatus.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.prbStatus.Name = "prbStatus";
            this.prbStatus.Size = new System.Drawing.Size(140, 22);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 469);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbcHistory);
            this.Name = "frmMain";
            this.Text = "wFrequencies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tbcHistory.ResumeLayout(false);
            this.tbpCount.ResumeLayout(false);
            this.tbpCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvFiles)).EndInit();
            this.tbpHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvHistory)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog fbWorkingDir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxRemoveFromtheList;
        private System.Windows.Forms.TabControl tbcHistory;
        private System.Windows.Forms.TabPage tbpCount;
        private BrightIdeasSoftware.ObjectListView olvFiles;
        private BrightIdeasSoftware.OLVColumn olvClmFileName;
        private BrightIdeasSoftware.OLVColumn olvClmFiction;
        private BrightIdeasSoftware.OLVColumn olvClmSocPol;
        private BrightIdeasSoftware.OLVColumn olvClmReligious;
        private BrightIdeasSoftware.OLVColumn olvClmPoetry;
        private BrightIdeasSoftware.OLVColumn olvScientific;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkingDir;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TabPage tbpHistory;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private BrightIdeasSoftware.ObjectListView olvHistory;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvClmCategory;
        private BrightIdeasSoftware.OLVColumn olvClmWordsCount;
        private BrightIdeasSoftware.OLVColumn olvClmUniqueWords;
        private BrightIdeasSoftware.OLVColumn olvClmDateTime;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar prbStatus;
    }
}


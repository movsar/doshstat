namespace DoshStat
{
    partial class FrmTotalDetails
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTotalDetails));
            this.olvClmFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWordsCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmUniqueWords = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWord = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPercentage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDetailedHistory = new BrightIdeasSoftware.ObjectListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetailedHistory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvClmFileName
            // 
            this.olvClmFileName.AspectName = "fileName";
            this.olvClmFileName.Groupable = false;
            resources.ApplyResources(this.olvClmFileName, "olvClmFileName");
            // 
            // olvClmCategory
            // 
            this.olvClmCategory.AspectName = "getCategoryName";
            this.olvClmCategory.Groupable = false;
            resources.ApplyResources(this.olvClmCategory, "olvClmCategory");
            // 
            // olvClmWordsCount
            // 
            this.olvClmWordsCount.AspectName = "wordsCount";
            resources.ApplyResources(this.olvClmWordsCount, "olvClmWordsCount");
            this.olvClmWordsCount.Groupable = false;
            this.olvClmWordsCount.IsVisible = false;
            // 
            // olvClmUniqueWords
            // 
            this.olvClmUniqueWords.AspectName = "uniqueWordsCount";
            resources.ApplyResources(this.olvClmUniqueWords, "olvClmUniqueWords");
            this.olvClmUniqueWords.Groupable = false;
            this.olvClmUniqueWords.IsVisible = false;
            // 
            // olvClmWord
            // 
            this.olvClmWord.AspectName = "word";
            this.olvClmWord.Groupable = false;
            resources.ApplyResources(this.olvClmWord, "olvClmWord");
            // 
            // olvClmFrequency
            // 
            this.olvClmFrequency.AspectName = "frequency";
            this.olvClmFrequency.Groupable = false;
            resources.ApplyResources(this.olvClmFrequency, "olvClmFrequency");
            // 
            // olvClmPercentage
            // 
            this.olvClmPercentage.AspectName = "getNeatPercentage";
            this.olvClmPercentage.AspectToStringFormat = "{0:0.000}%";
            this.olvClmPercentage.Groupable = false;
            resources.ApplyResources(this.olvClmPercentage, "olvClmPercentage");
            // 
            // olvClmDateTime
            // 
            this.olvClmDateTime.AspectName = "created_at";
            resources.ApplyResources(this.olvClmDateTime, "olvClmDateTime");
            this.olvClmDateTime.Groupable = false;
            this.olvClmDateTime.IsVisible = false;
            // 
            // olvDetailedHistory
            // 
            resources.ApplyResources(this.olvDetailedHistory, "olvDetailedHistory");
            this.olvDetailedHistory.AllColumns.Add(this.olvClmFileName);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmCategory);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmWordsCount);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmUniqueWords);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmWord);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmFrequency);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmPercentage);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmDateTime);
            this.olvDetailedHistory.CellEditUseWholeCell = false;
            this.olvDetailedHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmFileName,
            this.olvClmCategory,
            this.olvClmWord,
            this.olvClmFrequency,
            this.olvClmPercentage});
            this.olvDetailedHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.olvDetailedHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDetailedHistory.FullRowSelect = true;
            this.olvDetailedHistory.GridLines = true;
            this.olvDetailedHistory.HideSelection = false;
            this.olvDetailedHistory.Name = "olvDetailedHistory";
            this.olvDetailedHistory.OverlayText.Text = resources.GetString("resource.Text");
            this.olvDetailedHistory.ShowGroups = false;
            this.olvDetailedHistory.TintSortColumn = true;
            this.olvDetailedHistory.UseAlternatingBackColors = true;
            this.olvDetailedHistory.UseCompatibleStateImageBehavior = false;
            this.olvDetailedHistory.UseExplorerTheme = true;
            this.olvDetailedHistory.UseFilterIndicator = true;
            this.olvDetailedHistory.UseFiltering = true;
            this.olvDetailedHistory.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // удалитьToolStripMenuItem
            // 
            resources.ApplyResources(this.удалитьToolStripMenuItem, "удалитьToolStripMenuItem");
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FrmTotalDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.olvDetailedHistory);
            this.Name = "FrmTotalDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTotalDetails_FormClosed);
            this.Load += new System.EventHandler(this.FrmDetailedHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvDetailedHistory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BrightIdeasSoftware.OLVColumn olvClmFileName;
        private BrightIdeasSoftware.OLVColumn olvClmCategory;
        private BrightIdeasSoftware.OLVColumn olvClmWordsCount;
        private BrightIdeasSoftware.OLVColumn olvClmUniqueWords;
        private BrightIdeasSoftware.OLVColumn olvClmWord;
        private BrightIdeasSoftware.OLVColumn olvClmFrequency;
        private BrightIdeasSoftware.OLVColumn olvClmPercentage;
        private BrightIdeasSoftware.OLVColumn olvClmDateTime;
        private BrightIdeasSoftware.ObjectListView olvDetailedHistory;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}
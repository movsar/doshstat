namespace DoshStat
{
    partial class FrmMultipleFilesFrequencies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMultipleFilesFrequencies));
            this.olvTotalFrequencies = new BrightIdeasSoftware.ObjectListView();
            this.olvClmRank = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWord = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPercentage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblSelectedWordsPercentage = new System.Windows.Forms.Label();
            this.lblCharactersCount = new System.Windows.Forms.Label();
            this.lblUniqueWords = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblSelectedWordsCount = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilesCount = new System.Windows.Forms.Label();
            this.lblSelectedFrequency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.olvTotalFrequencies)).BeginInit();
            this.SuspendLayout();
            // 
            // olvTotalFrequencies
            // 
            resources.ApplyResources(this.olvTotalFrequencies, "olvTotalFrequencies");
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmRank);
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmWord);
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmFrequency);
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmPercentage);
            this.olvTotalFrequencies.CellEditUseWholeCell = false;
            this.olvTotalFrequencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmRank,
            this.olvClmWord,
            this.olvClmFrequency,
            this.olvClmPercentage});
            this.olvTotalFrequencies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTotalFrequencies.FullRowSelect = true;
            this.olvTotalFrequencies.GridLines = true;
            this.olvTotalFrequencies.HideSelection = false;
            this.olvTotalFrequencies.Name = "olvTotalFrequencies";
            this.olvTotalFrequencies.OverlayText.Text = resources.GetString("resource.Text");
            this.olvTotalFrequencies.ShowGroups = false;
            this.olvTotalFrequencies.UseAlternatingBackColors = true;
            this.olvTotalFrequencies.UseCompatibleStateImageBehavior = false;
            this.olvTotalFrequencies.UseFilterIndicator = true;
            this.olvTotalFrequencies.UseFiltering = true;
            this.olvTotalFrequencies.UseHotItem = true;
            this.olvTotalFrequencies.UseTranslucentHotItem = true;
            this.olvTotalFrequencies.View = System.Windows.Forms.View.Details;
            this.olvTotalFrequencies.SelectionChanged += new System.EventHandler(this.olvTotalFrequencies_SelectionChanged);
            // 
            // olvClmRank
            // 
            this.olvClmRank.AspectName = "rank";
            resources.ApplyResources(this.olvClmRank, "olvClmRank");
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
            this.olvClmPercentage.AspectName = "percentage";
            this.olvClmPercentage.AspectToStringFormat = "{0:0.000}%";
            resources.ApplyResources(this.olvClmPercentage, "olvClmPercentage");
            // 
            // lblSelectedWordsPercentage
            // 
            resources.ApplyResources(this.lblSelectedWordsPercentage, "lblSelectedWordsPercentage");
            this.lblSelectedWordsPercentage.Name = "lblSelectedWordsPercentage";
            // 
            // lblCharactersCount
            // 
            resources.ApplyResources(this.lblCharactersCount, "lblCharactersCount");
            this.lblCharactersCount.Name = "lblCharactersCount";
            // 
            // lblUniqueWords
            // 
            resources.ApplyResources(this.lblUniqueWords, "lblUniqueWords");
            this.lblUniqueWords.Name = "lblUniqueWords";
            // 
            // lblWordCount
            // 
            resources.ApplyResources(this.lblWordCount, "lblWordCount");
            this.lblWordCount.Name = "lblWordCount";
            // 
            // lblSelectedWordsCount
            // 
            resources.ApplyResources(this.lblSelectedWordsCount, "lblSelectedWordsCount");
            this.lblSelectedWordsCount.Name = "lblSelectedWordsCount";
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblFilesCount
            // 
            resources.ApplyResources(this.lblFilesCount, "lblFilesCount");
            this.lblFilesCount.Name = "lblFilesCount";
            // 
            // lblSelectedFrequency
            // 
            resources.ApplyResources(this.lblSelectedFrequency, "lblSelectedFrequency");
            this.lblSelectedFrequency.Name = "lblSelectedFrequency";
            // 
            // FrmMultipleFilesFrequencies
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectedFrequency);
            this.Controls.Add(this.lblFilesCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblSelectedWordsCount);
            this.Controls.Add(this.lblSelectedWordsPercentage);
            this.Controls.Add(this.lblCharactersCount);
            this.Controls.Add(this.lblUniqueWords);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.olvTotalFrequencies);
            this.Name = "FrmMultipleFilesFrequencies";
            this.Load += new System.EventHandler(this.TotalFrequencies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvTotalFrequencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvTotalFrequencies;
        private BrightIdeasSoftware.OLVColumn olvClmWord;
        private BrightIdeasSoftware.OLVColumn olvClmFrequency;
        private BrightIdeasSoftware.OLVColumn olvClmPercentage;
        private System.Windows.Forms.Label lblSelectedWordsPercentage;
        private System.Windows.Forms.Label lblCharactersCount;
        private System.Windows.Forms.Label lblUniqueWords;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblSelectedWordsCount;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilesCount;
        private System.Windows.Forms.Label lblSelectedFrequency;
        private BrightIdeasSoftware.OLVColumn olvClmRank;
    }
}
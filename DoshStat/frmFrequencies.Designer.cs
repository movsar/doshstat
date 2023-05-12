namespace DoshStat
{
    partial class FrmSingleFileFrequencies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSingleFileFrequencies));
            this.olvFrequencies = new BrightIdeasSoftware.ObjectListView();
            this.olvClmRank = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWord = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPercentage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblUniqueWords = new System.Windows.Forms.Label();
            this.lblCharactersCount = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblSelectedWordsCount = new System.Windows.Forms.Label();
            this.lblSelectedWordsPercentage = new System.Windows.Forms.Label();
            this.lblSelectedFrequency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.olvFrequencies)).BeginInit();
            this.SuspendLayout();
            // 
            // olvFrequencies
            // 
            resources.ApplyResources(this.olvFrequencies, "olvFrequencies");
            this.olvFrequencies.AllColumns.Add(this.olvClmRank);
            this.olvFrequencies.AllColumns.Add(this.olvClmWord);
            this.olvFrequencies.AllColumns.Add(this.olvClmFrequency);
            this.olvFrequencies.AllColumns.Add(this.olvClmPercentage);
            this.olvFrequencies.CellEditUseWholeCell = false;
            this.olvFrequencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmRank,
            this.olvClmWord,
            this.olvClmFrequency,
            this.olvClmPercentage});
            this.olvFrequencies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFrequencies.FullRowSelect = true;
            this.olvFrequencies.GridLines = true;
            this.olvFrequencies.HideSelection = false;
            this.olvFrequencies.Name = "olvFrequencies";
            this.olvFrequencies.OverlayText.Text = resources.GetString("resource.Text");
            this.olvFrequencies.ShowGroups = false;
            this.olvFrequencies.UseAlternatingBackColors = true;
            this.olvFrequencies.UseCompatibleStateImageBehavior = false;
            this.olvFrequencies.UseFilterIndicator = true;
            this.olvFrequencies.UseFiltering = true;
            this.olvFrequencies.View = System.Windows.Forms.View.Details;
            this.olvFrequencies.SelectionChanged += new System.EventHandler(this.olvFrequencies_SelectionChanged);
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
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            // 
            // lblWordCount
            // 
            resources.ApplyResources(this.lblWordCount, "lblWordCount");
            this.lblWordCount.Name = "lblWordCount";
            // 
            // lblUniqueWords
            // 
            resources.ApplyResources(this.lblUniqueWords, "lblUniqueWords");
            this.lblUniqueWords.Name = "lblUniqueWords";
            // 
            // lblCharactersCount
            // 
            resources.ApplyResources(this.lblCharactersCount, "lblCharactersCount");
            this.lblCharactersCount.Name = "lblCharactersCount";
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblSelectedWordsCount
            // 
            resources.ApplyResources(this.lblSelectedWordsCount, "lblSelectedWordsCount");
            this.lblSelectedWordsCount.Name = "lblSelectedWordsCount";
            // 
            // lblSelectedWordsPercentage
            // 
            resources.ApplyResources(this.lblSelectedWordsPercentage, "lblSelectedWordsPercentage");
            this.lblSelectedWordsPercentage.Name = "lblSelectedWordsPercentage";
            // 
            // lblSelectedFrequency
            // 
            resources.ApplyResources(this.lblSelectedFrequency, "lblSelectedFrequency");
            this.lblSelectedFrequency.Name = "lblSelectedFrequency";
            // 
            // FrmSingleFileFrequencies
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectedFrequency);
            this.Controls.Add(this.lblSelectedWordsPercentage);
            this.Controls.Add(this.lblSelectedWordsCount);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblCharactersCount);
            this.Controls.Add(this.lblUniqueWords);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.olvFrequencies);
            this.Name = "FrmSingleFileFrequencies";
            this.Load += new System.EventHandler(this.frmFrequencies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvFrequencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvFrequencies;
        private BrightIdeasSoftware.OLVColumn olvClmWord;
        private BrightIdeasSoftware.OLVColumn olvClmFrequency;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblUniqueWords;
        private System.Windows.Forms.Label lblCharactersCount;
        private System.Windows.Forms.Button btnExport;
        private BrightIdeasSoftware.OLVColumn olvClmPercentage;
        private System.Windows.Forms.Label lblSelectedWordsCount;
        private System.Windows.Forms.Label lblSelectedWordsPercentage;
        private System.Windows.Forms.Label lblSelectedFrequency;
        private BrightIdeasSoftware.OLVColumn olvClmRank;
    }
}
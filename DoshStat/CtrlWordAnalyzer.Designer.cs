namespace DoshStat
{
    partial class CtrlWordAnalyzer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlWordAnalyzer));
            this.olvSearchResults = new BrightIdeasSoftware.ObjectListView();
            this.olvClmWord = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPercentage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // olvSearchResults
            // 
            resources.ApplyResources(this.olvSearchResults, "olvSearchResults");
            this.olvSearchResults.AllColumns.Add(this.olvClmWord);
            this.olvSearchResults.AllColumns.Add(this.olvClmFrequency);
            this.olvSearchResults.AllColumns.Add(this.olvClmPercentage);
            this.olvSearchResults.AllColumns.Add(this.olvClmFileName);
            this.olvSearchResults.AllColumns.Add(this.olvClmCategory);
            this.olvSearchResults.AllColumns.Add(this.olvClmDateTime);
            this.olvSearchResults.CellEditUseWholeCell = false;
            this.olvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmWord,
            this.olvClmFrequency,
            this.olvClmPercentage,
            this.olvClmFileName,
            this.olvClmCategory,
            this.olvClmDateTime});
            this.olvSearchResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSearchResults.FullRowSelect = true;
            this.olvSearchResults.GridLines = true;
            this.olvSearchResults.HideSelection = false;
            this.olvSearchResults.MultiSelect = false;
            this.olvSearchResults.Name = "olvSearchResults";
            this.olvSearchResults.OverlayText.Text = resources.GetString("resource.Text");
            this.olvSearchResults.ShowGroups = false;
            this.olvSearchResults.TintSortColumn = true;
            this.olvSearchResults.UseAlternatingBackColors = true;
            this.olvSearchResults.UseCompatibleStateImageBehavior = false;
            this.olvSearchResults.UseFilterIndicator = true;
            this.olvSearchResults.UseFiltering = true;
            this.olvSearchResults.View = System.Windows.Forms.View.Details;
            this.olvSearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvSearchResults_MouseDoubleClick);
            // 
            // olvClmWord
            // 
            this.olvClmWord.AspectName = "word";
            resources.ApplyResources(this.olvClmWord, "olvClmWord");
            // 
            // olvClmFrequency
            // 
            this.olvClmFrequency.AspectName = "frequency";
            resources.ApplyResources(this.olvClmFrequency, "olvClmFrequency");
            // 
            // olvClmPercentage
            // 
            this.olvClmPercentage.AspectName = "getNeatPercentage";
            this.olvClmPercentage.AspectToStringFormat = "";
            resources.ApplyResources(this.olvClmPercentage, "olvClmPercentage");
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
            // olvClmDateTime
            // 
            this.olvClmDateTime.AspectName = "created_at";
            resources.ApplyResources(this.olvClmDateTime, "olvClmDateTime");
            // 
            // txtWord
            // 
            resources.ApplyResources(this.txtWord, "txtWord");
            this.txtWord.Name = "txtWord";
            this.txtWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWord_KeyUp);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // CtrlWordAnalyzer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.olvSearchResults);
            this.Name = "CtrlWordAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.olvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvSearchResults;
        private BrightIdeasSoftware.OLVColumn olvClmWord;
        private BrightIdeasSoftware.OLVColumn olvClmFrequency;
        private BrightIdeasSoftware.OLVColumn olvClmPercentage;
        private BrightIdeasSoftware.OLVColumn olvClmFileName;
        private BrightIdeasSoftware.OLVColumn olvClmCategory;
        private BrightIdeasSoftware.OLVColumn olvClmDateTime;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
    }
}

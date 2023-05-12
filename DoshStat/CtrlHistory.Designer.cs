namespace DoshStat
{
    partial class CtrlHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlHistory));
            this.olvHistory = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWordsCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmUniqueWords = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnExport = new System.Windows.Forms.Button();
            this.btnFullReport = new System.Windows.Forms.Button();
            this.btnTotalFrequencies = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.olvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // olvHistory
            // 
            resources.ApplyResources(this.olvHistory, "olvHistory");
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
            this.olvHistory.FullRowSelect = true;
            this.olvHistory.GridLines = true;
            this.olvHistory.HideSelection = false;
            this.olvHistory.Name = "olvHistory";
            this.olvHistory.OverlayText.Text = resources.GetString("resource.Text");
            this.olvHistory.ShowGroups = false;
            this.toolTip1.SetToolTip(this.olvHistory, resources.GetString("olvHistory.ToolTip"));
            this.olvHistory.UseAlternatingBackColors = true;
            this.olvHistory.UseCompatibleStateImageBehavior = false;
            this.olvHistory.UseFilterIndicator = true;
            this.olvHistory.UseFiltering = true;
            this.olvHistory.View = System.Windows.Forms.View.Details;
            this.olvHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvHistory_MouseDoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "fileName";
            this.olvColumn1.Groupable = false;
            resources.ApplyResources(this.olvColumn1, "olvColumn1");
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
            this.olvClmWordsCount.Groupable = false;
            resources.ApplyResources(this.olvClmWordsCount, "olvClmWordsCount");
            // 
            // olvClmUniqueWords
            // 
            this.olvClmUniqueWords.AspectName = "uniqueWordsCount";
            this.olvClmUniqueWords.Groupable = false;
            resources.ApplyResources(this.olvClmUniqueWords, "olvClmUniqueWords");
            // 
            // olvClmDateTime
            // 
            this.olvClmDateTime.AspectName = "created_at";
            this.olvClmDateTime.Groupable = false;
            resources.ApplyResources(this.olvClmDateTime, "olvClmDateTime");
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.toolTip1.SetToolTip(this.btnExport, resources.GetString("btnExport.ToolTip"));
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnFullReport
            // 
            resources.ApplyResources(this.btnFullReport, "btnFullReport");
            this.btnFullReport.Name = "btnFullReport";
            this.toolTip1.SetToolTip(this.btnFullReport, resources.GetString("btnFullReport.ToolTip"));
            this.btnFullReport.UseVisualStyleBackColor = true;
            this.btnFullReport.Click += new System.EventHandler(this.btnFullReport_Click);
            // 
            // btnTotalFrequencies
            // 
            resources.ApplyResources(this.btnTotalFrequencies, "btnTotalFrequencies");
            this.btnTotalFrequencies.Name = "btnTotalFrequencies";
            this.toolTip1.SetToolTip(this.btnTotalFrequencies, resources.GetString("btnTotalFrequencies.ToolTip"));
            this.btnTotalFrequencies.UseVisualStyleBackColor = true;
            this.btnTotalFrequencies.Click += new System.EventHandler(this.btnTotalFrequencies_Click);
            // 
            // dtpTo
            // 
            resources.ApplyResources(this.dtpTo, "dtpTo");
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Name = "dtpTo";
            this.toolTip1.SetToolTip(this.dtpTo, resources.GetString("dtpTo.ToolTip"));
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            resources.ApplyResources(this.dtpFrom, "dtpFrom");
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Name = "dtpFrom";
            this.toolTip1.SetToolTip(this.dtpFrom, resources.GetString("dtpFrom.ToolTip"));
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // CtrlHistory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnTotalFrequencies);
            this.Controls.Add(this.olvHistory);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnFullReport);
            this.Name = "CtrlHistory";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.CtrlHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvHistory;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvClmCategory;
        private BrightIdeasSoftware.OLVColumn olvClmWordsCount;
        private BrightIdeasSoftware.OLVColumn olvClmUniqueWords;
        private BrightIdeasSoftware.OLVColumn olvClmDateTime;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnFullReport;
        private System.Windows.Forms.Button btnTotalFrequencies;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

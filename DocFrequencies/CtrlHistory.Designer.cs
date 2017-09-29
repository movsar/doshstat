namespace wFrequencies
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
            this.olvHistory = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWordsCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmUniqueWords = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnExport = new System.Windows.Forms.Button();
            this.btnFullReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvHistory)).BeginInit();
            this.SuspendLayout();
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
            this.olvHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.olvHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvHistory.FullRowSelect = true;
            this.olvHistory.GridLines = true;
            this.olvHistory.Location = new System.Drawing.Point(0, 0);
            this.olvHistory.MultiSelect = false;
            this.olvHistory.Name = "olvHistory";
            this.olvHistory.ShowGroups = false;
            this.olvHistory.Size = new System.Drawing.Size(743, 416);
            this.olvHistory.TabIndex = 12;
            this.olvHistory.UseAlternatingBackColors = true;
            this.olvHistory.UseCompatibleStateImageBehavior = false;
            this.olvHistory.UseFilterIndicator = true;
            this.olvHistory.UseFiltering = true;
            this.olvHistory.UseHotItem = true;
            this.olvHistory.UseTranslucentHotItem = true;
            this.olvHistory.View = System.Windows.Forms.View.Details;
            this.olvHistory.DoubleClick += new System.EventHandler(this.olvHistory_DoubleClick);
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
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(452, 421);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Экспорт";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnFullReport
            // 
            this.btnFullReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullReport.Location = new System.Drawing.Point(558, 421);
            this.btnFullReport.Name = "btnFullReport";
            this.btnFullReport.Size = new System.Drawing.Size(182, 23);
            this.btnFullReport.TabIndex = 15;
            this.btnFullReport.Text = "Подробный Отчет";
            this.btnFullReport.UseVisualStyleBackColor = true;
            this.btnFullReport.Click += new System.EventHandler(this.btnFullReport_Click);
            // 
            // CtrlHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.olvHistory);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnFullReport);
            this.Name = "CtrlHistory";
            this.Size = new System.Drawing.Size(743, 447);
            this.Load += new System.EventHandler(this.CtrlHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvHistory)).EndInit();
            this.ResumeLayout(false);

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
    }
}

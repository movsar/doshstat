namespace wFrequencies
{
    partial class FrmDetailedHistory
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
            this.olvClmFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWordsCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmUniqueWords = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWord = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPercentage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvDetailedHistory = new BrightIdeasSoftware.ObjectListView();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetailedHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // olvClmFileName
            // 
            this.olvClmFileName.AspectName = "fileName";
            this.olvClmFileName.Groupable = false;
            this.olvClmFileName.Text = "Файл";
            this.olvClmFileName.Width = 162;
            // 
            // olvClmCategory
            // 
            this.olvClmCategory.AspectName = "getCategoryName";
            this.olvClmCategory.Groupable = false;
            this.olvClmCategory.Text = "Категория";
            this.olvClmCategory.Width = 154;
            // 
            // olvClmWordsCount
            // 
            this.olvClmWordsCount.AspectName = "wordsCount";
            this.olvClmWordsCount.Groupable = false;
            this.olvClmWordsCount.Text = "Всего слов";
            this.olvClmWordsCount.Width = 100;
            // 
            // olvClmUniqueWords
            // 
            this.olvClmUniqueWords.AspectName = "uniqueWordsCount";
            this.olvClmUniqueWords.Groupable = false;
            this.olvClmUniqueWords.Text = "Уникальных слов";
            this.olvClmUniqueWords.Width = 129;
            // 
            // olvClmWord
            // 
            this.olvClmWord.AspectName = "word";
            this.olvClmWord.Text = "Слово";
            this.olvClmWord.Width = 145;
            // 
            // olvClmFrequency
            // 
            this.olvClmFrequency.AspectName = "frequency";
            this.olvClmFrequency.Text = "Частота";
            this.olvClmFrequency.Width = 89;
            // 
            // olvClmPercentage
            // 
            this.olvClmPercentage.AspectName = "getNeatPercentage";
            this.olvClmPercentage.AspectToStringFormat = "";
            this.olvClmPercentage.Text = "Плотность";
            this.olvClmPercentage.Width = 94;
            // 
            // olvClmDateTime
            // 
            this.olvClmDateTime.AspectName = "created_at";
            this.olvClmDateTime.Text = "Дата и время";
            this.olvClmDateTime.Width = 138;
            // 
            // olvDetailedHistory
            // 
            this.olvDetailedHistory.AllColumns.Add(this.olvClmWord);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmFrequency);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmPercentage);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmUniqueWords);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmWordsCount);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmFileName);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmCategory);
            this.olvDetailedHistory.AllColumns.Add(this.olvClmDateTime);
            this.olvDetailedHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvDetailedHistory.CellEditUseWholeCell = false;
            this.olvDetailedHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmWord,
            this.olvClmFrequency,
            this.olvClmPercentage,
            this.olvClmUniqueWords,
            this.olvClmWordsCount,
            this.olvClmFileName,
            this.olvClmCategory,
            this.olvClmDateTime});
            this.olvDetailedHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDetailedHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvDetailedHistory.FullRowSelect = true;
            this.olvDetailedHistory.GridLines = true;
            this.olvDetailedHistory.Location = new System.Drawing.Point(1, 0);
            this.olvDetailedHistory.MultiSelect = false;
            this.olvDetailedHistory.Name = "olvDetailedHistory";
            this.olvDetailedHistory.ShowGroups = false;
            this.olvDetailedHistory.Size = new System.Drawing.Size(1046, 576);
            this.olvDetailedHistory.TabIndex = 14;
            this.olvDetailedHistory.TintSortColumn = true;
            this.olvDetailedHistory.UseAlternatingBackColors = true;
            this.olvDetailedHistory.UseCompatibleStateImageBehavior = false;
            this.olvDetailedHistory.UseFilterIndicator = true;
            this.olvDetailedHistory.UseFiltering = true;
            this.olvDetailedHistory.View = System.Windows.Forms.View.Details;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(971, 580);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Экспорт";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FrmDetailedHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 606);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.olvDetailedHistory);
            this.Name = "FrmDetailedHistory";
            this.Text = "Детализированная история обработки файлов";
            this.Load += new System.EventHandler(this.FrmDetailedHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvDetailedHistory)).EndInit();
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
    }
}
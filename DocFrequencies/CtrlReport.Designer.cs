namespace wFrequencies
{
    partial class CtrlReport
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
            this.olvClmFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWordsCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmUniqueWords = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWord = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPercentage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // olvHistory
            // 
            this.olvHistory.AllColumns.Add(this.olvClmFileName);
            this.olvHistory.AllColumns.Add(this.olvClmCategory);
            this.olvHistory.AllColumns.Add(this.olvClmWordsCount);
            this.olvHistory.AllColumns.Add(this.olvClmUniqueWords);
            this.olvHistory.AllColumns.Add(this.olvClmWord);
            this.olvHistory.AllColumns.Add(this.olvClmFrequency);
            this.olvHistory.AllColumns.Add(this.olvClmPercentage);
            this.olvHistory.AllColumns.Add(this.olvClmDateTime);
            this.olvHistory.CellEditUseWholeCell = false;
            this.olvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmFileName,
            this.olvClmCategory,
            this.olvClmWordsCount,
            this.olvClmUniqueWords,
            this.olvClmWord,
            this.olvClmFrequency,
            this.olvClmPercentage,
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
            this.olvHistory.Size = new System.Drawing.Size(1080, 587);
            this.olvHistory.TabIndex = 13;
            this.olvHistory.UseAlternatingBackColors = true;
            this.olvHistory.UseCompatibleStateImageBehavior = false;
            this.olvHistory.View = System.Windows.Forms.View.Details;
            // 
            // olvClmFileName
            // 
            this.olvClmFileName.AspectName = "fileName";
            this.olvClmFileName.Groupable = false;
            this.olvClmFileName.Text = "Файл";
            this.olvClmFileName.Width = 269;
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
            // olvClmWord
            // 
            this.olvClmWord.AspectName = "word";
            this.olvClmWord.Text = "Слово";
            this.olvClmWord.Width = 122;
            // 
            // olvClmFrequency
            // 
            this.olvClmFrequency.AspectName = "frequency";
            this.olvClmFrequency.Text = "Частота";
            this.olvClmFrequency.Width = 89;
            // 
            // olvClmPercentage
            // 
            this.olvClmPercentage.AspectName = "percentage";
            this.olvClmPercentage.Text = "Плотность";
            this.olvClmPercentage.Width = 94;
            // 
            // olvClmDateTime
            // 
            this.olvClmDateTime.AspectName = "created_at";
            this.olvClmDateTime.Text = "Дата и время";
            this.olvClmDateTime.Width = 138;
            // 
            // CtrlReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.olvHistory);
            this.Name = "CtrlReport";
            this.Size = new System.Drawing.Size(1080, 577);
            ((System.ComponentModel.ISupportInitialize)(this.olvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvHistory;
        private BrightIdeasSoftware.OLVColumn olvClmFileName;
        private BrightIdeasSoftware.OLVColumn olvClmCategory;
        private BrightIdeasSoftware.OLVColumn olvClmWordsCount;
        private BrightIdeasSoftware.OLVColumn olvClmUniqueWords;
        private BrightIdeasSoftware.OLVColumn olvClmWord;
        private BrightIdeasSoftware.OLVColumn olvClmFrequency;
        private BrightIdeasSoftware.OLVColumn olvClmPercentage;
        private BrightIdeasSoftware.OLVColumn olvClmDateTime;
    }
}

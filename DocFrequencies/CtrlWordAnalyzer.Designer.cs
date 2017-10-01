namespace wFrequencies
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
            this.olvDetailedHistory = new BrightIdeasSoftware.ObjectListView();
            this.olvClmWord = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPercentage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmUniqueWords = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmWordsCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.olvDetailedHistory)).BeginInit();
            this.SuspendLayout();
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
            this.olvDetailedHistory.Location = new System.Drawing.Point(0, 86);
            this.olvDetailedHistory.MultiSelect = false;
            this.olvDetailedHistory.Name = "olvDetailedHistory";
            this.olvDetailedHistory.ShowGroups = false;
            this.olvDetailedHistory.Size = new System.Drawing.Size(1031, 462);
            this.olvDetailedHistory.TabIndex = 15;
            this.olvDetailedHistory.TintSortColumn = true;
            this.olvDetailedHistory.UseAlternatingBackColors = true;
            this.olvDetailedHistory.UseCompatibleStateImageBehavior = false;
            this.olvDetailedHistory.UseFilterIndicator = true;
            this.olvDetailedHistory.UseFiltering = true;
            this.olvDetailedHistory.View = System.Windows.Forms.View.Details;
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
            // olvClmUniqueWords
            // 
            this.olvClmUniqueWords.AspectName = "uniqueWordsCount";
            this.olvClmUniqueWords.Groupable = false;
            this.olvClmUniqueWords.Text = "Уникальных слов";
            this.olvClmUniqueWords.Width = 129;
            // 
            // olvClmWordsCount
            // 
            this.olvClmWordsCount.AspectName = "wordsCount";
            this.olvClmWordsCount.Groupable = false;
            this.olvClmWordsCount.Text = "Всего слов";
            this.olvClmWordsCount.Width = 100;
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
            // olvClmDateTime
            // 
            this.olvClmDateTime.AspectName = "created_at";
            this.olvClmDateTime.Text = "Дата и время";
            this.olvClmDateTime.Width = 138;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Равняется",
            "Содержит",
            "Начинается",
            "Заканчивается"});
            this.comboBox1.Location = new System.Drawing.Point(150, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Поиск слова по признаку:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(306, 7);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(150, 20);
            this.txtWord.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Общее количество вхождений";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Всего файлов где найдено слово";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Всего слов в данных файлах";
            // 
            // CtrlWordAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.olvDetailedHistory);
            this.Name = "CtrlWordAnalyzer";
            this.Size = new System.Drawing.Size(1031, 551);
            ((System.ComponentModel.ISupportInitialize)(this.olvDetailedHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvDetailedHistory;
        private BrightIdeasSoftware.OLVColumn olvClmWord;
        private BrightIdeasSoftware.OLVColumn olvClmFrequency;
        private BrightIdeasSoftware.OLVColumn olvClmPercentage;
        private BrightIdeasSoftware.OLVColumn olvClmUniqueWords;
        private BrightIdeasSoftware.OLVColumn olvClmWordsCount;
        private BrightIdeasSoftware.OLVColumn olvClmFileName;
        private BrightIdeasSoftware.OLVColumn olvClmCategory;
        private BrightIdeasSoftware.OLVColumn olvClmDateTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

namespace DoshStat
{
    partial class FrmTotalFrequencies
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
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmRank);
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmWord);
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmFrequency);
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmPercentage);
            this.olvTotalFrequencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvTotalFrequencies.CellEditUseWholeCell = false;
            this.olvTotalFrequencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmRank,
            this.olvClmWord,
            this.olvClmFrequency,
            this.olvClmPercentage});
            this.olvTotalFrequencies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTotalFrequencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvTotalFrequencies.FullRowSelect = true;
            this.olvTotalFrequencies.GridLines = true;
            this.olvTotalFrequencies.HideSelection = false;
            this.olvTotalFrequencies.Location = new System.Drawing.Point(-7, 75);
            this.olvTotalFrequencies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.olvTotalFrequencies.Name = "olvTotalFrequencies";
            this.olvTotalFrequencies.ShowGroups = false;
            this.olvTotalFrequencies.Size = new System.Drawing.Size(624, 552);
            this.olvTotalFrequencies.TabIndex = 13;
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
            this.olvClmRank.Text = "Ранг";
            this.olvClmRank.Width = 46;
            // 
            // olvClmWord
            // 
            this.olvClmWord.AspectName = "word";
            this.olvClmWord.Groupable = false;
            this.olvClmWord.Text = "Слово";
            this.olvClmWord.Width = 217;
            // 
            // olvClmFrequency
            // 
            this.olvClmFrequency.AspectName = "frequency";
            this.olvClmFrequency.Groupable = false;
            this.olvClmFrequency.Text = "Частота";
            this.olvClmFrequency.Width = 91;
            // 
            // olvClmPercentage
            // 
            this.olvClmPercentage.AspectName = "percentage";
            this.olvClmPercentage.AspectToStringFormat = "{0:0.0}%";
            this.olvClmPercentage.Text = "Относительная частота";
            this.olvClmPercentage.Width = 102;
            // 
            // lblSelectedWordsPercentage
            // 
            this.lblSelectedWordsPercentage.AutoSize = true;
            this.lblSelectedWordsPercentage.Location = new System.Drawing.Point(257, 39);
            this.lblSelectedWordsPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedWordsPercentage.Name = "lblSelectedWordsPercentage";
            this.lblSelectedWordsPercentage.Size = new System.Drawing.Size(0, 16);
            this.lblSelectedWordsPercentage.TabIndex = 27;
            // 
            // lblCharactersCount
            // 
            this.lblCharactersCount.AutoSize = true;
            this.lblCharactersCount.Location = new System.Drawing.Point(8, 7);
            this.lblCharactersCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharactersCount.Name = "lblCharactersCount";
            this.lblCharactersCount.Size = new System.Drawing.Size(118, 16);
            this.lblCharactersCount.TabIndex = 26;
            this.lblCharactersCount.Text = "Всего символов: ";
            // 
            // lblUniqueWords
            // 
            this.lblUniqueWords.AutoSize = true;
            this.lblUniqueWords.Location = new System.Drawing.Point(257, 23);
            this.lblUniqueWords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUniqueWords.Name = "lblUniqueWords";
            this.lblUniqueWords.Size = new System.Drawing.Size(125, 16);
            this.lblUniqueWords.TabIndex = 25;
            this.lblUniqueWords.Text = "Уникальных слов: ";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(8, 23);
            this.lblWordCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(85, 16);
            this.lblWordCount.TabIndex = 24;
            this.lblWordCount.Text = "Всего слов: ";
            // 
            // lblSelectedWordsCount
            // 
            this.lblSelectedWordsCount.AutoSize = true;
            this.lblSelectedWordsCount.Location = new System.Drawing.Point(8, 39);
            this.lblSelectedWordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedWordsCount.Name = "lblSelectedWordsCount";
            this.lblSelectedWordsCount.Size = new System.Drawing.Size(0, 16);
            this.lblSelectedWordsCount.TabIndex = 28;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(483, 635);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(131, 31);
            this.btnExport.TabIndex = 29;
            this.btnExport.Text = "Экспорт";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 642);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Показана обобщенная статистика по всем файлам";
            // 
            // lblFilesCount
            // 
            this.lblFilesCount.AutoSize = true;
            this.lblFilesCount.Location = new System.Drawing.Point(257, 7);
            this.lblFilesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilesCount.Name = "lblFilesCount";
            this.lblFilesCount.Size = new System.Drawing.Size(105, 16);
            this.lblFilesCount.TabIndex = 31;
            this.lblFilesCount.Text = "Всего файлов: ";
            // 
            // lblSelectedFrequency
            // 
            this.lblSelectedFrequency.AutoSize = true;
            this.lblSelectedFrequency.Location = new System.Drawing.Point(8, 55);
            this.lblSelectedFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedFrequency.Name = "lblSelectedFrequency";
            this.lblSelectedFrequency.Size = new System.Drawing.Size(0, 16);
            this.lblSelectedFrequency.TabIndex = 32;
            // 
            // FrmTotalFrequencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 671);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTotalFrequencies";
            this.Text = "Сводная частотность";
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
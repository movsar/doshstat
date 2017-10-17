namespace StrangeWords
{
    partial class FrmFrequencies
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
            this.olvFrequencies = new BrightIdeasSoftware.ObjectListView();
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
            this.olvClmRank = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvFrequencies)).BeginInit();
            this.SuspendLayout();
            // 
            // olvFrequencies
            // 
            this.olvFrequencies.AllColumns.Add(this.olvClmRank);
            this.olvFrequencies.AllColumns.Add(this.olvClmWord);
            this.olvFrequencies.AllColumns.Add(this.olvClmFrequency);
            this.olvFrequencies.AllColumns.Add(this.olvClmPercentage);
            this.olvFrequencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvFrequencies.CellEditUseWholeCell = false;
            this.olvFrequencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmRank,
            this.olvClmWord,
            this.olvClmFrequency,
            this.olvClmPercentage});
            this.olvFrequencies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFrequencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvFrequencies.FullRowSelect = true;
            this.olvFrequencies.GridLines = true;
            this.olvFrequencies.Location = new System.Drawing.Point(-5, 58);
            this.olvFrequencies.Name = "olvFrequencies";
            this.olvFrequencies.ShowGroups = false;
            this.olvFrequencies.Size = new System.Drawing.Size(471, 455);
            this.olvFrequencies.TabIndex = 12;
            this.olvFrequencies.UseAlternatingBackColors = true;
            this.olvFrequencies.UseCompatibleStateImageBehavior = false;
            this.olvFrequencies.UseFilterIndicator = true;
            this.olvFrequencies.UseFiltering = true;
            this.olvFrequencies.View = System.Windows.Forms.View.Details;
            this.olvFrequencies.SelectionChanged += new System.EventHandler(this.olvFrequencies_SelectionChanged);
            // 
            // olvClmWord
            // 
            this.olvClmWord.AspectName = "word";
            this.olvClmWord.Groupable = false;
            this.olvClmWord.Text = "Слово";
            this.olvClmWord.Width = 277;
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
            this.olvClmPercentage.Width = 92;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(3, 3);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(66, 13);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Категория: ";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(3, 16);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(70, 13);
            this.lblWordCount.TabIndex = 16;
            this.lblWordCount.Text = "Всего слов: ";
            // 
            // lblUniqueWords
            // 
            this.lblUniqueWords.AutoSize = true;
            this.lblUniqueWords.Location = new System.Drawing.Point(190, 16);
            this.lblUniqueWords.Name = "lblUniqueWords";
            this.lblUniqueWords.Size = new System.Drawing.Size(103, 13);
            this.lblUniqueWords.TabIndex = 17;
            this.lblUniqueWords.Text = "Уникальных слов: ";
            // 
            // lblCharactersCount
            // 
            this.lblCharactersCount.AutoSize = true;
            this.lblCharactersCount.Location = new System.Drawing.Point(190, 3);
            this.lblCharactersCount.Name = "lblCharactersCount";
            this.lblCharactersCount.Size = new System.Drawing.Size(96, 13);
            this.lblCharactersCount.TabIndex = 18;
            this.lblCharactersCount.Text = "Всего символов: ";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(365, 516);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 25);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Экспорт";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblSelectedWordsCount
            // 
            this.lblSelectedWordsCount.AutoSize = true;
            this.lblSelectedWordsCount.Location = new System.Drawing.Point(3, 29);
            this.lblSelectedWordsCount.Name = "lblSelectedWordsCount";
            this.lblSelectedWordsCount.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedWordsCount.TabIndex = 21;
            // 
            // lblSelectedWordsPercentage
            // 
            this.lblSelectedWordsPercentage.AutoSize = true;
            this.lblSelectedWordsPercentage.Location = new System.Drawing.Point(190, 29);
            this.lblSelectedWordsPercentage.Name = "lblSelectedWordsPercentage";
            this.lblSelectedWordsPercentage.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedWordsPercentage.TabIndex = 22;
            // 
            // lblSelectedFrequency
            // 
            this.lblSelectedFrequency.AutoSize = true;
            this.lblSelectedFrequency.Location = new System.Drawing.Point(3, 42);
            this.lblSelectedFrequency.Name = "lblSelectedFrequency";
            this.lblSelectedFrequency.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedFrequency.TabIndex = 23;
            // 
            // olvClmRank
            // 
            this.olvClmRank.AspectName = "rank";
            this.olvClmRank.Text = "Ранг";
            this.olvClmRank.Width = 50;
            // 
            // FrmFrequencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 542);
            this.Controls.Add(this.lblSelectedFrequency);
            this.Controls.Add(this.lblSelectedWordsPercentage);
            this.Controls.Add(this.lblSelectedWordsCount);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblCharactersCount);
            this.Controls.Add(this.lblUniqueWords);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.olvFrequencies);
            this.Name = "FrmFrequencies";
            this.Text = "Частотность по файлу";
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
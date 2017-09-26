namespace wFrequencies
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblUniqueWords = new System.Windows.Forms.Label();
            this.lblCharactersCount = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.olvFrequencies)).BeginInit();
            this.SuspendLayout();
            // 
            // olvFrequencies
            // 
            this.olvFrequencies.AllColumns.Add(this.olvClmWord);
            this.olvFrequencies.AllColumns.Add(this.olvClmFrequency);
            this.olvFrequencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvFrequencies.CellEditUseWholeCell = false;
            this.olvFrequencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmWord,
            this.olvClmFrequency});
            this.olvFrequencies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFrequencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvFrequencies.FullRowSelect = true;
            this.olvFrequencies.GridLines = true;
            this.olvFrequencies.Location = new System.Drawing.Point(-5, 34);
            this.olvFrequencies.Name = "olvFrequencies";
            this.olvFrequencies.ShowGroups = false;
            this.olvFrequencies.Size = new System.Drawing.Size(471, 289);
            this.olvFrequencies.TabIndex = 12;
            this.olvFrequencies.UseCompatibleStateImageBehavior = false;
            this.olvFrequencies.View = System.Windows.Forms.View.Details;
            // 
            // olvClmWord
            // 
            this.olvClmWord.AspectName = "word";
            this.olvClmWord.Groupable = false;
            this.olvClmWord.Text = "Слово";
            this.olvClmWord.Width = 257;
            // 
            // olvClmFrequency
            // 
            this.olvClmFrequency.AspectName = "frequency";
            this.olvClmFrequency.Groupable = false;
            this.olvClmFrequency.Text = "Частота";
            this.olvClmFrequency.Width = 66;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(3, 4);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(66, 13);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Категория: ";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(3, 17);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(70, 13);
            this.lblWordCount.TabIndex = 16;
            this.lblWordCount.Text = "Всего слов: ";
            // 
            // lblUniqueWords
            // 
            this.lblUniqueWords.AutoSize = true;
            this.lblUniqueWords.Location = new System.Drawing.Point(190, 17);
            this.lblUniqueWords.Name = "lblUniqueWords";
            this.lblUniqueWords.Size = new System.Drawing.Size(103, 13);
            this.lblUniqueWords.TabIndex = 17;
            this.lblUniqueWords.Text = "Уникальных слов: ";
            // 
            // lblCharactersCount
            // 
            this.lblCharactersCount.AutoSize = true;
            this.lblCharactersCount.Location = new System.Drawing.Point(190, 4);
            this.lblCharactersCount.Name = "lblCharactersCount";
            this.lblCharactersCount.Size = new System.Drawing.Size(96, 13);
            this.lblCharactersCount.TabIndex = 18;
            this.lblCharactersCount.Text = "Всего символов: ";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(365, 326);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 25);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Экспорт в XML";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(3, 332);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(42, 13);
            this.lblFileName.TabIndex = 20;
            this.lblFileName.Text = "Файл: ";
            // 
            // FrmFrequencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 352);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblCharactersCount);
            this.Controls.Add(this.lblUniqueWords);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.olvFrequencies);
            this.Name = "FrmFrequencies";
            this.Text = "Отчет по файлу";
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
        private System.Windows.Forms.Label lblFileName;
    }
}
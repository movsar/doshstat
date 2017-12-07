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
            this.olvHistory.View = System.Windows.Forms.View.Details;
            this.olvHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvHistory_MouseDoubleClick);
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
            this.olvClmDateTime.Groupable = false;
            this.olvClmDateTime.Text = "Дата и время";
            this.olvClmDateTime.Width = 138;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(418, 422);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(68, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Экспорт";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnFullReport
            // 
            this.btnFullReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullReport.Location = new System.Drawing.Point(615, 422);
            this.btnFullReport.Name = "btnFullReport";
            this.btnFullReport.Size = new System.Drawing.Size(128, 23);
            this.btnFullReport.TabIndex = 15;
            this.btnFullReport.Text = "Подробный Отчет";
            this.btnFullReport.UseVisualStyleBackColor = true;
            this.btnFullReport.Click += new System.EventHandler(this.btnFullReport_Click);
            // 
            // btnTotalFrequencies
            // 
            this.btnTotalFrequencies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTotalFrequencies.Location = new System.Drawing.Point(487, 422);
            this.btnTotalFrequencies.Name = "btnTotalFrequencies";
            this.btnTotalFrequencies.Size = new System.Drawing.Size(128, 23);
            this.btnTotalFrequencies.TabIndex = 16;
            this.btnTotalFrequencies.Text = "Сводная Частотность";
            this.btnTotalFrequencies.UseVisualStyleBackColor = true;
            this.btnTotalFrequencies.Click += new System.EventHandler(this.btnTotalFrequencies_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpTo.CustomFormat = "dd.MMMM.yyyy HH:mm:ss";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(236, 423);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(176, 20);
            this.dtpTo.TabIndex = 51;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFrom.CustomFormat = "dd.MMMM.yyyy HH:mm:ss";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(14, 423);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(186, 20);
            this.dtpFrom.TabIndex = 50;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "С:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "По:";
            // 
            // CtrlHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(743, 447);
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
    }
}

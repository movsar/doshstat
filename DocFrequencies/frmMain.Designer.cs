namespace wFrequencies
{
    partial class frmMain
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
            if (disposing && (components != null))
            {
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtWorkingDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbWorkingDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.olvClmFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFiction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmSocPol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmReligious = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPoetry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvScientific = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvFiles = new BrightIdeasSoftware.ObjectListView();
            ((System.ComponentModel.ISupportInitialize)(this.olvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBrowse.Location = new System.Drawing.Point(548, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 22);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Выбрать";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtWorkingDir
            // 
            this.txtWorkingDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingDir.Location = new System.Drawing.Point(3, 23);
            this.txtWorkingDir.Name = "txtWorkingDir";
            this.txtWorkingDir.Size = new System.Drawing.Size(539, 20);
            this.txtWorkingDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Папка с обрабатываемыми файлами";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.Location = new System.Drawing.Point(548, 51);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Location = new System.Drawing.Point(7, 48);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(532, 29);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Выберите папку с входными файлами\r\n *.doc, *.docx, *.pdf, *.txt, *.odt, *.xlsx, *" +
    ".rtf, *.htm, *.html";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(1, 415);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 23);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Статус";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(319, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // olvClmFileName
            // 
            this.olvClmFileName.AspectName = "fileName";
            this.olvClmFileName.Groupable = false;
            this.olvClmFileName.Text = "Файл";
            this.olvClmFileName.Width = 300;
            // 
            // olvClmFiction
            // 
            this.olvClmFiction.AspectName = "isFiction";
            this.olvClmFiction.CheckBoxes = true;
            this.olvClmFiction.Groupable = false;
            this.olvClmFiction.Text = "Художественная";
            // 
            // olvClmSocPol
            // 
            this.olvClmSocPol.AspectName = "isSocPol";
            this.olvClmSocPol.CheckBoxes = true;
            this.olvClmSocPol.Groupable = false;
            this.olvClmSocPol.Text = "Социально-политическая";
            // 
            // olvClmReligious
            // 
            this.olvClmReligious.AspectName = "isReligious";
            this.olvClmReligious.CheckBoxes = true;
            this.olvClmReligious.Groupable = false;
            this.olvClmReligious.Text = "Религиозная";
            // 
            // olvClmPoetry
            // 
            this.olvClmPoetry.AspectName = "isPoetry";
            this.olvClmPoetry.CheckBoxes = true;
            this.olvClmPoetry.Groupable = false;
            this.olvClmPoetry.Text = "Поэтическая";
            // 
            // olvScientific
            // 
            this.olvScientific.AspectName = "isScientific";
            this.olvScientific.CheckBoxes = true;
            this.olvScientific.Groupable = false;
            this.olvScientific.Text = "Научная";
            // 
            // olvFiles
            // 
            this.olvFiles.AllColumns.Add(this.olvClmFileName);
            this.olvFiles.AllColumns.Add(this.olvClmFiction);
            this.olvFiles.AllColumns.Add(this.olvClmSocPol);
            this.olvFiles.AllColumns.Add(this.olvClmReligious);
            this.olvFiles.AllColumns.Add(this.olvClmPoetry);
            this.olvFiles.AllColumns.Add(this.olvScientific);
            this.olvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvFiles.CellEditUseWholeCell = false;
            this.olvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmFileName,
            this.olvClmFiction,
            this.olvClmSocPol,
            this.olvClmReligious,
            this.olvClmPoetry,
            this.olvScientific});
            this.olvFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvFiles.FullRowSelect = true;
            this.olvFiles.Location = new System.Drawing.Point(3, 88);
            this.olvFiles.Name = "olvFiles";
            this.olvFiles.Size = new System.Drawing.Size(623, 325);
            this.olvFiles.TabIndex = 9;
            this.olvFiles.UseCompatibleStateImageBehavior = false;
            this.olvFiles.View = System.Windows.Forms.View.Details;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 440);
            this.Controls.Add(this.olvFiles);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWorkingDir);
            this.Controls.Add(this.btnBrowse);
            this.Name = "frmMain";
            this.Text = "wFrequencies";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtWorkingDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbWorkingDir;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblInfo;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private BrightIdeasSoftware.OLVColumn olvClmFileName;
        private BrightIdeasSoftware.OLVColumn olvClmFiction;
        private BrightIdeasSoftware.OLVColumn olvClmSocPol;
        private BrightIdeasSoftware.OLVColumn olvClmReligious;
        private BrightIdeasSoftware.OLVColumn olvClmPoetry;
        private BrightIdeasSoftware.OLVColumn olvScientific;
        private BrightIdeasSoftware.ObjectListView olvFiles;
    }
}


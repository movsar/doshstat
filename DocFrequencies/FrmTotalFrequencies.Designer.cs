namespace wFrequencies
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
            this.olvClmWord = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmFrequency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvClmPercentage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvTotalFrequencies)).BeginInit();
            this.SuspendLayout();
            // 
            // olvTotalFrequencies
            // 
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmWord);
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmFrequency);
            this.olvTotalFrequencies.AllColumns.Add(this.olvClmPercentage);
            this.olvTotalFrequencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvTotalFrequencies.CellEditUseWholeCell = false;
            this.olvTotalFrequencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvClmWord,
            this.olvClmFrequency,
            this.olvClmPercentage});
            this.olvTotalFrequencies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTotalFrequencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvTotalFrequencies.FullRowSelect = true;
            this.olvTotalFrequencies.GridLines = true;
            this.olvTotalFrequencies.Location = new System.Drawing.Point(-5, -1);
            this.olvTotalFrequencies.Name = "olvTotalFrequencies";
            this.olvTotalFrequencies.ShowGroups = false;
            this.olvTotalFrequencies.Size = new System.Drawing.Size(469, 505);
            this.olvTotalFrequencies.TabIndex = 13;
            this.olvTotalFrequencies.UseAlternatingBackColors = true;
            this.olvTotalFrequencies.UseCompatibleStateImageBehavior = false;
            this.olvTotalFrequencies.UseFilterIndicator = true;
            this.olvTotalFrequencies.UseFiltering = true;
            this.olvTotalFrequencies.UseHotItem = true;
            this.olvTotalFrequencies.UseTranslucentHotItem = true;
            this.olvTotalFrequencies.View = System.Windows.Forms.View.Details;
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
            this.olvClmPercentage.Text = "Плотность";
            this.olvClmPercentage.Width = 92;
            // 
            // TotalFrequencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 503);
            this.Controls.Add(this.olvTotalFrequencies);
            this.Name = "TotalFrequencies";
            this.Text = "TotalFrequencies";
            this.Load += new System.EventHandler(this.TotalFrequencies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvTotalFrequencies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvTotalFrequencies;
        private BrightIdeasSoftware.OLVColumn olvClmWord;
        private BrightIdeasSoftware.OLVColumn olvClmFrequency;
        private BrightIdeasSoftware.OLVColumn olvClmPercentage;
    }
}
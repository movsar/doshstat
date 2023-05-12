using System;
using System.Windows.Forms;
using BrightIdeasSoftware;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DoshStat
{
    public partial class CtrlHistory : UserControl
    {
        public CtrlHistory()
        {
            InitializeComponent();
        }

        public void clearHistory()
        {
            olvHistory.ClearObjects();
        }

        // A flag to prevent olv from updating two times on start because of initializing elements
        private bool isReady = false;

        private void CtrlHistory_Load(object sender, EventArgs e)
        {
            olvHistory.SubItemChecking += delegate (object olvCheckSender, SubItemCheckingEventArgs olvCheckArgs)
            {
                // Set false all the other categories
                xTextFile rowObject = ((xTextFile)olvCheckArgs.RowObject);
                rowObject.isSelected = !rowObject.isSelected;

                // After completion it will set the new value
            };
            isReady = true;

            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(6, 23, 59, 59);
            dtpFrom.Value = dt.Subtract(ts);
            dtpTo.Value = dt.AddDays(1);
        }

        public void loadHistory()
        {
            Utils.history = DbHelper.GetHistory(dtpFrom.Value.ToString("yyyy-MM-dd HH:mm"), dtpTo.Value.ToString("yyyy-MM-dd HH:mm"));
            if (Utils.history != null)
            {
                Debug.WriteLine(Utils.history.Count);
                olvHistory.SetObjects(Utils.history);
            }
            else
            {
                olvHistory.ClearObjects();
            }


            olvHistory.PrimarySortColumn = olvHistory.GetColumn(0);
            olvHistory.PrimarySortOrder = SortOrder.Descending;
            olvHistory.Sort();
        }

        private void btnFullReport_Click(object sender, EventArgs e)
        {
            if (Utils.history == null) return;
            this.Enabled = false;
            FrmTotalDetails frmDetailedHistory = new FrmTotalDetails();
            frmDetailedHistory.Show();
            this.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Utils.history == null) return;
            this.Enabled = false;
            Utils.ExcelExport(olvHistory, "История");
            this.Enabled = true;
        }

        private void btnTotalFrequencies_Click(object sender, EventArgs e)
        {
            ShowFrequencies();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (isReady) loadHistory();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (isReady) loadHistory();
        }

        private void ShowFrequencies()
        {
            if (olvHistory.SelectedObjects.Count == 0)
            {
                MessageBox.Show("Выберите из списка данные обработки файла(ов)");
                return;
            }

            this.Enabled = false;

            if (olvHistory.SelectedObjects.Count > 1)
            {
                FrmMultipleFilesFrequencies frmTotalFrequencies = new FrmMultipleFilesFrequencies(olvHistory.SelectedObjects.Cast<xTextFile>());
                frmTotalFrequencies.Show();
            }
            else
            {
                FrmSingleFileFrequencies frmFreq = new FrmSingleFileFrequencies((xTextFile)(olvHistory.SelectedObject));
                frmFreq.Show();
            }

            this.Enabled = true;
        }

        private void olvHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                ShowFrequencies();
            }
        }
    }
}

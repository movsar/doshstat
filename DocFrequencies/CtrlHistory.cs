using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using System.Diagnostics;

namespace wFrequencies
{
    public partial class CtrlHistory : UserControl
    {
        public CtrlHistory()
        {
            InitializeComponent();
        }

        // A flag to prevent olv from updating two times on start because of initializing elements
        private bool isReady = false;

        private void CtrlHistory_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(6, 23, 59, 59);
            dtpFrom.Value = dt.Subtract(ts);
            dtpTo.Value = dt;

            olvHistory.SubItemChecking += delegate (object olvCheckSender, SubItemCheckingEventArgs olvCheckArgs) {
                // Set false all the other categories
                xTextFile rowObject = ((xTextFile)olvCheckArgs.RowObject);
                rowObject.isSelected = !rowObject.isSelected;

                // After completion it will set the new value
            };

            loadHistory();
            isReady = true;
        }

        private void olvHistory_DoubleClick(object sender, EventArgs e)
        {
            if (olvHistory.SelectedObject != null) {
                FrmFrequencies frmFreq = new FrmFrequencies((xTextFile)(olvHistory.SelectedObject));
                frmFreq.Show();
            }
        }


        private void loadHistory()
        {
            Utils.history = DbHelper.GetHistory(dtpFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtpTo.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            if (Utils.history != null) {
                Debug.WriteLine(Utils.history.Count);
                olvHistory.SetObjects(Utils.history);
            } else {
                olvHistory.ClearObjects();
            }
        }

        private void btnFullReport_Click(object sender, EventArgs e)
        {
            if (Utils.history == null) return;
            FrmDetailedHistory frmDetailedHistory = new FrmDetailedHistory();
            frmDetailedHistory.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Utils.history == null) return;
            Utils.ExcelExport(olvHistory, "История", false);
        }

        private void btnTotalFrequencies_Click(object sender, EventArgs e)
        {
            if (Utils.history == null) return;
            FrmTotalFrequencies frmTotalFrequencies = new FrmTotalFrequencies();
            frmTotalFrequencies.Show();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (isReady)loadHistory();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (isReady) loadHistory();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace wFrequencies
{
    public partial class CtrlHistory : UserControl
    {
        public CtrlHistory()
        {
            InitializeComponent();
        }


        private void CtrlHistory_Load(object sender, EventArgs e)
        {
            loadHistory();
            olvHistory.SubItemChecking += delegate (object olvCheckSender, SubItemCheckingEventArgs olvCheckArgs) {
                // Set false all the other categories
                xTextFile rowObject = ((xTextFile)olvCheckArgs.RowObject);
                rowObject.isSelected = !rowObject.isSelected;

                // After completion it will set the new value
            };
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
            Utils.history = DbHelper.GetHistory();
            olvHistory.SetObjects(Utils.history);
        }

        private void btnFullReport_Click(object sender, EventArgs e)
        {
            FrmDetailedHistory frmDetailedHistory = new FrmDetailedHistory();
            frmDetailedHistory.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Utils.ExcelExport(olvHistory, "История", false);
        }
    }
}

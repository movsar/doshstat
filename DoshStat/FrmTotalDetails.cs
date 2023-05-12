using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using System.Diagnostics;

namespace DoshStat
{
    public partial class FrmTotalDetails : Form
    {
        public FrmTotalDetails()
        {
            tFilesArray = Utils.history;
            InitializeComponent();
        }
        public FrmTotalDetails(List<xTextFile> list)
        {
            tFilesArray = list;
            InitializeComponent();
        }

        List<xTextFile> tFilesArray;

        private void FrmDetailedHistory_Load(object sender, EventArgs e)
        {
            List<xDetails> rowObjects = new List<xDetails>();
            if (tFilesArray.Count == 0) return;
            foreach (xTextFile fileInfo in tFilesArray)
            {
                string fileName = fileInfo.fileName;
                int categoryIndex = fileInfo.categoryIndex;
                int wordsCount = fileInfo.wordsCount;
                int uniqueWordsCount = fileInfo.uniqueWordsCount;
                string created_at = fileInfo.created_at;
                foreach (xWordFrequencies xwf in fileInfo.frequencies)
                {
                    xDetails rowObject = new xDetails();
                    rowObject.fileName = fileName;
                    rowObject.categoryIndex = categoryIndex;
                    rowObject.wordsCount = wordsCount;
                    rowObject.uniqueWordsCount = uniqueWordsCount;
                    rowObject.created_at = created_at;
                    rowObject.wordId = xwf.id;
                    rowObject.word = xwf.word;
                    rowObject.frequency = xwf.frequency;
                    rowObject.percentage = xwf.percentage;
                    rowObjects.Add(rowObject);
                }
            }

            olvDetailedHistory.SetObjects(rowObjects);

            olvDetailedHistory.PrimarySortColumn = olvDetailedHistory.GetColumn(0);
            olvDetailedHistory.PrimarySortOrder = SortOrder.Descending;
            olvDetailedHistory.Sort();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            Utils.ExcelExport(olvDetailedHistory, Utils.GetFormStringResource<FrmTotalDetails>("DetailedReport"));
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (xDetails o in olvDetailedHistory.SelectedObjects)
            {
                long res = DbHelper.RemoveReq(DbHelper.TABLE_FREQUENCIES, o.wordId);
                olvDetailedHistory.RemoveObject(o);
                Debug.WriteLine(o.word + res);
            }
        }

        private void FrmTotalDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            int objectsInReality = olvDetailedHistory.Items.Count;
            int objectsInLoadedData = 0;

            foreach (xTextFile fileInfo in tFilesArray)
            {
                foreach (xWordFrequencies xwf in fileInfo.frequencies)
                {
                    objectsInLoadedData++;
                    xDetails rowObject = new xDetails();
                }
            }
            if (objectsInLoadedData != objectsInReality) Utils.history = DbHelper.GetHistory("", "");
        }
    }
}

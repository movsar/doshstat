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

namespace wFrequencies
{
    public partial class FrmTotalDetails : Form
    {
        public FrmTotalDetails()
        {
            InitializeComponent();
        }

        private void FrmDetailedHistory_Load(object sender, EventArgs e)
        {
            List<xDetails> rowObjects = new List<xDetails>();

            foreach (xTextFile fileInfo in Utils.history) {


                string fileName = fileInfo.fileName;
                int categoryIndex = fileInfo.categoryIndex;
                int wordsCount = fileInfo.wordsCount;
                int uniqueWordsCount = fileInfo.uniqueWordsCount;
                string created_at = fileInfo.created_at;
                foreach (xWordFrequencies xwf in fileInfo.frequencies) {
                    xDetails rowObject = new xDetails();
                    rowObject.fileName = fileName;
                    rowObject.categoryIndex = categoryIndex;
                    rowObject.wordsCount = wordsCount;
                    rowObject.uniqueWordsCount = uniqueWordsCount;
                    rowObject.created_at = created_at;
                    rowObject.word = xwf.word;
                    rowObject.frequency = xwf.frequency;
                    rowObject.percentage = xwf.percentage;
                    rowObjects.Add(rowObject);
                }
            }

            olvDetailedHistory.SetObjects(rowObjects);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Utils.ExcelExport(olvDetailedHistory, "Подробная История", false);
        }
    }
}

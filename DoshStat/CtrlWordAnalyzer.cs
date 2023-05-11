using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoshStat
{
    public partial class CtrlWordAnalyzer : UserControl
    {
        public CtrlWordAnalyzer()
        {
            InitializeComponent();
        }

        private void search()
        {
            if (txtWord.Text.Length < 1) return;

            string word = txtWord.Text.Substring(0, 1).ToUpper() + txtWord.Text.Substring(1);
            List<xWordFrequencies> searchResults = DbHelper.FindInFrequencies(word);
            if (searchResults == null) {
                olvSearchResults.ClearObjects();
                ((FrmMain)this.Parent.Parent.Parent).lblStatus.Text = string.Format("Ничего не найдено");
                return;
            }

            List<xDetails> rowObjects = new List<xDetails>();

            foreach (xWordFrequencies xwf in searchResults) {
                xTextFile fileInfo = Utils.GetTextFile(xwf.fileId);

                xDetails rowObject = new xDetails();
                rowObject.fileId = fileInfo.fileId;
                rowObject.fileName = fileInfo.fileName;
                rowObject.categoryIndex = fileInfo.categoryIndex;
                rowObject.wordsCount = fileInfo.wordsCount;
                rowObject.uniqueWordsCount = fileInfo.uniqueWordsCount;
                rowObject.created_at = fileInfo.created_at;
                rowObject.word = xwf.word;
                rowObject.frequency = xwf.frequency;
                rowObject.percentage = xwf.percentage;
                rowObjects.Add(rowObject);
            }
            olvSearchResults.SetObjects(rowObjects);
            ((FrmMain)this.Parent.Parent.Parent).lblStatus.Text = string.Format("Найдено в {0} файлах(е)", rowObjects.GroupBy(xFile => xFile.fileId).Select(grp => grp.First()).ToList().Count.ToString());
            olvSearchResults.PrimarySortColumn = olvSearchResults.GetColumn(0);
            olvSearchResults.PrimarySortOrder = SortOrder.Descending;
            olvSearchResults.Sort();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void olvSearchResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                if (olvSearchResults.SelectedObject != null) {
                    FrmFrequencies frmFreq = new FrmFrequencies(Utils.GetTextFile(((xDetails)olvSearchResults.SelectedObject).fileId), ((xDetails)olvSearchResults.SelectedObject).word);
                    frmFreq.Show();
                }
            }
        }

        private void txtWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                search();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (olvSearchResults.Items.Count != 0)
                Utils.ExcelExport(olvSearchResults, "Результаты поиска");
        }
    }
}
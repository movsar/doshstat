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
            List<xDetails> searchResults = DbHelper.FindInFrequencies(word);
            if (searchResults == null)
            {
                olvSearchResults.ClearObjects();

                ((FrmMain)this.Parent.Parent.Parent).lblStatus.Text = string.Format(Utils.GetFormStringResource<CtrlWordAnalyzer>("NothingFound"));
                return;
            }
            olvSearchResults.SetObjects(searchResults);
            var results = searchResults.GroupBy(xFile => xFile.fileId).Select(grp => grp.First());
            var resultsCount = results.Count().ToString();
            var strFoundIn = Utils.GetFormStringResource<CtrlWordAnalyzer>("FoundIn");
            ((FrmMain)this.Parent.Parent.Parent).lblStatus.Text = string.Format(strFoundIn, resultsCount);
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
            if (e.Button == MouseButtons.Left)
            {
                if (olvSearchResults.SelectedObject != null)
                {
                    FrmSingleFileFrequencies frmFreq = new FrmSingleFileFrequencies(Utils.GetTextFile(((xDetails)olvSearchResults.SelectedObject).fileId), ((xDetails)olvSearchResults.SelectedObject).word);
                    frmFreq.Show();
                }
            }
        }

        private void txtWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (olvSearchResults.Items.Count != 0)
                Utils.ExcelExport(olvSearchResults, Utils.GetFormStringResource<CtrlWordAnalyzer>("SearchResults"));
        }
    }
}
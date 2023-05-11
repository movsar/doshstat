using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoshStat
{
    public partial class FrmTotalFrequencies : Form
    {
        public FrmTotalFrequencies()
        {
            InitializeComponent();
        }

        private void TotalFrequencies_Load(object sender, EventArgs e)
        {
            List<xWordFrequencies> totalFrequencies = DbHelper.GetCombinedFrequencies();
            olvTotalFrequencies.SetObjects(totalFrequencies);
            lblCharactersCount.Text += DbHelper.CHARACTERS_COUNT.ToString();
            lblUniqueWords.Text += totalFrequencies.Count.ToString();
            lblFilesCount.Text += DbHelper.FILES_COUNT.ToString();
            lblWordCount.Text += DbHelper.WORDS_COUNT.ToString();

            olvTotalFrequencies.PrimarySortColumn = olvTotalFrequencies.GetColumn(0);
            olvTotalFrequencies.PrimarySortOrder = SortOrder.Descending;
            olvTotalFrequencies.Sort();
        }

        private void olvTotalFrequencies_SelectionChanged(object sender, EventArgs e)
        {
            string lblWordsCountPrefix = "Выделено слов: ";
            string lblWordsPercentagePrefix = "Выделено в процентах: ";
            string lblWordsFrequenciesPrefix = "Сумма выделенных частот: ";

            lblSelectedWordsCount.Text = lblWordsCountPrefix + olvTotalFrequencies.SelectedObjects.Count.ToString();
            float sumPercentage = 0;
            int sumFrequencies = 0;
            foreach (var obj in olvTotalFrequencies.SelectedObjects) {
                xWordFrequencies xwf = (xWordFrequencies)obj;
                sumPercentage += xwf.percentage;
                sumFrequencies += xwf.frequency;
            }
            lblSelectedWordsPercentage.Text = lblWordsPercentagePrefix + sumPercentage.ToString("F") + "%";
            lblSelectedFrequency.Text = lblWordsFrequenciesPrefix + sumFrequencies.ToString();
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            Utils.ExcelExport(olvTotalFrequencies, "Сводная Частотность");
        }
    }
}

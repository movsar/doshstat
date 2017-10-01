using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFrequencies
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
        }

        private void olvTotalFrequencies_SelectionChanged(object sender, EventArgs e)
        {
            string lblWordsCountPrefix = "Выделено слов: ";
            string lblWordsPercentagePrefix = "Выделено в процентах: ";

            lblSelectedWordsCount.Text = lblWordsCountPrefix + olvTotalFrequencies.SelectedObjects.Count.ToString();
            float sumPercentage = 0;
            foreach (var obj in olvTotalFrequencies.SelectedObjects) {
                xWordFrequencies xwf = (xWordFrequencies)obj;
                sumPercentage += xwf.percentage;
            }
            lblSelectedWordsPercentage.Text = lblWordsPercentagePrefix + sumPercentage.ToString("F") + "%";
        }
    }
}

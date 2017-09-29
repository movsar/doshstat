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
    public partial class FrmFrequencies : Form
    {
        private xTextFile _xFile;

        public FrmFrequencies(xTextFile xFile)
        {
            InitializeComponent();

            _xFile = xFile;
            lblCategory.Text += xFile.getCategoryName();
            lblCharactersCount.Text += xFile.charactersCount.ToString();
            lblFileName.Text += xFile.fileName;
            lblUniqueWords.Text += xFile.uniqueWordsCount.ToString();
            lblWordCount.Text += xFile.wordsCount.ToString();
            olvFrequencies.SetObjects(xFile.frequencies);
        }

        private void frmFrequencies_Load(object sender, EventArgs e)
        {
            olvFrequencies.PrimarySortColumn = (olvFrequencies.GetColumn(1));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Utils.OlvToExcelExport(olvFrequencies, _xFile.fileName);
        }

        private void olvFrequencies_SelectionChanged(object sender, EventArgs e)
        {
            string lblWordsCountPrefix = "Выделено слов: ";
            string lblWordsPercentagePrefix = "Выделено в процентах: ";

            lblSelectedWordsCount.Text = lblWordsCountPrefix + olvFrequencies.SelectedObjects.Count.ToString();
            float sumPercentage = 0;
            foreach (var obj in olvFrequencies.SelectedObjects) {
                xWordFrequencies xwf = (xWordFrequencies)obj;
                sumPercentage += xwf.percentage;
            }
            lblSelectedWordsPercentage.Text = lblWordsPercentagePrefix + sumPercentage.ToString("F") + "%";
        }
    }
}

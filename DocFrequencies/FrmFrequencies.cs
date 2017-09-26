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
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Utils.OlvToExcelExport(olvFrequencies, _xFile.fileName);
        }
    }
}

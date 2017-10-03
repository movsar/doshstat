using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrangeWords
{
    public partial class CtrlWordAnalyzer : UserControl
    {
        public CtrlWordAnalyzer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Substring(0, 1).ToUpper() + txtWord.Text.Substring(1);
            List<xTextFile> searchResults = DbHelper.FindWord(word);
            List<xDetails> rowObjects = new List<xDetails>();

            foreach (xTextFile fileInfo in searchResults) {
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
            olvSearchResults.SetObjects(rowObjects);
        }
    }
}

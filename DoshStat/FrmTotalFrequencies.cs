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
    public partial class FrmMultipleFilesFrequencies : Form
    {
        private readonly IEnumerable<xTextFile> _selectedFiles;

        public FrmMultipleFilesFrequencies(IEnumerable<xTextFile> enumerable)
        {
            InitializeComponent();

            _selectedFiles = enumerable;
        }

        private List<xWordFrequencies> GetFrequencies()
        {
            var combinedWordInfos = _selectedFiles.SelectMany(xtf => xtf.frequencies);

            // List for the all unique frequencies
            var uniqueWordInfos = new List<xWordFrequencies>();
            float totalFrequency = 0;
            foreach (var xwf in combinedWordInfos)
            {
                // If our list already has such word, don't add new element but change it
                var existing = uniqueWordInfos.FirstOrDefault(x => x.word.Equals(xwf.word));
                if (existing != null)
                {
                    // Combine frequency
                    existing.frequency += xwf.frequency;
                }
                else
                {
                    uniqueWordInfos.Add(xwf);
                }

                totalFrequency += xwf.frequency;
            }

            // Recalculate ranks and percentage
            int rank = 0;
            int prevFrequency = int.MaxValue;
            int topFrequency = 0;

            foreach (var xwf in uniqueWordInfos.OrderByDescending(xwf => xwf.frequency))
            {

                if (rank != 1)
                {
                    // It's not the first iteration
                    if (xwf.frequency != prevFrequency)
                    {
                        rank++;
                        topFrequency = xwf.frequency;
                    }
                }
                else
                {
                    rank++;
                    topFrequency = xwf.frequency;
                }

                xwf.rank = rank;
                xwf.percentage = xwf.frequency / totalFrequency * 100;
                prevFrequency = xwf.frequency;
            }

            return uniqueWordInfos;
        }
        private void TotalFrequencies_Load(object sender, EventArgs e)
        {
            var totalFrequencies = GetFrequencies();
            var totalWordsCount = _selectedFiles.Sum(file => file.wordsCount);
            var totalUniqueWordsCount = _selectedFiles.Sum(file => file.uniqueWordsCount);
            var totalCharactersCount = _selectedFiles.SelectMany(file => file.frequencies)
                                                     .Sum(xwf => xwf.word.Length);

            olvTotalFrequencies.SetObjects(totalFrequencies);
            lblCharactersCount.Text += totalCharactersCount.ToString();
            lblUniqueWords.Text += totalFrequencies.Count.ToString();
            lblFilesCount.Text += _selectedFiles.Count().ToString();
            lblWordCount.Text += totalWordsCount.ToString();

            olvTotalFrequencies.PrimarySortColumn = olvTotalFrequencies.GetColumn(0);
            olvTotalFrequencies.PrimarySortOrder = SortOrder.Ascending;
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
            foreach (var obj in olvTotalFrequencies.SelectedObjects)
            {
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

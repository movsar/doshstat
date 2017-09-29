using BrightIdeasSoftware;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using SpreadsheetLight.Charts;
using System;
using System.Windows.Forms;

namespace wFrequencies
{
    public class DataExporter
    {
        public static void Export(ObjectListView olv, string filePath)
        {
            SLDocument sl = new SLDocument();
            SLStyle style = sl.CreateStyle();

            //   sl.SetCellStyle(6, 5, style);



            for (int i = 1; i <= olv.Columns.Count; ++i) {
                sl.SetCellValue(1, i, olv.Columns[i - 1].Text);
            }


            for (int i = 1; i <= olv.Columns.Count; ++i) {
                for (int j = 1; j <= olv.Items.Count; ++j) {
                    string cellVal = olv.Items[j - 1].SubItems[i - 1].Text;
                    System.Drawing.Color backColor = olv.Items[j - 1].BackColor;
                    System.Drawing.Color foreColor = olv.Items[j - 1].ForeColor;


                    style.Fill.SetPattern(PatternValues.Solid, backColor, foreColor);

                    sl.SetCellValue(j + 1, i, cellVal);
                    sl.SetCellStyle(j + 1, i, style);
                }
            }

            sl.SaveAs(filePath);
        }
    }
}

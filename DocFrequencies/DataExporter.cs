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
        public static void Export(ObjectListView olv, string filePath, bool withStyle)
        {
            SLDocument sl = new SLDocument();
            SLStyle style = sl.CreateStyle();

            for (int i = 1; i <= olv.Columns.Count; ++i) {
                sl.SetCellValue(1, i, olv.Columns[i - 1].Text);
            }


            for (int i = 1; i <= olv.Columns.Count; ++i) {
                for (int j = 1; j <= olv.Items.Count; ++j) {
                    string cellVal = olv.Items[j - 1].SubItems[i - 1].Text;

                    sl.SetCellValue(j + 1, i, cellVal);

                    if (withStyle) {
                        System.Drawing.Color backColor = olv.Items[j - 1].BackColor;
                        System.Drawing.Color foreColor = olv.Items[j - 1].ForeColor;
                        style.Fill.SetPattern(PatternValues.Solid, backColor, foreColor);
                        sl.SetCellStyle(j + 1, i, style);
                    }
                }
            }

            SLTable tbl = sl.CreateTable(1, 1, olv.Items.Count + 1, olv.Columns.Count);
            if (!withStyle) tbl.SetTableStyle(SLTableStyleTypeValues.Medium4);

            tbl.Sort(1, false);
            sl.InsertTable(tbl);

            sl.SaveAs(filePath);
        }
    }
}

using BrightIdeasSoftware;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using SpreadsheetLight.Charts;
using System;

namespace wFrequencies
{
    public class DataExporter
    {
        public static void Export(ObjectListView olv, string filePath)
        {
            SLDocument sl = new SLDocument();
            SLStyle slstyle = new SLStyle();
            slstyle.Fill.PatternBackgroundColor = Color.Red;


            sl.SetCellValue("B3", "It costs what for a Jimmy Choo?!?");
            sl.SetCellStyle("B3", slstyle);

            // POOF! Chart done.

            sl.SaveAs(filePath);
        }
    }
}

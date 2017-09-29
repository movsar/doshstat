using BrightIdeasSoftware;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFrequencies
{
    public class DataExporter
    {

        public static void Export(ObjectListView olv, string filePath)
        {
            SLDocument sl = new SLDocument();
            SLTable tbl = sl.CreateTable("B2", "G6");
            tbl.SetTableStyle(SLTableStyleTypeValues.Medium4);
            sl.InsertTable(tbl);
            // POOF! Table appears.
        }
    }
}

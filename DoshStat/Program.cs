using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoshStat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var currentCulture = Utils.StgGetString("CurrentCulture");
            if (!string.IsNullOrWhiteSpace(currentCulture))
            {
                CultureInfo russianCulture = new CultureInfo(currentCulture);
                Thread.CurrentThread.CurrentUICulture = russianCulture;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}

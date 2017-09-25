using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace wFrequencies
{
    class TxtProcessor : ITextProcessor
    {
        // Make it into a singleton
        private static readonly ITextProcessor _instance = new TxtProcessor();
        public static ITextProcessor GetInstance() { return _instance; }
        private TxtProcessor() { }

        public string GetAllText(string path)
        {
            using (StreamReader reader = new StreamReader(path, Encoding.GetEncoding(1251), true))
            {
                reader.Peek(); // you need this!
                var encoding = reader.CurrentEncoding;
                return File.ReadAllText(path, encoding);
            }
        }
    }
}

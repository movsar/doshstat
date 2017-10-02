using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StrangeWords
{
    public class RtfProcessor : ITextProcessor
    {
        // Make it into a singleton
        private static readonly ITextProcessor _instance = new RtfProcessor();
        public static ITextProcessor GetInstance() { return _instance; }
        RichTextBox rtb;
        private RtfProcessor() { rtb = new RichTextBox(); }

        public string GetAllText(string path)
        {
            rtb.Rtf = File.ReadAllText(path);
            return rtb.Text;
        }
    }
}

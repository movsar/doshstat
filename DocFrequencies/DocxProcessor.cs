using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Windows.Forms;

namespace wFrequencies
{
    public sealed class DocxProcessor : ITextProcessor
    {
        // Make it into a singleton
        private static readonly ITextProcessor _instance = new DocxProcessor();
        public static ITextProcessor GetInstance() { return _instance; }
        private DocxProcessor() { }

        public string GetAllText(string path)
        {
            CSUsingOpenXmlPlainText.GetWordPlainText docxReaderObj = new CSUsingOpenXmlPlainText.GetWordPlainText(path);
            return docxReaderObj.ReadWordDocument();
        }
    }
}
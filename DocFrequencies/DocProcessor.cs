using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFrequencies
{
    public sealed class DocProcessor : ITextProcessor
    {
        // Make it into a singleton
        private static readonly ITextProcessor _instance = new DocProcessor();
        public static ITextProcessor GetInstance() { return _instance; }
        static Application wordApplication; // Make only one instance to make it work faster
        private DocProcessor() { wordApplication = new Microsoft.Office.Interop.Word.Application(); }

        public string GetAllText(string path)
        {
            try
            {
                var srcFile = new FileInfo(path);
                var doc = wordApplication.Documents.Open(srcFile.FullName);
                return doc.Content.Text;
            }
            finally
            {
                // we want to make sure the document is always closed 
                wordApplication.ActiveDocument.Close();
            }
        }

        public static void Dispose() {
            wordApplication.Quit();
        }
    }
}

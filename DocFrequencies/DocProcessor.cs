using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private DocProcessor() { }

        public string GetAllText(string path)
        {
            try {
                if (wordApplication == null) wordApplication = new Microsoft.Office.Interop.Word.Application();
                var srcFile = new FileInfo(path);
                var doc = wordApplication.Documents.Open(srcFile.FullName);
                return doc.Content.Text;
            } finally {
                // we want to make sure the document is always closed 
                wordApplication.ActiveDocument.Close();
            }
        }

        public static void Dispose()
        {
            try {
                wordApplication.Quit();
            } catch (Exception ex) {
                Debug.WriteLine("couldn't close the app");
            }
        }
    }
}

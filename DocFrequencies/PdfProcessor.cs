using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrangeWords
{
    class PdfProcessor : ITextProcessor
    {
        // Make it into a singleton
        private static readonly ITextProcessor _instance = new PdfProcessor();
        public static ITextProcessor GetInstance() { return _instance; }
        private PdfProcessor() { }


        public string GetAllText(string path)
        {
            return pdfText(path);
        }

        public static string pdfText(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++) {
                try {
                    text += PdfTextExtractor.GetTextFromPage(reader, page);
                } catch (Exception ex) {
                    Utils.ErrLog("Error processing page: " + page.ToString(), ex.Message);
                }
            }
            reader.Close();
            return text;
        }
    }
}

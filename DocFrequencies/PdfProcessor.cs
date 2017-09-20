using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFrequencies
{
    class PdfProcessor
    {
        public string GetAllText()
        {
            string allText = "";
            foreach (string filePath in (new Utils()).FindFilesRecursively("*.pdf"))
            {
                allText += pdfText(filePath);
            }
            return allText;
        }

        public static string pdfText(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            return text;
        }
    }
}

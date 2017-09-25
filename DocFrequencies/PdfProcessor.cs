using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFrequencies
{
    class PdfProcessor : ITextProcessor
    {
        // Make it into a singleton
        private static readonly ITextProcessor _instance = new PdfProcessor();
        public static ITextProcessor GetInstance() { return _instance; }
        private PdfProcessor() { }


        public string GetAllText()
        {
            var form = Form.ActiveForm as frmMain;
            form.lblStatus.Text = "Читаю Pdf ... ";
            form.Refresh();

            string allText = "";

            foreach (xTextFile file in Utils.fList.Where((x) => x.fileName.EndsWith("pdf"))) {
                allText += pdfText(file.filePath);
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

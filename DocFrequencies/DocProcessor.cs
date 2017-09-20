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

namespace DocFrequencies
{
    class DocProcessor
    {

        private void ConvertDocToDocx()
        {
            // only open and close Word once to maximize performance 
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            try
            {
                int affectedFiles = 0;
                foreach (string filename in (new Utils()).FindFilesRecursively("*.doc"))
                {
                    // exclude the .docx (only include .doc) files as we don't need to convert them. :) 
                    if (filename.ToLower().EndsWith(".doc"))
                    {
                        try
                        {
                            var srcFile = new FileInfo(filename);

                            // convert the source file 
                            var doc = word.Documents.Open(srcFile.FullName);
                            string newFilename = srcFile.FullName.Replace(".doc", ".docx");

                            // Be sure to include the correct reference to Microsoft.Office.Interop.Word 
                            // in the project refences. In this case we need version 12 of Office to get the new formats. 
                            doc.SaveAs(FileName: newFilename, FileFormat: WdSaveFormat.wdFormatXMLDocument);
                            affectedFiles++;
                        }
                        finally
                        {
                            // we want to make sure the document is always closed 
                            word.ActiveDocument.Close();
                        }
                    }
                }
            }
            finally
            {
                // Close the word application
                word.Quit();
            }
        }

        public string GetAllText()
        {
            var form = Form.ActiveForm as frmMain;
            form.lblStatus.Text = "Читаю Doc и Docx ... ";
            form.Refresh();

            ConvertDocToDocx();
            string allText = "";
            foreach (string filePath in (new Utils()).FindFilesRecursively("*.docx"))
            {
                CSUsingOpenXmlPlainText.GetWordPlainText docxReaderObj = new CSUsingOpenXmlPlainText.GetWordPlainText(filePath);
                allText += docxReaderObj.ReadWordDocument();
            }
            return allText;
        }
    }
}
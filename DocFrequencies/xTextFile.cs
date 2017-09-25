using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace wFrequencies
{
    public class xTextFile
    {
        public String filePath { get; set; }
        public String fileName;

        public bool isFiction { get; set; }
        public bool isReligious { get; set; }
        public bool isSocPol { get; set; }
        public bool isPoetry { get; set; }
        public bool isScientific { get; set; }

        public bool isProcessed { get; set; }
        public bool isProblematic { get; set; }


        public ITextProcessor Processor { get; set; }
        public xTextFile(string filePath)
        {

            this.filePath = filePath;
            fileName = (new FileInfo(filePath)).Name;
            if (fileName.EndsWith("doc") || fileName.EndsWith("docx")) {
                Processor = DocProcessor.GetInstance();
            } else if (fileName.EndsWith("htm") || fileName.EndsWith("html")) {
                Processor = HtmProcessor.GetInstance();
            } else if (fileName.EndsWith("odt")) {
                Processor = OdtProcessor.GetInstance();
            } else if (fileName.EndsWith("pdf")) {
                Processor = PdfProcessor.GetInstance();
            } else if (fileName.EndsWith("rtf")) {
                Processor = RtfProcessor.GetInstance();
            } else if (fileName.EndsWith("txt")) {
                Processor = TxtProcessor.GetInstance();
            } else if (fileName.EndsWith("xlsx")) {
                Processor = XlsProcessor.GetInstance();
            }
        }
    }
}
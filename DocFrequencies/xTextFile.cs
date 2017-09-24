using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DocFrequencies
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

        public xTextFile(string filePath) {
            this.filePath = filePath;
            fileName = (new FileInfo(filePath)).Name;
        }
    }
}

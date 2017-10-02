using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeWords
{
    public class xWordFrequencies
    {
        public long id { get; set; }
        public long fileId { get; set; }
        public string word { get; set; }
        public int frequency { get; set; }
        public float percentage { get; set; }
    }
}

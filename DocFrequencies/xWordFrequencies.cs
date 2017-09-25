using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFrequencies
{
    public class xWordFrequencies
    {
        public int id { get; set; }
        public int fileId { get; set; }
        public string word { get; set; }
        public int frequency { get; set; }
        public string created_at { get; set; }
    }
}

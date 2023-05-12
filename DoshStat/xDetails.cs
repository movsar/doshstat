using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoshStat
{
    public class xDetails
    {        
        public long fileId { get; set; }
        public String fileName { get; set; }
        public int wordsCount { get; set; }
        public int charactersCount { get; set; }
        public int uniqueWordsCount { get; set; }
        public int categoryIndex { get; set; }
        public string created_at { get; set; }

        public string getCategoryName()
        {
            switch (categoryIndex) {
                case 1:
                    return "Художественная";
                case 2:
                    return "Социально - Политическая";
                case 3:
                    return "Религиозная";
                case 4:
                    return "Поэтическая";
                case 5:
                    return "Научная";
            }
            return "Неизвестно";
        }
        public string getNeatPercentage() {
            return percentage.ToString("F") + "%";
        }

        public long wordId { get; set; }
        public string word { get; set; }
        public int frequency { get; set; }
        public float percentage { get; set; }
   

    }
}

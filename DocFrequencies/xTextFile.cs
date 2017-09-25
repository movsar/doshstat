using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace wFrequencies
{
    public class xTextFile
    {
        public long id { get; set; }
        public String fileName { get; set; }
        public int wordsCount { get; set; }
        public int category { get; set; }
        public string created_at { get; set; }

        public String filePath { get; set; }

        public bool isFiction { get; set; }
        public bool isReligious { get; set; }
        public bool isSocPol { get; set; }
        public bool isPoetry { get; set; }
        public bool isScientific { get; set; }

        public bool isProcessed { get; set; }
        public bool isProblematic { get; set; }

        public List<xWordFrequencies> frequencies { get; set; }
        public ITextProcessor Processor { get; set; }
        public xTextFile(string filePath)
        {
            this.frequencies = new List<xWordFrequencies>();
            this.filePath = filePath;
            fileName = (new FileInfo(filePath)).Name;
            if (fileName.EndsWith(".docx"))
            {
                Processor = DocProcessor.GetInstance();
            }
            else if (fileName.EndsWith("htm") || fileName.EndsWith("html"))
            {
                Processor = HtmProcessor.GetInstance();
            }
            else if (fileName.EndsWith("odt"))
            {
                Processor = OdtProcessor.GetInstance();
            }
            else if (fileName.EndsWith("pdf"))
            {
                Processor = PdfProcessor.GetInstance();
            }
            else if (fileName.EndsWith("rtf"))
            {
                Processor = RtfProcessor.GetInstance();
            }
            else if (fileName.EndsWith("txt"))
            {
                Processor = TxtProcessor.GetInstance();
            }
            else if (fileName.EndsWith("xlsx"))
            {
                Processor = XlsProcessor.GetInstance();
            }
        }


        public void save()
        {
            Dictionary<string, object> nameValueData = new Dictionary<string, object>();

            nameValueData.Add("file_name", fileName);
            nameValueData.Add("words_count", wordsCount);
            nameValueData.Add("unique_words_count", frequencies.Count);
            nameValueData.Add("category", category);
            nameValueData.Add("created_at", DbHelper.GetCurrentDateTime());

            id = DbHelper.InsertReq("wf_files", nameValueData);
            if (id != -1)
            {
                // Ok                    
            }

        }
    }
    /*
     * 



     






   



   

    
    

    
        public static bool ContainsInColumn(ListView lv, string colTitle, string value) {
            int colIndex = GetColumnIndex(lv, colTitle);
            if (colIndex == -1) return false;

            foreach (ListViewItem li in lv.Columns[colIndex].ListView.Items) {
                if (li.Text.ToLower().Equals(value.ToLower())) {
                    return true;
                }
            }
            return false;
        }


        public static ListViewItem GetLVIByValue(ListView lv, string colTitle, string value) {
            int colIndex = GetColumnIndex(lv, colTitle);
            foreach (ListViewItem li in lv.Columns[colIndex].ListView.Items) {
                if (li.Text.ToLower().Equals(value.ToLower())) {
                    return li;
                }
            }
            return null;
        }

        public static long UpdateReq(string table, Dictionary<string, object> nameValueData, long id) {
            MySqlCommand comm = new MySqlCommand();

            string req = "UPDATE " + table;
            req += " SET ";
            foreach (string name in nameValueData.Keys) {
                req += name + "=@" + name + ",";
            }
            // Remove "," from the end
            req = req.TrimLastCharacter() + " WHERE id = " + id;
            comm.CommandText = req;

            foreach (KeyValuePair<string, object> nameValue in nameValueData) {
                comm.Parameters.AddWithValue("@" + nameValue.Key, nameValue.Value);
            }

            return DbExecuteNonQuery(comm);
        }

    
        public static long RemoveReq(string table, long id) {
            using (MySqlConnection connection = new MySqlConnection(Shared.myConnectionString)) {
                try {
                    connection.Open();
                    MySqlDataReader reader;

                    var cmd = new MySqlCommand("DELETE from `" + table + "` WHERE `id`=" + id.ToString() + "", connection);
                    reader = cmd.ExecuteReader();
                    return reader.RecordsAffected;
                } catch (Exception ex) {
                    Logging(ex);
                    return -1;
                }
            }
        }

    
     */
}
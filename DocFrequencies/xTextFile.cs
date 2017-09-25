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

    /*
     * 
     * chaldic
chladic_usr
chaldic=Z1


       private static List<xCanteenOrder> GetFromOrders(string query) {
            List<xCanteenOrder> list = new List<xCanteenOrder>();
            using (MySqlConnection conn = new MySqlConnection(Shared.myConnectionString)) {
                using (MySqlCommand cmd = conn.CreateCommand()) {
                    conn.Open();
                    cmd.CommandText = query;
                    MySqlDataReader Reader;
                    Reader = cmd.ExecuteReader();
                    if (!Reader.HasRows) return null;

                    while (Reader.Read()) {
                        xCanteenOrder order = new xCanteenOrder() {
                            Id = Convert.ToInt64(Shared.GetDBInt64("id", Reader)),
                            OperatorId = Convert.ToInt64(Shared.GetDBInt64("operator_id", Reader)),
                            UserId = Convert.ToInt64(Shared.GetDBInt64("user_id", Reader)),
                            MenuId = Convert.ToInt64(Shared.GetDBInt64("menu_id", Reader)),
                            CreationDate = Shared.GetDBString("c_date", Reader),
                            UpdatedDate = Shared.GetDBString("u_date", Reader),
                            Status = Shared.GetDBString("status", Reader),
                            ChosenMeals = (List<xCanteenMeal>)(JsonConvert.DeserializeObject(Shared.GetDBString("meals", Reader), typeof(List<xCanteenMeal>)))
                        };

                        list.Add(order);
                    }
                    Reader.Close();
                    conn.Close();
                }

            }

            return list;
        }






      Dictionary<string, object> nameValueData = new Dictionary<string, object>();
                nameValueData.Add("operator_id", WorkingOrder.OperatorId);
                nameValueData.Add("user_id", WorkingOrder.UserId);
                nameValueData.Add("menu_id", WorkingOrder.MenuId);
                nameValueData.Add("meals", JsonConvert.SerializeObject(WorkingOrder.ChosenMeals));
                nameValueData.Add("status","created");
                
                nameValueData.Add("c_date", Shared.GetCurrentDateTime());

                WorkingOrder.Id = Shared.InsertReq("chs_orders", nameValueData);
                if (WorkingOrder.Id != -1) {
                    // Ok                    
                    Shared.msgInformation(string.Format("Ваш заказ принят, номер заказа: {0}!", WorkingOrder.SerialNo()));
                }




      private static string server = "127.0.0.1",
              database = "chladic",
              uid = "root",
              password = "";

      static public string myConnectionString = string.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};CHARSET='utf8'", server, database, uid, password);

     public static void init() {
            // Set current things to Russian culture
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");

            Colors.Add("Red", Color.FromArgb(255, 128, 128));
            Colors.Add("Green", Color.FromArgb(128, 255, 128));
            Colors.Add("Yellow", Color.FromArgb(255, 255, 128));
        }

       public static long InsertReq(string table, Dictionary<string, object> nameValueData) {
            MySqlCommand comm = new MySqlCommand();
            string req = "INSERT INTO " + table;
            req += "(";
            foreach (string name in nameValueData.Keys) {
                req += name + ",";
            }
            // Remove "," from the end
            req = req.TrimLastCharacter() + ") VALUES (";
            foreach (string name in nameValueData.Keys) {
                req += "@" + name + ",";
            }
            req = req.TrimLastCharacter() + ")";


            comm.CommandText = req;

            foreach (KeyValuePair<string, object> nameValue in nameValueData) {
                comm.Parameters.AddWithValue("@" + nameValue.Key, nameValue.Value);
            }

            return DbExecuteNonQuery(comm);
        }
          public static int GetColumnIndex(ListView lv, string colTitle) {
            foreach (ColumnHeader col in lv.Columns) {
                if (col.Text.ToLower().Equals(colTitle.ToLower())) {
                    return col.Index;
                }
            }

            return -1;
        }

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

        public static void Logging(Exception ex) {
            Debug.WriteLine("Internal Error" + ex.Message + ex.StackTrace.ToString());
        }
        public static void Logging(String ex) {
            Debug.WriteLine("Internal String Error" + ex);
        }
        public static void Logging(string format, params object[] args) {
            Debug.WriteLine(format, args);
        }

       public static long DbExecuteNonQuery(MySqlCommand cmd) {
            // Returns last inserted ID
            using (MySqlConnection connection = new MySqlConnection(Shared.myConnectionString)) {
                try {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    return cmd.LastInsertedId;
                } catch (Exception ex) {
                    Logging(ex);
                    return -1;
                }
            }
        }

        public static string GetCurrentDate() {
            return DateTime.Now.ToString("dd.MM.yyyy");
        }
        public static string GetCurrentDateTime() {
            return DateTime.Now.ToString("dd.MM.yyyy hh:MM:ss");
        }
     */
}
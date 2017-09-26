using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFrequencies
{
    public static class DbHelper
    {
        private static SQLiteConnection sql_con;
        private static SQLiteCommand sql_cmd;
        private static SQLiteDataAdapter DB;
        private static DataSet DS = new DataSet();
        private static DataTable DT = new DataTable();
        private static string dbName = "wFrequencies.sqlite";

        public static void SetConnection()
        {
            // Set current things to Russian culture
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");
            sql_con = new SQLiteConnection("Data Source=" + dbName + ";Version=3;New=False;Compress=True;");
            sql_con.Open();
        }

        public static List<xTextFile> GetHistory()
        {
            string query = "SELECT * FROM wf_files";
            List<xTextFile> list = new List<xTextFile>();

            sql_cmd.CommandText = query;

            SQLiteDataReader Reader = sql_cmd.ExecuteReader();
            if (!Reader.HasRows) return null;

            while (Reader.Read()) {
                xTextFile tFile = new xTextFile() {
                    id = Convert.ToInt64(GetDBInt64("id", Reader)),
                    fileName = GetDBString("file_name", Reader),
                    wordsCount = GetDBInt("words_count", Reader),
                    uniqueWordsCount = GetDBInt("unique_words_count", Reader),
                    categoryIndex = GetDBInt("category", Reader),
                    created_at = GetDBString("created_at", Reader),
                };

                list.Add(tFile);
            }
            Reader.Close();

            return list;
        }

        public static void createTables()
        {

            string sql = "create table IF NOT EXISTS wf_files (" +
                "id INTEGER PRIMARY KEY," +
                "file_name varchar(150)," +
                "words_count int," +
                "unique_words_count int," +
                "category int," +
                "created_at varchar(50), CONSTRAINT makeUnique UNIQUE (words_count, unique_words_count))";

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = sql;

            DbExecuteNonQuery(sql_cmd);
        }

        public static long InsertReq(string table, Dictionary<string, object> nameValueData)
        {
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


            sql_cmd.CommandText = req;

            foreach (KeyValuePair<string, object> nameValue in nameValueData) {
                sql_cmd.Parameters.AddWithValue("@" + nameValue.Key, nameValue.Value);
            }

            return DbExecuteNonQuery(sql_cmd);
        }


        public static int GetColumnIndex(ListView lv, string colTitle)
        {
            foreach (ColumnHeader col in lv.Columns) {
                if (col.Text.ToLower().Equals(colTitle.ToLower())) {
                    return col.Index;
                }
            }

            return -1;
        }


        public static string TrimLastCharacter(this String str)
        {
            if (String.IsNullOrEmpty(str)) {
                return str;
            } else {
                return str.TrimEnd(str[str.Length - 1]);
            }
        }

        public static void Logging(Exception ex)
        {
            Debug.WriteLine("Internal Error" + ex.Message + ex.StackTrace.ToString());
        }
        public static void Logging(String ex)
        {
            Debug.WriteLine("Internal String Error" + ex);
        }
        public static void Logging(string format, params object[] args)
        {
            Debug.WriteLine(format, args);
        }

        public static long DbExecuteNonQuery(SQLiteCommand cmd)
        {
            if (!(new FileInfo(dbName).Exists)) { SQLiteConnection.CreateFile(dbName); }

            try {
                return cmd.ExecuteNonQuery();
            } catch (SQLiteException sqliteEx) {
                if (sqliteEx.ErrorCode == 19) {
                    // TODO make lines of different background color if they already exist
                    Debug.WriteLine("ALREADY EXISTS");
                }

                return -1;
            }

            /*
            
            public void DisposeSQLite()
            {
                SQLiteConnection.Dispose();
                SQLiteCommand.Dispose();

                GC.Collect();
            }
            
            */
        }

        public static string GetCurrentDate()
        {
            return DateTime.Now.ToString("dd.MM.yyyy");
        }
        public static string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("dd.MM.yyyy hh:MM:ss");
        }

        public static string GetDBString(string SqlFieldName, SQLiteDataReader Reader)
        {
            int columnIndex = Reader.GetOrdinal(SqlFieldName);
            return Reader[SqlFieldName].Equals(DBNull.Value) ? String.Empty : Reader.GetString(columnIndex);
        }
        public static char GetDBChar(string SqlFieldName, SQLiteDataReader Reader)
        {
            int columnIndex = Reader.GetOrdinal(SqlFieldName);
            return Reader[SqlFieldName].Equals(DBNull.Value) ? ' ' : Reader.GetChar(columnIndex);
        }

        public static Decimal GetDBDecimal(string SqlFieldName, SQLiteDataReader Reader)
        {
            int columnIndex = Reader.GetOrdinal(SqlFieldName);
            return Reader[SqlFieldName].Equals(DBNull.Value) ? 0 : Reader.GetDecimal(columnIndex);
        }

        public static long GetDBInt64(string SqlFieldName, SQLiteDataReader Reader)
        {
            int columnIndex = Reader.GetOrdinal(SqlFieldName);
            return Reader[SqlFieldName].Equals(DBNull.Value) ? 0 : Reader.GetInt64(columnIndex);
        }

        public static int GetDBInt(string SqlFieldName, SQLiteDataReader Reader)
        {
            int columnIndex = Reader.GetOrdinal(SqlFieldName);
            return Reader[SqlFieldName].Equals(DBNull.Value) ? 0 : Reader.GetInt32(columnIndex);
        }
    }
}
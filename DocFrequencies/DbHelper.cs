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

namespace StrangeWords
{
    public static class DbHelper
    {
        private static SQLiteConnection sql_con;
        private static SQLiteCommand sql_cmd;
        private static DataSet DS = new DataSet();
        private static DataTable DT = new DataTable();
        private static string dbName = "SwDatabase.sqlite";

        public static bool ifExists(int charactersCount, int wordsCount)
        {
            sql_cmd.CommandText = String.Format("SELECT count(*) FROM `wf_files` WHERE `words_count`='{0}' AND `characters_count`='{1}'", wordsCount, charactersCount);
            int count = Convert.ToInt32(sql_cmd.ExecuteScalar());

            return count != 0;
        }

        public static void SetConnection()
        {
            // Set current things to Russian culture
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");
            sql_con = new SQLiteConnection("Data Source=" + dbName + ";Version=3;New=False;Compress=True;");
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
        }

        public static List<xWordFrequencies> GetCombinedFrequencies()
        {
            // This function gets all frequencies between the range defined with dtFom and dtTO

            // Combine all frequencies
            List<xWordFrequencies> combinedfrequencies = new List<xWordFrequencies>();
            foreach (xTextFile xtf in Utils.history) {
                combinedfrequencies.AddRange(xtf.frequencies);
            }

            // List for the all unique frequencies
            List<xWordFrequencies> allfrequencies = new List<xWordFrequencies>();

            foreach (xWordFrequencies xwf in combinedfrequencies) {
                // If our list already has such word, don't add new element but change it
                xWordFrequencies existing = allfrequencies.Find(x => x.word.Equals(xwf.word));
                if (existing != null) {
                    // Combine frequency
                    existing.frequency = existing.frequency + xwf.frequency;
                    float freq = existing.frequency;
                    existing.percentage = (freq / WORDS_COUNT) * 100;
                } else {
                    float freq = xwf.frequency;
                    xwf.percentage = (freq / WORDS_COUNT) * 100;
                    allfrequencies.Add(xwf);
                }
            }

            return allfrequencies;
        }

        public static List<xWordFrequencies> GetFrequencies(long fileId)
        {

            string query = string.Format("SELECT * FROM wf_frequencies WHERE file_id={0}", fileId);
            List<xWordFrequencies> list = new List<xWordFrequencies>();

            SQLiteCommand cmd = new SQLiteCommand();
            cmd = sql_con.CreateCommand();
            cmd.CommandText = query;
            SQLiteDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return null;

            try {
                while (Reader.Read()) {
                    xWordFrequencies xwf = new xWordFrequencies() {
                        id = Convert.ToInt64(GetDBInt64("id", Reader)),
                        fileId = Convert.ToInt64(GetDBInt64("file_id", Reader)),
                        word = GetDBString("word", Reader),
                        rank = GetDBInt("rank", Reader),
                        frequency = GetDBInt("frequency", Reader),
                        percentage = GetDBFloat("percentage", Reader),
                    };

                    list.Add(xwf);
                }
            } catch (Exception ex) {
                Utils.ErrLog("Ошибка при чтении xwf из БД", ex.Message);
                Utils.msgInformation("Ошибка при чтении БД, требуется обновление БД");
            }
            Reader.Close();

            return list;
        }

        public static int WORDS_COUNT;
        public static int CHARACTERS_COUNT;
        public static int FILES_COUNT;

        public static List<xWordFrequencies> FindInFrequencies(string word)
        {
            ResetSQLiteConnection();
            List<xWordFrequencies> xwfList = new List<xWordFrequencies>();
            string query = string.Format("SELECT * FROM `wf_frequencies` WHERE `word` LIKE '{0}'", word);
            sql_cmd.CommandText = query;
            SQLiteDataReader Reader = sql_cmd.ExecuteReader();
            if (!Reader.HasRows) return null;

            while (Reader.Read()) {
                xWordFrequencies xwf = new xWordFrequencies() {
                    id = Convert.ToInt64(GetDBInt64("id", Reader)),
                    fileId = Convert.ToInt64(GetDBInt64("file_id", Reader)),
                    word = GetDBString("word", Reader),
                    frequency = GetDBInt("frequency", Reader),
                    percentage = GetDBFloat("percentage", Reader),
                };

                xwfList.Add(xwf);

                //   subquery += string.Format("'{0}' OR ", Convert.ToInt64(GetDBInt64("file_id", Reader)));
                //   subquery = subquery.Substring(0, subquery.Length - 4);
            };
            Reader.Close();

            return xwfList;
        }

        public static List<xTextFile> GetHistory(string dtFrom, string dtTo)
        {
            WORDS_COUNT = 0; CHARACTERS_COUNT = 0; FILES_COUNT = 0;
            ResetSQLiteConnection();
            Utils.frequencies = new List<xWordFrequencies>();

            string query = string.Format("SELECT * FROM `wf_files` WHERE strftime('%Y-%m-%d %H:%M:%S',created_at) BETWEEN ('{0}') AND ('{1}')", dtFrom, dtTo);
            List<xTextFile> list = new List<xTextFile>();
            sql_cmd.CommandText = query;
            SQLiteDataReader Reader = sql_cmd.ExecuteReader();
            if (!Reader.HasRows) return null;

            while (Reader.Read()) {
                xTextFile tFile = new xTextFile() {
                    fileId = Convert.ToInt64(GetDBInt64("id", Reader)),
                    fileName = GetDBString("file_name", Reader),
                    wordsCount = GetDBInt("words_count", Reader),
                    uniqueWordsCount = GetDBInt("unique_words_count", Reader),
                    charactersCount = GetDBInt("characters_count", Reader),
                    categoryIndex = GetDBInt("category", Reader),
                    created_at = GetDBString("created_at", Reader),
                    frequencies = GetFrequencies(Convert.ToInt64(GetDBInt64("id", Reader)))
                };

                WORDS_COUNT += tFile.wordsCount;
                CHARACTERS_COUNT += tFile.charactersCount;
                FILES_COUNT++;
                list.Add(tFile);
            }
            Reader.Close();

            return list;
        }
        public static void dropTables()
        {
            sql_cmd.Dispose();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = " DROP Table 'wf_files'";
            sql_cmd.ExecuteNonQuery();

            sql_cmd.CommandText = " DROP Table 'wf_frequencies'";
            sql_cmd.ExecuteNonQuery();

            createTables();
        }


        public static void DisposeSQLite()
        {
            sql_con.Dispose();
            sql_cmd.Dispose();

            GC.Collect();
        }

        public static void ResetSQLiteConnection()
        {
            DisposeSQLite();
            SetConnection();
        }
        public static void createTables()
        {
            // I have removed from UNIQUE statement the uniquewordscount because by doing so I can skip files without checking their frequency whioch takes enormous time 
            if (!(new FileInfo(dbName).Exists)) { SQLiteConnection.CreateFile(dbName); }
            string sql = "create table IF NOT EXISTS wf_files (" +
                "id INTEGER PRIMARY KEY," +
                "file_name varchar(150)," +
                "words_count int," +
                "unique_words_count int," +
                "characters_count int," +
                "category int," +
                "created_at varchar(50), CONSTRAINT makeUnique UNIQUE (words_count, characters_count))";

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = sql;

            DbExecuteNonQuery(sql_cmd);

            sql = "create table IF NOT EXISTS wf_frequencies (" +
               "id INTEGER PRIMARY KEY," +
               "file_id int," +
               "rank int," +
               "word varchar (150)," +
               "frequency int," +
               "percentage real," +
               "CONSTRAINT makeUnique UNIQUE (file_id, word))";

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = sql;

            DbExecuteNonQuery(sql_cmd);
        }
        public static long GetLastInsertedId(string table)
        {
            long id = -1L;

            return id;
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
        public static long UpdateReq(string table, Dictionary<string, object> nameValueData, long id)
        {
            string req = "UPDATE " + table;
            req += " SET ";
            foreach (string name in nameValueData.Keys) {
                req += name + "=@" + name + ",";
            }
            // Remove "," from the end
            req = req.TrimLastCharacter() + " WHERE id = " + id;
            sql_cmd.CommandText = req;

            foreach (KeyValuePair<string, object> nameValue in nameValueData) {
                sql_cmd.Parameters.AddWithValue("@" + nameValue.Key, nameValue.Value);
            }

            return DbExecuteNonQuery(sql_cmd);
        }
        public static long RemoveReq(string table, long id)
        {
            try {
                sql_cmd.CommandText = "DELETE from `" + table + "` WHERE `id`=" + id.ToString();
                return DbExecuteNonQuery(sql_cmd);
            } catch (Exception ex) {
                Utils.ErrLog(ex);
                return -1;
            }
        }
        public static long InsertWithTransaction(string table, List<Dictionary<string, object>> data)
        {
            try {
                using (var cmd = new SQLiteCommand(sql_con)) {
                    using (var transaction = sql_con.BeginTransaction()) {
                        //Add your query here.

                        foreach (Dictionary<string, object> nameValueData in data) {
                            InsertReq(table, nameValueData);
                        }
                        transaction.Commit();
                    }
                }
                return 1;
            } catch (Exception ex) {
                Utils.ErrLog(ex);
                return -1;
            }
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

        public static long DbExecuteNonQuery(SQLiteCommand cmd)
        {
            try {
                if (cmd.ExecuteNonQuery() > 0) return sql_con.LastInsertRowId; else return -1;
            } catch (SQLiteException sqlex) {
                string msg = "";

                if (sqlex.ErrorCode == 19) {
                    if (cmd.Parameters[0].ParameterName == "@file_name") {
                        // It's a file insert request
                        msg = "файл: " + cmd.Parameters[0].Value.ToString();
                    } else if (cmd.Parameters[0].ParameterName == "@file_id") {
                        // It's a frequency insert request
                        msg = "слово: " + cmd.Parameters[1].Value;
                    }
                    Utils.ErrLog("Запись уже существует", msg);
                } else
                    Utils.ErrLog(sqlex);
                return -1;
            } catch (Exception ex) {
                Utils.ErrLog(ex);
                return -1;
            }
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
        public static float GetDBFloat(string SqlFieldName, SQLiteDataReader Reader)
        {
            int columnIndex = Reader.GetOrdinal(SqlFieldName);
            return Reader[SqlFieldName].Equals(DBNull.Value) ? 0 : Reader.GetFloat(columnIndex);
        }
    }
}
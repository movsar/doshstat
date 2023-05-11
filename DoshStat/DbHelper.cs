using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoshStat
{
    public static class DbHelper
    {
        public const String TABLE_FILES = "wf_files";
        public const String TABLE_FREQUENCIES = "wf_frequencies";

        private static SQLiteConnection sql_con;
        private static SQLiteCommand sql_cmd;
        private static DataSet DS = new DataSet();
        private static DataTable DT = new DataTable();
        private static string dbName = "SwDatabase.sqlite";

        public static bool ifExists(int charactersCount, int wordsCount)
        {
            sql_cmd.CommandText = String.Format("SELECT count(*) FROM `" + TABLE_FILES + "` WHERE `words_count`='{0}' AND `characters_count`='{1}'", wordsCount, charactersCount);
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
            var combinedFrequencies = Utils.history.SelectMany(xtf => xtf.frequencies).ToList();

            // List for the all unique frequencies
            var allFrequencies = new List<xWordFrequencies>();

            foreach (var xwf in combinedFrequencies)
            {
                // If our list already has such word, don't add new element but change it
                var existing = allFrequencies.FirstOrDefault(x => x.word.Equals(xwf.word));
                if (existing != null)
                {
                    // Combine frequency
                    existing.frequency += xwf.frequency;
                    existing.percentageAgainstAllWordsInFile = (existing.frequency / WORDS_COUNT) * 100;
                }
                else
                {
                    xwf.percentageAgainstAllWordsInFile = (xwf.frequency / WORDS_COUNT) * 100;
                    allFrequencies.Add(xwf);
                }
            }

            return allFrequencies;
        }

        public static void Chistka()
        {
            ResetSQLiteConnection();
            int iteration = -1;


            string query = string.Format("SELECT * FROM `wf_frequencies` Where `id` > " + iteration);
            List<xWordFrequencies> list = new List<xWordFrequencies>();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = sql_con.CreateCommand();
            cmd.CommandText = query;
            SQLiteDataReader Reader = cmd.ExecuteReader();
            if (!Reader.HasRows) return;
            int count = 145000;
            int removed = 0;

            try
            {
                using (StreamWriter sw_debug = new StreamWriter("output.log", true, Encoding.UTF8))
                {
                    using (StreamWriter sw_output = new StreamWriter("output.sql", true, Encoding.UTF8))
                    {
                        while (Reader.Read())
                        {
                            iteration++;

                            xWordFrequencies xwf = new xWordFrequencies()
                            {
                                id = Convert.ToInt64(GetDBInt64("id", Reader)),
                                fileId = Convert.ToInt64(GetDBInt64("file_id", Reader)),
                                word = GetDBString("word", Reader),
                                rank = GetDBInt("rank", Reader),
                                frequency = GetDBInt("frequency", Reader),
                                percentageAgainstAllWordsInFile = GetDBFloat("percentage", Reader),
                            };

                            String line = xwf.word;

                            line = line.Replace("1", "Ӏ");
                            line = line.Replace("I", "Ӏ");
                            line = line.Replace("l", "Ӏ");

                            line = line.Replace("ѐ", "ё");
                            line = line.Replace("e", "е");
                            line = line.Replace("a", "а");
                            line = line.Replace("p", "р");
                            line = line.Replace("o", "о");
                            line = line.Replace("i", "Ӏ");
                            line = line.Replace("l", "Ӏ");
                            line = line.Replace("k", "к");
                            line = line.Replace("x", "х");
                            line = line.Replace("y", "у");
                            line = line.Replace("n", "п");
                            line = line.Replace("m", "м");
                            line = line.Replace("c", "с");
                            line = line.Replace("r", "г");
                            line = line.Replace("u", "и");

                            line = line.Replace("Ѐ", "Ё");
                            line = line.Replace("E", "Е");
                            line = line.Replace("A", "А");
                            line = line.Replace("B", "В");
                            line = line.Replace("P", "Р");
                            line = line.Replace("O", "О");
                            line = line.Replace("I", "Ӏ");
                            line = line.Replace("K", "К");
                            line = line.Replace("X", "Х");
                            line = line.Replace("T", "Т");
                            line = line.Replace("M", "М");
                            line = line.Replace("C", "С");

                            xwf.word = line;

                            sw_debug.Write(string.Format("{0}/{1} {2} ", iteration, count, line));
                            Debug.Write(string.Format("{0}/{1} {2} ", iteration, count, line));

                            // IS IT CYRILLIC ?
                            if (!Regex.IsMatch(line, @"\A[\s\W\p{IsCyrillic}]*\z"))
                            {
                                // if not, remove
                                // Debug.Write("ILLEGAL.. REMOVING..." + (RemoveReq(TABLE_FREQUENCIES, xwf.id) > 0 ? "OK" : "FAIL"));
                                sw_debug.WriteLine("");
                                Debug.WriteLine("");
                                removed++;
                                continue;
                            }

                            Dictionary<string, object> nameValueData = new Dictionary<string, object>();
                            nameValueData.Add("word", line);

                            if ((UpdateReq("wf_frequencies", nameValueData, xwf.id) > 0))
                            {
                                // OK
                                sw_output.WriteLine("INSERT INTO `wf_frequencies` VALUES({0},{1},{2},'{3}',{4},{5})", xwf.id, xwf.fileId, xwf.rank, xwf.word, xwf.frequency, xwf.percentageAgainstAllWordsInFile);
                                sw_debug.Write("Ok");
                                Debug.Write("Ok");
                            }
                            else
                            {
                                // FAIL
                                // Exception must mean that such element is already existing in the database, so remove it
                                // Ideally I should have added their frequency but it's not that important so I am not doing it
                                // Debug.Write("FAIL, REMOVING ..." + (RemoveReq(TABLE_FREQUENCIES, xwf.id) > 0 ? "OK" : "FAIL"));
                                removed++;
                            }

                            sw_debug.WriteLine("");
                            Debug.WriteLine("");
                        }


                    }
                    sw_debug.WriteLine("END OF THE UNIVERSE!");
                    Debug.WriteLine("END OF THE UNIVERSE!");
                    sw_debug.WriteLine("REMOVED: " + removed);
                    Debug.WriteLine("REMOVED: " + removed);
                }
            }
            catch (Exception ex)
            {
                Utils.ErrLog("Ошибка при чтении xwf из БД", ex.Message);
                Utils.msgInformation("Ошибка при чтении БД, требуется обновление БД");
            }
            Reader.Close();
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

            try
            {
                while (Reader.Read())
                {
                    xWordFrequencies xwf = new xWordFrequencies()
                    {
                        id = Convert.ToInt64(GetDBInt64("id", Reader)),
                        fileId = Convert.ToInt64(GetDBInt64("file_id", Reader)),
                        word = GetDBString("word", Reader),
                        rank = GetDBInt("rank", Reader),
                        frequency = GetDBInt("frequency", Reader),
                        percentageAgainstAllWordsInFile = GetDBFloat("percentage", Reader),
                    };

                    list.Add(xwf);
                }
            }
            catch (Exception ex)
            {
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

            while (Reader.Read())
            {
                xWordFrequencies xwf = new xWordFrequencies()
                {
                    id = Convert.ToInt64(GetDBInt64("id", Reader)),
                    fileId = Convert.ToInt64(GetDBInt64("file_id", Reader)),
                    word = GetDBString("word", Reader),
                    frequency = GetDBInt("frequency", Reader),
                    percentageAgainstAllWordsInFile = GetDBFloat("percentage", Reader),
                };

                xwfList.Add(xwf);

                //   subquery += string.Format("'{0}' OR ", Convert.ToInt64(GetDBInt64("file_id", Reader)));
                //   subquery = subquery.Substring(0, subquery.Length - 4);
            };
            Reader.Close();

            return xwfList;
        }

        private static String CACHE_DT_FROM, CACHE_DT_TO;

        public static List<xTextFile> GetHistory(string dtFrom, string dtTo)
        {
            if (dtFrom != "")
            {
                CACHE_DT_FROM = dtFrom;
                CACHE_DT_TO = dtTo;
            }
            else
            {
                dtFrom = CACHE_DT_FROM;
                dtTo = CACHE_DT_TO;
            }

            WORDS_COUNT = 0; CHARACTERS_COUNT = 0; FILES_COUNT = 0;
            ResetSQLiteConnection();
            Utils.frequencies = new List<xWordFrequencies>();
            string query = string.Format("SELECT * FROM `wf_files` WHERE strftime('%Y-%m-%d %H:%M:%S',created_at) BETWEEN ('{0}') AND ('{1}')", dtFrom, dtTo);
            List<xTextFile> list = new List<xTextFile>();
            sql_cmd.CommandText = query;
            SQLiteDataReader Reader = sql_cmd.ExecuteReader();
            if (!Reader.HasRows) return null;

            while (Reader.Read())
            {
                xTextFile tFile = new xTextFile()
                {
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
                "file_name varchar(255)," +
                "title varchar(255)," +
                "words_count int," +
                "unique_words_count int," +
                "characters_count int," +
                "category int," +
                "created_at varchar(50), CONSTRAINT makeUnique UNIQUE (words_count, characters_count))";

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = sql;

            // Execution and getting result
            sql_cmd.ExecuteNonQuery();


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
            sql_cmd.ExecuteNonQuery();

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
            foreach (string name in nameValueData.Keys)
            {
                req += name + ",";
            }
            // Remove "," from the end
            req = req.TrimLastCharacter() + ") VALUES (";
            foreach (string name in nameValueData.Keys)
            {
                req += "@" + name + ",";
            }
            req = req.TrimLastCharacter() + ")";


            sql_cmd.CommandText = req;

            foreach (KeyValuePair<string, object> nameValue in nameValueData)
            {
                sql_cmd.Parameters.AddWithValue("@" + nameValue.Key, nameValue.Value);
            }

            // Execution and getting result
            try
            {
                if (sql_cmd.ExecuteNonQuery() > 0)
                    return sql_con.LastInsertRowId;
                else
                    return -1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERR WHEN INSERTING NEW ROW");
                return -1;
            }
        }

        public static long UpdateReq(string table, Dictionary<string, object> nameValueData, long id)
        {
            string req = "UPDATE " + table;
            req += " SET ";
            foreach (string name in nameValueData.Keys)
            {
                req += name + "=@" + name + ",";
            }
            // Remove "," from the end
            req = req.TrimLastCharacter() + " WHERE id = " + id;
            sql_cmd.CommandText = req;

            foreach (KeyValuePair<string, object> nameValue in nameValueData)
            {
                sql_cmd.Parameters.AddWithValue("@" + nameValue.Key, nameValue.Value);
            }

            // Execution and getting result
            try
            {
                return sql_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERR WHEN UPDATING A ROW");
                return -1;
            }
        }

        public static long RemoveReq(string table, long id)
        {
            try
            {
                sql_cmd.CommandText = "DELETE from `" + table + "` WHERE `id`=" + id.ToString();
                // Execution and getting result
                try
                {
                    return sql_cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("ERR WHEN DELETING A ROW");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Utils.ErrLog(ex);
                return -1;
            }
        }
        public static long InsertWithTransaction(string table, List<Dictionary<string, object>> data)
        {
            try
            {
                using (var cmd = new SQLiteCommand(sql_con))
                {
                    using (var transaction = sql_con.BeginTransaction())
                    {
                        //Add your query here.

                        foreach (Dictionary<string, object> nameValueData in data)
                        {
                            InsertReq(table, nameValueData);
                        }
                        transaction.Commit();
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                Utils.ErrLog(ex);
                return -1;
            }
        }
        public static int GetColumnIndex(ListView lv, string colTitle)
        {
            foreach (ColumnHeader col in lv.Columns)
            {
                if (col.Text.ToLower().Equals(colTitle.ToLower()))
                {
                    return col.Index;
                }
            }

            return -1;
        }

        public static string TrimLastCharacter(this String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return str;
            }
            else
            {
                return str.TrimEnd(str[str.Length - 1]);
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
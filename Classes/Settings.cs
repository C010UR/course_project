using System;
using System.Data;
using System.IO;
using Npgsql;
using Newtonsoft.Json;

namespace CourseProject.Classes
{
    public static class Settings
    {
        public static NpgsqlConnectionStringBuilder conStr = new NpgsqlConnectionStringBuilder();
        public static User user;

        public static bool LoadConStr()
        {
            if (!Directory.Exists(".\\settings"))
            {
                return false;
            }

            if (!File.Exists(".\\settings\\connection_string.json"))
            {
                return false;
            }

            string json = "";

            using (StreamReader sr = new StreamReader(@".\\settings\\connection_string.json"))
            {
                json = sr.ReadToEnd();
            }

            conStr = JsonConvert.DeserializeObject<NpgsqlConnectionStringBuilder>(json);

            if (!CheckDatabaseConnection(conStr))
            {
                conStr = null;
                return false;
            }
            else
                return true;
        }

        public static void SaveConStr()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            if (!Directory.Exists(".\\settings"))
            {
                Directory.CreateDirectory(".\\settings");
            }

            using (StreamWriter sw = new StreamWriter(@".\\settings\\connection_string.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, conStr);
            }
        }

        public static bool CheckDatabaseConnection(NpgsqlConnectionStringBuilder temp)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(temp.ConnectionString))
            {
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                        return true;
                }
                catch (Exception) { }
                finally
                {
                    conn.Close();
                }
                return false;
            }
        }
    }
}

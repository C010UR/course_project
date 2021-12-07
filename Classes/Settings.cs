using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Npgsql;
using Newtonsoft.Json;

namespace CourseProject.Classes
{
    public static class Settings
    {
        public static NpgsqlConnectionStringBuilder conStr = new NpgsqlConnectionStringBuilder();


        public static void LoadConStr()
        {
            string json = "";

            using (StreamReader sr = new StreamReader(@".\settings\connection_string.json"))
            {
                sr.ReadToEnd();
            }

            conStr = JsonConvert.DeserializeObject<NpgsqlConnectionStringBuilder>(json);
        }

        public static void SaveConStr()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@".\settings\connection_string.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, conStr);
            }
        }
    }
}

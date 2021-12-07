using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CourseProject.Classes
{
    public static class DataBaseDelete
    {
        public static string Delete(int id, string cmd)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT " + cmd + "(:_id);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue(":_id", id);
                        command.Prepare();
                        command.ExecuteScalar();
                    }
                }
                catch (Exception exc)
                {
                    return exc.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            return "";
        }

        public static string TeacherType(int id)
        {
            return Delete(id, "delete_teacher_type");
        }

        public static string Teacher(int id)
        {
            return Delete(id, "delete_teacher");
        }
        
        public static string Group(int id)
        {
            return Delete(id, "delete_group");
        }

        public static string Student(int id)
        {
            return Delete(id, "delete_student");
        }

        public static string Theme(int id)
        {
            return Delete(id, "delete_theme");
        }

        public static string StageName(int id)
        {
            return Delete(id, "delete_stage_name");
        }

        public static string Stage(int id)
        {
            return Delete(id, "delete_stage");
        }
    }
}

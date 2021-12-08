using System;
using System.Collections.Generic;

using Npgsql;

namespace CourseProject.Classes
{
    public static class DataBaseGet
    {
        public static List<T> Get<T>(string cmd, string custom_query_parameters, Func<NpgsqlDataReader, T> handler)
        {
            List<T> buf = new List<T>();
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(cmd + " " + custom_query_parameters, conn))
                    {
                        command.Parameters.Clear();
                        command.Prepare();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                buf.Add(handler(reader));
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }
            return buf;
        }

        public static List<TeacherType> TeacherTypes(string custom_query_parameters)
        {
            return Get("SELECT * FROM get_teacher_types()", custom_query_parameters, (reader) =>
            {
                return new TeacherType(reader.GetInt32(0), reader.GetString(1));
            });
        }

        public static List<Teacher> Teachers(string custom_query_parameters)
        {
            return Get("SELECT * FROM get_teachers()", custom_query_parameters, (reader) =>
            {
                return new Teacher(
                    reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4), reader.GetString(5)
                );
            });
        }

        public static List<Group> Groups(string custom_query_parameters)
        {
            return Get("SELECT * FROM get_groups()", custom_query_parameters, (reader) =>
            {
                return new Group(
                    reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                    reader.GetString(3), reader.GetInt32(4)
                );
            });
        }

        public static List<Student> Students(string custom_query_parameters)
        {
            return Get("SELECT * FROM get_students()", custom_query_parameters, (reader) =>
            {
                return new Student(
                    reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4)
                );
            });
        }

        public static List<User> Users(string custom_query_parameters)
        {
            return Get("SELECT * FROM get_users()", custom_query_parameters, (reader) =>
            {
                return new User(reader.GetInt32(0), reader.GetBoolean(1), reader.GetInt32(2), reader.GetString(3));
            });
        }

        public static List<Theme> Themes(string custom_query_parameters)
        {
            return Get("SELECT * FROM get_themes()", custom_query_parameters, (reader) =>
            {
                return new Theme(
                    reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                    reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5),
                    reader.GetInt32(6)
                );
            });
        }

        public static List<StageName> StageNames(string custom_query_parameters)
        {
            return Get("SELECT * FROM get_stage_names()", custom_query_parameters, (reader) =>
            {
                return new StageName(reader.GetInt32(0), reader.GetString(1));
            });
        }

        public static List<Stage> Stages(string custom_query_parameters)
        {
            return Get("SELECT * FROM get_stages()", custom_query_parameters, (reader) =>
            {
                return new Stage(
                    reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                    reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5),
                    reader.GetInt32(6), reader.GetDateTime(7), reader.GetDateTime(8)
                );
            });
        }

        public static bool PasswordIsValid(int id, string pass)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM check_password(:_id, :_pass);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_id", id);
                        command.Parameters.AddWithValue("_pass", pass);
                        command.Prepare();
                        return (int)command.ExecuteScalar() == 0;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}

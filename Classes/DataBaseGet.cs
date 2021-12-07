using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CourseProject.Classes
{
    public delegate T Read<T>(NpgsqlDataReader reader);
    public static class DataBaseGet
    {
        public static List<TeacherType> TeacherTypes()
        {
            List<TeacherType> buf = new List<TeacherType>();
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_teacher_types();", conn))
                    {
                        command.Parameters.Clear();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                buf.Add(new TeacherType(
                                    reader.GetInt32(0), reader.GetString(1)
                                ));
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

        public static List<Teacher> Teachers()
        {
            List<Teacher> buf = new List<Teacher>();
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_teachers();", conn))
                    {
                        command.Parameters.Clear();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                buf.Add(new Teacher(
                                    reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                                    reader.GetString(3), reader.GetString(4), reader.GetString(5)
                                ));
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

        public static List<Group> Groups()
        {
            List<Group> buf = new List<Group>();
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_groups();", conn))
                    {
                        command.Parameters.Clear();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                buf.Add(new Group(
                                    reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                                    reader.GetString(3), reader.GetInt32(4)
                                ));
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

        public static List<Student> Students()
        {
            List<Student> buf = new List<Student>();
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_students();", conn))
                    {
                        command.Parameters.Clear();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                buf.Add(new Student(
                                    reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                                    reader.GetString(3), reader.GetString(4)
                                ));
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

        public static List<User> Users()
        {
            List<User> buf = new List<User>();
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_users();", conn))
                    {
                        command.Parameters.Clear();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                buf.Add(new User(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2)));
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

        public static List<Theme> Themes()
        {
            List<Theme> buf = new List<Theme>();
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_themes();", conn))
                    {
                        command.Parameters.Clear();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                buf.Add(new Theme(
                                    reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                                    reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5),
                                    reader.GetInt32(6)
                                ));
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

        public static List<StageName> StageNames()
        {
            List<StageName> buf = new List<StageName>();
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_stage_names();", conn))
                    {
                        command.Parameters.Clear();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                buf.Add(new StageName(
                                    reader.GetInt32(0), reader.GetString(1)
                                ));
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

        public static List<Stage> Stages()
        {
            List<Stage> buf = new List<Stage>();
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_stages();", conn))
                    {
                        command.Parameters.Clear();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                buf.Add(new Stage(
                                    reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                                    reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5),
                                    reader.GetInt32(6), reader.GetDateTime(7), reader.GetDateTime(8)
                                ));
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
    }
}

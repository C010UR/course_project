using System;

using Npgsql;

namespace CourseProject.Classes
{
    public static class DataBaseAdd
    {
        public static string TeacherType(string type_name)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT add_teacher_type(:_type_name);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_type_name", type_name);
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

        public static string Teacher(int type_id, string teacher_name, string address, string phone, string pass)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT add_teacher(:_type_id, :_teacher_name, :_address, :_phone, :_pass);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_type_name", type_id);
                        command.Parameters.AddWithValue("_teacher_name", teacher_name);
                        command.Parameters.AddWithValue("_address", address);
                        command.Parameters.AddWithValue("_phone", phone);
                        command.Parameters.AddWithValue("_pass", pass);
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

        public static string Group(int teacher_id, string group_name, int year_started)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT add_group(:_teacher_id, :_group_name, :_year_started);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_teacher_id", teacher_id);
                        command.Parameters.AddWithValue("_group_name", group_name);
                        command.Parameters.AddWithValue("_year_started", year_started);
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

        public static string Student(int group_id, string student_name, string phone, string pass)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT add_student(:_group_id, :_student_name, :_phone, :_pass);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_group_id", group_id);
                        command.Parameters.AddWithValue("_student_name", student_name);
                        command.Parameters.AddWithValue("_phone", phone);
                        command.Parameters.AddWithValue("_pass", pass);
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

        public static string Theme(int student_id, string theme_name, int main_teacher_id, int econ_teacher_id, int safe_teacher_id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT add_theme(:_student_id, :_theme_name, :_main_teacher_id, :_econ_teacher_id, :_safe_teacher_id);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_student_id", student_id);
                        command.Parameters.AddWithValue("_theme_name", theme_name);
                        command.Parameters.AddWithValue("_main_teacher_id", main_teacher_id);
                        command.Parameters.AddWithValue("_econ_teacher_id", econ_teacher_id);
                        command.Parameters.AddWithValue("_safe_teacher_id", safe_teacher_id);
                        command.Prepare();
                        if ((int)command.ExecuteScalar() < 0)
                            return "Превышено количество тем на учителя!";
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

        public static string StageName(string stage_name)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT add_stage_name(:_stage_name);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_stage_name", stage_name);
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

        public static string Stage(int stage_name_id, int theme_id, int teacher_id, int percentage, DateTime date_started, DateTime date_ended)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT add_stage(:_stage_name_id, :_theme_id, :_teacher_id, :_percentage, :_date_started, :_date_ended);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_stage_name_id", stage_name_id);
                        command.Parameters.AddWithValue("_theme_id", theme_id);
                        command.Parameters.AddWithValue("_teacher_id", teacher_id);
                        command.Parameters.AddWithValue("_percentage", percentage);
                        command.Parameters.AddWithValue("_date_started", date_started.ToString(@"yyyy-MM-dd"));
                        command.Parameters.AddWithValue("_date_ended", date_ended.ToString(@"yyyy-MM-dd"));
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
    }
}

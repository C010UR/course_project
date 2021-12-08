using System;

using Npgsql;

namespace CourseProject.Classes
{
    public static class DataBaseUpdate
    {
        public static string TeacherType(int teacher_type_id, string type_name)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT update_teacher_type(:_teacher_type_id, :_type_name);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_teacher_type_id", teacher_type_id);
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

        public static string Teacher(int teacher_id, int type_id, string teacher_name, string address, string phone, string pass)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT update_teacher(:_teacher_id, :_type_id, :_teacher_name, :_address, :_phone, :_pass);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_teacher_id", teacher_id);
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

        public static string Group(int group_id, int teacher_id, string group_name, int year_started)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT update_group(:_group_id, :_teacher_id, :_group_name, :_year_started);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_group_id", group_id);
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

        public static string Student(int student_id, int group_id, string student_name, string phone, string pass)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT update_student(:_student_id, :_group_id, :_student_name, :_phone, :_pass);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_student_id", student_id);
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

        public static string Theme(int theme_id, int student_id, string theme_name, int main_teacher_id, int econ_teacher_id, int safe_teacher_id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT update_theme(:_theme_id, :_student_id, :_theme_name, :_main_teacher_id, :_econ_teacher_id, :_safe_teacher_id);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_theme_id", theme_id);
                        command.Parameters.AddWithValue("_student_id", student_id);
                        command.Parameters.AddWithValue("_theme_name", theme_name);
                        command.Parameters.AddWithValue("_main_teacher_id", main_teacher_id);
                        command.Parameters.AddWithValue("_econ_teacher_id", econ_teacher_id);
                        command.Parameters.AddWithValue("_safe_teacher_id", safe_teacher_id);
                        command.Prepare();
                        if ((int)command.ExecuteScalar() < 0)
                            return "Превышено количество тем на учителя!";
                        else
                            return "";
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
        }

        public static string StageName(int stage_name_id, string stage_name)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT update_stage_name(:_stage_name_id, :_stage_name);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_stage_name_id", stage_name_id);
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

        public static string Stage(int stage_id, int stage_name_id, int theme_id, int teacher_id, int percentage, DateTime date_started, DateTime date_ended)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT update_stage(:_stage_id, :_stage_name_id, :_theme_id, :_teacher_id, :_percentage, :_date_started, :_date_ended);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_stage_id", stage_id);
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

        public static string StagePercentageOnly(int stage_id, int percentage)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT update_stage_only_percentage(:_stage_id, :_percentage);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_stage_id", stage_id);
                        command.Parameters.AddWithValue("_percentage", percentage);
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

        public static string StageTeacherDates(int stage_id, int teacher_id, DateTime started_date, DateTime ended_date)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Settings.conStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT update_stage_teacher_dates(:_stage_id, :_teacher_id, :_started_date::date, :_ended_date::date);", conn))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("_stage_id", stage_id);
                        command.Parameters.AddWithValue("_teacher_id", teacher_id);
                        command.Parameters.AddWithValue("_started_date", started_date.ToString(@"yyyy-MM-dd"));
                        command.Parameters.AddWithValue("_ended_date", ended_date.ToString(@"yyyy-MM-dd"));
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

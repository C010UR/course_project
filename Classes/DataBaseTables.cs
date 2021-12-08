using System;

namespace CourseProject.Classes
{
    public class TeacherType
    {
        public int type_id { get; set; }
        public string type_name { get; set; }

        public TeacherType (int type_id, string type_name)
        {
            this.type_id = type_id;
            this.type_name = type_name;
        }

        public TeacherType ()
        {
            this.type_id = 0;
            this.type_name = "";
        }
    }

    public class Teacher : TeacherType
    {
        public int teacher_id { get; set; }
        public string teacher_name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public Teacher(int teacher_id, int type_id, string type_name, string teacher_name, string address, string phone)
        {
            this.teacher_id = teacher_id;
            this.type_id = type_id;
            this.type_name = type_name;
            this.teacher_name = teacher_name;
            this.address = address;
            this.phone = phone;
        }

        public Teacher()
        {
            this.teacher_id = 0;
            this.type_id = 0;
            this.type_name = "";
            this.teacher_name = "";
            this.address = "";
            this.phone = "";
        }

        public override string ToString()
        {
            return this.teacher_name;
        }
    }

    public class Group
    {
        public int group_id { get; set; }
        public int teacher_id { get; set; }
        public string teacher_name { get; set; }
        public string group_name { get; set; }
        public int year_started { get; set; }

        public Group (int group_id, int teacher_id, string teacher_name, string group_name, int year_started)
        {
            this.group_id = group_id;
            this.teacher_id = teacher_id;
            this.teacher_name = teacher_name;
            this.group_name = group_name;
            this.year_started = year_started;
        }

        public Group()
        {
            this.group_id = 0;
            this.teacher_id = 0;
            this.teacher_name = "";
            this.group_name = "";
            this.year_started = 0;
        }
    }

    public class Student
    {
        public int student_id { get; set;}
        public int group_id { get; set; }
        public string group_name { get; set; }
        public string student_name { get; set; }
        public string phone { get; set; }
        public int theme_id { get; set; }
        public string theme_name { get; set; }
        public int percentage { get; set; }

        public Student (int student_id, int group_id, string group_name, string student_name, string phone, int theme_id, string theme_name, int percentage)
        {
            this.student_id = student_id;
            this.group_id = group_id;
            this.group_name = group_name;
            this.student_name = student_name;
            this.phone = phone;
            this.theme_id = theme_id;
            this.theme_name = theme_name;
            this.percentage = percentage;
        }
        
        public Student ()
        {
            this.student_id = 0;
            this.group_id = 0;
            this.group_name = "";
            this.student_name = "";
            this.phone = "";
            this.theme_id = 0;
            this.theme_name = "";
            this.percentage = 0;
        }
    }

    public class User
    {
        public int user_id { get; set; }
        public bool is_teacher { get; set; }
        public int id { get; set; }
        public string name { get; set; }

        public User(int user_id, bool is_teacher, int id, string name)
        {
            this.user_id = user_id;
            this.is_teacher = is_teacher;
            this.id = id;
            this.name = name;
        }

        public User ()
        {
            this.user_id = 0;
            this.is_teacher = false;
            this.id = 0;
            this.name = "";
        }

        public override string ToString()
        {
            return this.name;
        }
    }

    public class Theme
    {
        public int theme_id { get; set;}
        public int student_id { get; set; }
        public string student_name { get; set; }
        public string theme_name { get; set;}
        public int main_teacher_id { get; set; }
        public int econ_teacher_id { get; set; }
        public int safe_teacher_id { get; set; }

        public Theme (int theme_id, int student_id, string student_name, string theme_name, int main_teacher_id, int econ_teacher_id, int safe_teacher_id)
        {
            this.theme_id = theme_id;
            this.student_id = student_id;
            this.student_name = student_name;
            this.theme_name = theme_name;
            this.main_teacher_id = main_teacher_id;
            this.econ_teacher_id = econ_teacher_id;
            this.safe_teacher_id = safe_teacher_id;
        }

        public Theme ()
        {
            this.theme_id = 0;
            this.student_id = 0;
            this.student_name = "";
            this.theme_name = "";
            this.main_teacher_id = 0;
            this.econ_teacher_id = 0;
            this.safe_teacher_id = 0;
        }
    }

    public class StageName
    {
        public int stage_name_id { get; set;}
        public string stage_name { get; set;}
        
        public StageName (int stage_name_id, string stage_name)
        {
            this.stage_name_id = stage_name_id;
            this.stage_name = stage_name;
        }

        public StageName ()
        {
            this.stage_name_id = 0;
            this.stage_name = "";
        }
    }

    public class Stage : StageName
    {
        public int stage_id { get; set;}
        public int theme_id { get; set;}
        public int teacher_id { get; set;}
        public string teacher_name { get; set;}
        public int percentage { get; set;}
        public DateTime date_started { get; set;}
        public DateTime date_ended { get; set;}

        public Stage (int stage_id, int stage_name_id, string stage_name, int theme_id, int teacher_id, string teacher_name, int percentage, DateTime date_started, DateTime date_ended)
        {
            this.stage_id = stage_id;
            this.stage_name_id = stage_name_id;
            this.stage_name = stage_name;
            this.theme_id = theme_id;
            this.teacher_id = teacher_id;
            this.teacher_name = teacher_name;
            this.percentage = percentage;
            this.date_started = date_started;
            this.date_ended = date_ended;
        }

        public Stage ()
        {
            this.stage_id = 0;
            this.theme_id = 0;
            this.teacher_id = 0;
            this.teacher_name = "";
            this.percentage = 0;
            this.date_started = DateTime.Now;
            this.date_ended = DateTime.Now;
        }
    }
}

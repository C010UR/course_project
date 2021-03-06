using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CourseProject.Classes;

namespace CourseProject.Forms
{
    public partial class TeacherGroupsControl : UserControl
    {
        List<Group> groups;
        List<Student> students;

        public int studentId;
        public string studentName;
        public int themeId;

        public TeacherGroupsControl()
        {
            InitializeComponent();
        }

        public void ItemsLoad()
        {
            groups = DataBaseGet.Groups("WHERE teacher_id = " + Settings.user.id);

            groupsListBox.Items.Clear();

            if (groups.Count == 0)
            {
                groupLabel.Text = "Вы не являетесь куратором ни одной группы.\nЕсли вы являетесь куратором и группы нету, то обратитесь к администраторам.";
                groupsListBox.Hide();
                groupsGrid.Hide();
            }
            else
            {
                foreach (Group val in groups)
                {
                    groupsListBox.Items.Add(val.group_name);
                }

                groupsGrid.Rows.Clear();

                groupsListBox.SelectedIndex = 0;
            }
        }

        private void groupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (students != null)
                students.Clear();
            groupsGrid.Rows.Clear();

            students = DataBaseGet.Students("WHERE group_id = " + groups[groupsListBox.SelectedIndex].group_id);
            if (students != null)
            {
                foreach (Student val in students)
                {
                    groupsGrid.Rows.Add(val.student_id, val.student_name, val.phone, val.theme_id, val.theme_name, val.percentage);
                }
            }
        }

        private void groupsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.studentId = Convert.ToInt32(groupsGrid.Rows[e.RowIndex].Cells[0].Value);
            this.studentName = groups[groupsListBox.SelectedIndex].group_name + " " + groupsGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.themeId = Convert.ToInt32(groupsGrid.Rows[e.RowIndex].Cells[3].Value);
        }
    }
}

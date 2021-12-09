using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using CourseProject.Classes;

namespace CourseProject.Forms
{
    public partial class TeacherGroupsThemesControl : UserControl
    {
        public bool exit;

        public int studentId;
        public string studentName;
        public int themeId;

        public Theme currentTheme;

        List<Teacher> teachers;
        List<Stage> stages;

        public TeacherGroupsThemesControl()
        {
            InitializeComponent();
        }

        public void ItemsLoad(int studentId, string studentName, int themeId)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.themeId = themeId;

            currentTheme = null;
            teachers = null;
            stages = null;

            themeBox.Text = "";
            mainTeacherBox.Text = "";
            econTeacherBox.Text = "";
            safeTeacherBox.Text = "";

            studentLabel.Text = "Учащийся: " + this.studentName;

            mainTeacherBox.Items.Clear();
            econTeacherBox.Items.Clear();
            safeTeacherBox.Items.Clear();

            teachers = DataBaseGet.Teachers("");

            foreach (Teacher val in teachers)
            {
                switch (val.type_id)
                {
                    case 1: mainTeacherBox.Items.Add(val); break;
                    case 2: econTeacherBox.Items.Add(val); break;
                    case 3: safeTeacherBox.Items.Add(val); break;
                }
            }

            if (themeId < 1)
            {
                addButton.Show();
                deleteButton.Hide();
                updateButton.Hide();

                HideStages();
            }
            else
            {
                addButton.Hide();
                deleteButton.Show();
                updateButton.Show();

                ShowStages();

                currentTheme = DataBaseGet.Themes("WHERE theme_id = " + themeId)[0];

                themeBox.Text = currentTheme.theme_name;

                for (int i = 0; i < mainTeacherBox.Items.Count; i++)
                {
                    if (((Teacher)mainTeacherBox.Items[i]).teacher_id == currentTheme.main_teacher_id)
                    {
                        mainTeacherBox.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < econTeacherBox.Items.Count; i++)
                {
                    if (((Teacher)econTeacherBox.Items[i]).teacher_id == currentTheme.econ_teacher_id)
                    {
                        econTeacherBox.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < safeTeacherBox.Items.Count; i++)
                {
                    if (((Teacher)safeTeacherBox.Items[i]).teacher_id == currentTheme.safe_teacher_id)
                    {
                        safeTeacherBox.SelectedIndex = i;
                        break;
                    }
                }
            }

        }

        public void UpdateGrid()
        {
            stagesGrid.Rows.Clear();

            foreach (Stage val in stages)
            {
                stagesGrid.Rows.Add(val.stage_id, val.stage_name, val.teacher_id, val.teacher_name, val.date_started.ToString(@"dd.MM.yyyy"), val.date_ended.ToString(@"dd.MM.yyyy"));
            }
        }

        public void ShowStages()
        {
            stagesGrid.Show();
            stages = DataBaseGet.Stages("WHERE theme_id = " + themeId);
            UpdateGrid();

            stageTeacherBox.Show();
            stageTeacherBox.Items.Clear();
            teachers = DataBaseGet.Teachers("");
            foreach (Teacher val in teachers)
            {
                stageTeacherBox.Items.Add(val);
            }

            int teacher_id = Convert.ToInt32(stagesGrid.Rows[0].Cells[2].Value);
            for (int i = 0; i < stageTeacherBox.Items.Count; i++)
            {
                if (((Teacher)stageTeacherBox.Items[i]).teacher_id == teacher_id)
                    stageTeacherBox.SelectedIndex = i;
            }

            stageTeacherLabel.Show();
            stageDateEndedLabel.Show();
            stageDateEndedPicker.Show();
            stageDateStartedLabel.Show();
            stageDateStartedPicker.Show();
            stageEditButton.Show();
        }

        public void HideStages()
        {
            stagesGrid.Hide();
            stageTeacherBox.Hide();
            stageTeacherLabel.Hide();
            stageDateEndedLabel.Hide();
            stageDateEndedPicker.Hide();
            stageDateStartedLabel.Hide();
            stageDateStartedPicker.Hide();
            stageEditButton.Hide();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (mainTeacherBox.SelectedIndex < 0 || econTeacherBox.SelectedIndex < 0 || safeTeacherBox.SelectedIndex < 0)
            {
                MessageBox.Show("Введены не верные данные", "Ошибка");
            }
            else
            {
                int main_teacher_id = ((Teacher)mainTeacherBox.SelectedItem).teacher_id;
                int econ_teacher_id = ((Teacher)econTeacherBox.SelectedItem).teacher_id;
                int safe_teacher_id = ((Teacher)safeTeacherBox.SelectedItem).teacher_id;

                string err = DataBaseUpdate.Theme(themeId, studentId, themeBox.Text, main_teacher_id, econ_teacher_id, safe_teacher_id);
                if (!string.IsNullOrEmpty(err))
                {
                    MessageBox.Show(err, "Ошибка");
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (mainTeacherBox.SelectedIndex < 0 || econTeacherBox.SelectedIndex < 0 || safeTeacherBox.SelectedIndex < 0)
            {
                MessageBox.Show("Введены не верные данные", "Ошибка");
            }
            else
            {

                int main_teacher_id = ((Teacher)mainTeacherBox.SelectedItem).teacher_id;
                int econ_teacher_id = ((Teacher)econTeacherBox.SelectedItem).teacher_id;
                int safe_teacher_id = ((Teacher)safeTeacherBox.SelectedItem).teacher_id;

                string err = DataBaseAdd.Theme(studentId, themeBox.Text, main_teacher_id, econ_teacher_id, safe_teacher_id);
                if (!string.IsNullOrEmpty(err))
                {
                    if (!int.TryParse(err, out themeId))
                        MessageBox.Show(err, "Ошибка");
                    else
                    {
                        Thread.Sleep(1000);
                        ShowStages();
                        addButton.Hide();
                        deleteButton.Show();
                        updateButton.Show();
                    }
                }
                else
                {
                    Thread.Sleep(1000);
                    ShowStages();
                    addButton.Hide();
                    deleteButton.Show();
                    updateButton.Show();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataBaseDelete.Theme(themeId);
            exit = true;
        }

        private void stageEditButton_Click(object sender, EventArgs e)
        {
            int stage_id = Convert.ToInt32(stagesGrid.SelectedRows[0].Cells[0].Value);
            int teacher_id = ((Teacher)stageTeacherBox.SelectedItem).teacher_id;
            DataBaseUpdate.StageTeacherDates(stage_id, teacher_id, stageDateStartedPicker.Value, stageDateEndedPicker.Value);
            ShowStages();
        }

        private void stagesGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (stagesGrid.SelectedRows.Count > 0)
            {
                int teacher_id = Convert.ToInt32(stagesGrid.SelectedRows[0].Cells[2].Value);
                for (int i = 0; i < stageTeacherBox.Items.Count; i++)
                {
                    if (((Teacher)stageTeacherBox.Items[i]).teacher_id == teacher_id)
                        stageTeacherBox.SelectedIndex = i;
                }

                stageDateStartedPicker.Value = DateTime.ParseExact(
                    stagesGrid.SelectedRows[0].Cells[4].Value.ToString(),
                    "dd.MM.yyyy", CultureInfo.InvariantCulture
                );

                stageDateEndedPicker.Value = DateTime.ParseExact(
                    stagesGrid.SelectedRows[0].Cells[5].Value.ToString(),
                    "dd.MM.yyyy", CultureInfo.InvariantCulture
                );
            }
        }
    }
}

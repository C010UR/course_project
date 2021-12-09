using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

using CourseProject.Classes;

namespace CourseProject.Forms
{
    public partial class TeacherProjectsControl : UserControl
    {
        private void stagesList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(stagesList.Items[e.Index].ToString(), stagesList.Font, stagesList.Width).Height;
        }

        private void stagesList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(stagesList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void studentsList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(studentsList.Items[e.Index].ToString(), studentsList.Font, studentsList.Width).Height;
        }

        private void studentsList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(studentsList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        public TeacherProjectsControl()
        {
            InitializeComponent();

            stagesList.DrawMode = DrawMode.OwnerDrawVariable;
            stagesList.MeasureItem += stagesList_MeasureItem;
            stagesList.DrawItem += stagesList_DrawItem;

            studentsList.DrawMode = DrawMode.OwnerDrawVariable;
            studentsList.MeasureItem += studentsList_MeasureItem;
            studentsList.DrawItem += studentsList_DrawItem;
        }

        List<Student> students = new List<Student>();
        List<Stage> stages = new List<Stage>();
        List<Theme> lastTheme = new List<Theme>();
        int tick = -1;

        public void ItemsLoad()
        {
            updateTimer.Start();

            studentsList.Hide();
            stagesList.Hide();
            studentsList.Items.Clear();
            stagesList.Items.Clear();

            students.Clear();
            stages.Clear();
            lastTheme.Clear();

            students = DataBaseGet.Students("WHERE theme_id IN (SELECT themes.theme_id FROM themes WHERE themes.main_teacher_id = " + Settings.user.id + " OR themes.econ_teacher_id = " + Settings.user.id + " OR themes.safe_teacher_id = " + Settings.user.id + ")");
            
            if (students.Count > 0)
            {
                foreach (Student val in students)
                {
                    studentsList.Items.Add(val.group_name + " " + val.student_name);
                }

                studentsList.Show();
                stagesList.Show();

                studentsList.SelectedIndex = 0;
            }
            else
            {
                themeNameLabel.Text = "Вы не являетесь руководителем ни одного проекта.";
                studentsList.Hide();
                stagesList.Hide();
                checkedLabel.Hide();
                datesLabel.Hide();
                percentageLabel.Hide();
                percentageBox.Hide();
                percentageBar.Hide();
                percentLabel.Hide();
                cancelButton.Hide();
                submitButton.Hide();
                mainTeacherName.Hide();
                econTeacherName.Hide();
                safeTeacherName.Hide();
            }
        }

        private void stagesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStages2();
        }

        private void studentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStages();
        }

        public void UpdateStages()
        {
            int old_selected_index = stagesList.SelectedIndex == -1 ? 0 : stagesList.SelectedIndex;

            lastTheme = DataBaseGet.Themes("WHERE theme_id = " + students[studentsList.SelectedIndex].theme_id + " ORDER BY theme_id DESC LIMIT 1");

            if (lastTheme.Count == 0)
            {
                themeNameLabel.Text = "У данного учащегося нету дипломных проектов.";
                stagesList.Hide();
                checkedLabel.Hide();
                datesLabel.Hide();
                percentageLabel.Hide();
                percentageBox.Hide();
                percentageBar.Hide();
                percentLabel.Hide();
                cancelButton.Hide();
                submitButton.Hide();
                mainTeacherName.Hide();
                econTeacherName.Hide();
                safeTeacherName.Hide();
            }
            else
            {

                themeNameLabel.Text = "Тема дипломного проекта: " + lastTheme[0].theme_name;

                stages = DataBaseGet.Stages("WHERE theme_id = " + lastTheme[0].theme_id);

                stagesList.Items.Clear();
                for (int i = 0; i < stages.Count; i++)
                {
                    stagesList.Items.Add((Settings.user.id == stages[i].teacher_id ? "+ " : "- ") + (i + 1) + ". " + stages[i].stage_name);
                }

                lastTheme[0].AddTeacherNames(
                    DataBaseGet.Teachers("WHERE teacher_id = " + lastTheme[0].main_teacher_id)[0].teacher_name,
                    DataBaseGet.Teachers("WHERE teacher_id = " + lastTheme[0].econ_teacher_id)[0].teacher_name,
                    DataBaseGet.Teachers("WHERE teacher_id = " + lastTheme[0].safe_teacher_id)[0].teacher_name
                );

                mainTeacherName.Text = "Руководитель по основному разделу: " + lastTheme[0].main_teacher_name;
                econTeacherName.Text = "Руководитель по экономическому разделу: " + lastTheme[0].econ_teacher_name;
                safeTeacherName.Text = "Руководитель по разделу охраны труда: " + lastTheme[0].safe_teacher_name;

                stagesList.SelectedIndex = old_selected_index;

                UpdateStages2();
            }
        }

        public void UpdateStages2()
        {
            int old_percentage = stages[stagesList.SelectedIndex].percentage;

            if (old_percentage > 100)
            {
                checkedLabel.Text = "Статус (Выставляется преподавателем): Выполнен";

                percentageLabel.Hide();
                percentageLabel.Hide();
                percentageBox.Hide();
                percentageBar.Hide();
                percentLabel.Hide();

                if (Settings.user.id == stages[stagesList.SelectedIndex].teacher_id)
                {
                    submitButton.Hide();
                    cancelButton.Show();
                }
                else
                {
                    submitButton.Hide();
                    cancelButton.Hide();
                }

            }
            else
            {
                checkedLabel.Text = "Статус (Выставляется преподавателем): Не выполнен";

                percentageLabel.Show();
                percentageLabel.Show();
                percentageBox.Show();
                percentageBar.Show();
                percentLabel.Show();

                if (Settings.user.id == stages[stagesList.SelectedIndex].teacher_id)
                {
                    submitButton.Show();
                    cancelButton.Hide();
                }
                else
                {
                    submitButton.Hide();
                    cancelButton.Hide();
                }

                percentageBar.Value = old_percentage;
                percentageBox.Text = old_percentage.ToString();
            }
            stageTeacherLabel.Text = "Проверяющий преподаватель: " + stages[stagesList.SelectedIndex].teacher_name;
            datesLabel.Text =
                "Дата начала этапа: " + stages[stagesList.SelectedIndex].date_started.ToString("dd.MM.yyyy") +
                " Дата окончания этапа: " + stages[stagesList.SelectedIndex].date_ended.ToString("dd.MM.yyyy");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int current_stage_id = stages[stagesList.SelectedIndex].stage_id;
            int old_percentage = stages[stagesList.SelectedIndex].percentage;
            DataBaseUpdate.StagePercentageOnly(current_stage_id, old_percentage + 200);
            UpdateStages();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            int current_stage_id = stages[stagesList.SelectedIndex].stage_id;
            int old_percentage = stages[stagesList.SelectedIndex].percentage;
            DataBaseUpdate.StagePercentageOnly(current_stage_id, old_percentage - 200);
            UpdateStages();
        }

        private void percentageBar_Scroll(object sender, EventArgs e)
        {
            percentageBox.Text = percentageBar.Value.ToString();
        }

        private void percentageBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(percentageBox.Text, out int val) || val > 100 || val < 0)
            {
                percentageBox.Text = "";
                percentageBar.Value = 0;
                tick = -1;
            }
            else
            {
                int new_percentage = Convert.ToInt32(percentageBox.Text);
                int old_percentage = stages[stagesList.SelectedIndex].percentage;

                percentageBar.Value = new_percentage;
                if (new_percentage != old_percentage) tick = 1;
            }

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (tick >= 0) tick--;
            if (tick == 0) updatePercentage();
        }

        private void updatePercentage()
        {
            int current_stage_id = stages[stagesList.SelectedIndex].stage_id;
            if (stages[stagesList.SelectedIndex].percentage != Convert.ToInt32(percentageBox.Text))
            {
                DataBaseUpdate.StagePercentageOnly(current_stage_id, Convert.ToInt32(percentageBox.Text));
                stages = DataBaseGet.Stages("WHERE theme_id = " + lastTheme[0].theme_id);
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (studentsList.SelectedIndex > -1)
            {
                Excel.Application oXL;
                Excel._Workbook oWB;
                Excel._Worksheet oSheet;

                try
                {
                    oXL = new Excel.Application();
                    oXL.Visible = true;

                    oWB = oXL.Workbooks.Add();
                    oSheet = oWB.ActiveSheet as Excel.Worksheet;

                    oSheet.Cells[1, 1].Value2 = "Дата создания документа - " + DateTime.Now.ToString("dd.MM.yyyy") + "; Преподаватель, создавший документ - " + Settings.user.name;
                    oSheet.Cells[2, 1].Value2 = themeNameLabel.Text;
                    oSheet.Cells[3, 1].Value2 = mainTeacherName.Text;
                    oSheet.Cells[4, 1].Value2 = econTeacherName.Text;
                    oSheet.Cells[5, 1].Value2 = safeTeacherName.Text;

                    oSheet.get_Range("A1", "F1").Merge();
                    oSheet.get_Range("A2", "F2").Merge();
                    oSheet.get_Range("A3", "F3").Merge();
                    oSheet.get_Range("A4", "F4").Merge();
                    oSheet.get_Range("A5", "F5").Merge();

                    oSheet.Cells[6, 1] = "Этап проекта";
                    oSheet.Cells[6, 2] = "Статус";
                    oSheet.Cells[6, 3] = "Выполнено";
                    oSheet.Cells[6, 4] = "Проверяющий преподаватель";
                    oSheet.Cells[6, 5] = "Дата начала этапа";
                    oSheet.Cells[6, 6] = "Дата окончания этапа";

                    oSheet.get_Range("A1", "F5").Font.Color = Color.FromArgb(164, 165, 169);

                    oSheet.get_Range("A2", "F2").Font.Bold = true;
                    oSheet.get_Range("A2", "F2").Font.Size = 20;
                    oSheet.get_Range("A2", "F2").Font.Color = Color.FromArgb(116, 86, 174);

                    oSheet.get_Range("A1", "F1").Font.Italic = true;
                    oSheet.get_Range("A6", "F6").Font.Bold = true;

                    oSheet.get_Range("A1", "F6").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    oSheet.get_Range("A6", "F6").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    oSheet.get_Range("A1", "A1").ColumnWidth = 48;
                    oSheet.get_Range("B1", "B1").ColumnWidth = 13;
                    oSheet.get_Range("C1", "C1").ColumnWidth = 12;
                    oSheet.get_Range("D1", "D1").ColumnWidth = 32;
                    oSheet.get_Range("E1", "E1").ColumnWidth = 20;
                    oSheet.get_Range("F1", "F1").ColumnWidth = 20;


                    string[,] list = new string[stages.Count, 6];

                    for (int i = 0; i < stages.Count; i++)
                    {
                        list[i, 0] = stages[i].stage_name;
                        list[i, 1] = stages[i].percentage > 100 ? "Выполнен" : "Не выполнен";
                        list[i, 2] = stages[i].percentage > 100 ? "100 %" : stages[i].percentage.ToString() + " %";
                        list[i, 3] = stages[i].teacher_name;
                        list[i, 4] = stages[i].date_started.ToString(@"dd.MM.yyyy");
                        list[i, 5] = stages[i].date_ended.ToString(@"dd.MM.yyyy");
                    }

                    int last_cell = 6 + list.GetLength(0);

                    oSheet.get_Range("A7", "F" + last_cell).Value2 = list;

                    oXL.Visible = true;
                    oXL.UserControl = true;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Невозможно создать отчет:\n" + exc.Message, "Ошибка");
                }
            }
        }
    }
}

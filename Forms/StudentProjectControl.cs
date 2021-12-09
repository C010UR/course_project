using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using CourseProject.Classes;

namespace CourseProject.Forms
{
    public partial class StudentProjectControl : UserControl
    {
        List<Theme> lastTheme = new List<Theme>();
        List<Stage> list = new List<Stage>();

       private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
       {
            e.ItemHeight = (int)e.Graphics.MeasureString(stagesList.Items[e.Index].ToString(), stagesList.Font, stagesList.Width).Height;
       }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(stagesList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        public StudentProjectControl()
        {
            InitializeComponent();

            stagesList.DrawMode = DrawMode.OwnerDrawVariable;
            stagesList.MeasureItem += lst_MeasureItem;
            stagesList.DrawItem += lst_DrawItem;
        }

        public void ItemsLoad()
        {
            lastTheme = DataBaseGet.Themes("WHERE student_id = " + Settings.user.id + " ORDER BY theme_id DESC LIMIT 1");

            if (lastTheme.Count == 0)
            {
                themeNameLabel.Text = "У вас нету дипломных проектов.\nЕсли у вас должен быть дипломный проект, то обратитесь к преподавателю.";
                stagesList.Hide();
                checkedLabel.Hide();
                datesLabel.Hide();
                percentageLabel.Hide();
            }
            else
            {
                themeNameLabel.Text = "Тема дипломного проекта: " + lastTheme[0].theme_name;

                lastTheme[0].AddTeacherNames(
                    DataBaseGet.Teachers("WHERE teacher_id = " + lastTheme[0].main_teacher_id)[0].teacher_name,
                    DataBaseGet.Teachers("WHERE teacher_id = " + lastTheme[0].econ_teacher_id)[0].teacher_name,
                    DataBaseGet.Teachers("WHERE teacher_id = " + lastTheme[0].safe_teacher_id)[0].teacher_name
                );

                mainTeacherName.Text = "Руководитель по основному разделу: " + lastTheme[0].main_teacher_name;
                econTeacherName.Text = "Руководитель по экономическому разделу: " + lastTheme[0].econ_teacher_name;
                safeTeacherName.Text = "Руководитель по разделу охраны труда: " + lastTheme[0].safe_teacher_name;

                list = DataBaseGet.Stages("WHERE theme_id = " + lastTheme[0].theme_id);
                stagesList.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    stagesList.Items.Add((i + 1) + ". " + list[i].stage_name);
                }

                stagesList.SelectedIndex = 0;
            }

        }

        private void stagesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list[stagesList.SelectedIndex].percentage > 100)
            {
                checkedLabel.Text = "Статус (Выставляется преподавателем): Выполнен";
                percentageLabel.Hide();
            }
            else
            {
                checkedLabel.Text = "Статус (Выставляется преподавателем): Не выполнен";
                percentageLabel.Show();
                percentageLabel.Text = "Выполнено: " + list[stagesList.SelectedIndex].percentage + "%";
            }
            stageTeacherLabel.Text = "Проверяющий преподаватель: " + list[stagesList.SelectedIndex].teacher_name;
            datesLabel.Text =
                "Дата начала этапа: " + list[stagesList.SelectedIndex].date_started.ToString("dd.MM.yyyy") +
                " Дата окончания этапа: " + list[stagesList.SelectedIndex].date_ended.ToString("dd.MM.yyyy");
        }
    }
}

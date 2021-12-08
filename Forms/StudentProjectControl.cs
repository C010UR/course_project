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
        int tick = -1;

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
        }

        private void StudentProjectControl_Load(object sender, EventArgs e)
        {     
        }

        public void ItemsLoad()
        {
            stagesList.DrawMode = DrawMode.OwnerDrawVariable;
            stagesList.MeasureItem += lst_MeasureItem;
            stagesList.DrawItem += lst_DrawItem;

            updateTimer.Start();

            lastTheme = DataBaseGet.Themes("WHERE student_id = " + Settings.user.id + " ORDER BY theme_id DESC LIMIT 1");

            if (lastTheme.Count == 0)
            {
                themeNameLabel.Text = "У вас нету дипломных проектов.\nЕсли у вас должен быть дипломный проект, то обратитесь к преподавателю";
                stagesList.Hide();
                checkedLabel.Hide();
                datesLabel.Hide();
            }
            else
            {
                themeNameLabel.Text = "Тема проета: " + lastTheme[0].theme_name;

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
            int old_percentage = list[stagesList.SelectedIndex].percentage;

            if (old_percentage > 100)
            {
                checkedLabel.Text = "Статус: Проверено";

                percentageBar.Hide();
                percentageBox.Hide();
                percentageLabel.Hide();
                currentProgressLabel.Hide();
            }
            else
            {
                checkedLabel.Text = "Статус: Не проверено";

                percentageBar.Show();
                percentageBox.Show();
                percentageLabel.Show();
                currentProgressLabel.Show();

                percentageBox.Text = old_percentage.ToString();
                percentageBar.Value = old_percentage;
            }
            datesLabel.Text =
                "Дата начала этапа: " + list[stagesList.SelectedIndex].date_started.ToString("dd.MM.yyyy") +
                " Дата окончания этапа: " + list[stagesList.SelectedIndex].date_ended.ToString("dd.MM.yyyy");
        }

        private void percentageBar_Scroll(object sender, EventArgs e)
        {
            percentageBox.Text = percentageBar.Value.ToString();
        }

        private void percentageBox_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (!int.TryParse(percentageBox.Text, out val) || val > 100 || val < 0)
            {
                percentageBox.Text = "";
                percentageBar.Value = 0;
            }
            else
            {
                int new_percentage = Convert.ToInt32(percentageBox.Text);
                int old_percentage = list[stagesList.SelectedIndex].percentage;

                percentageBar.Value = new_percentage;
                if (new_percentage != old_percentage) tick = 1;
            }

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (tick >= 0) tick--;
            if (tick == 0)
                updatePercentage();
        }

        private void updatePercentage()
        {
            int current_stage_id = list[stagesList.SelectedIndex].stage_id;
            if (list[stagesList.SelectedIndex].percentage != Convert.ToInt32(percentageBox.Text))
            {
                DataBaseUpdate.StagePercentageOnly(current_stage_id, Convert.ToInt32(percentageBox.Text));
                list = DataBaseGet.Stages("WHERE theme_id = " + lastTheme[0].theme_id);
            }
        }
    }
}

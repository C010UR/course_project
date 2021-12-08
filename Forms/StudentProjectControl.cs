using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void StudentProjectControl_Load(object sender, EventArgs e)
        {     
        }

        public void ItemsLoad()
        {
            stagesList.DrawMode = DrawMode.OwnerDrawVariable;
            stagesList.MeasureItem += lst_MeasureItem;
            stagesList.DrawItem += lst_DrawItem;

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
            checkedLabel.Text = list[stagesList.SelectedIndex].percentage > 100 ? "Статус: Проверено" : "Статус: Не проверено";
            datesLabel.Text =
                "Дата начала этапа: " + list[stagesList.SelectedIndex].date_started.ToString("dd.MM.yyyy") +
                " Дата окончания этапа: " + list[stagesList.SelectedIndex].date_started.ToString("dd.MM.yyyy");
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
                percentageBox.SelectionStart = percentageBox.Text.Length;
            }
            else
            {
                percentageBar.Value = Convert.ToInt32(percentageBox.Text);
                Stage temp = list[stagesList.SelectedIndex];
                DataBaseUpdate.Stage(
                    temp.stage_id, temp.stage_name_id,
                    temp.teacher_id, Convert.ToInt32(percentageBox.Text),
                    temp.date_started.ToString("yyyy-MM-dd"), temp.date_ended.ToString("yyyy-MM-dd")
                );
            }

        }
    }
}

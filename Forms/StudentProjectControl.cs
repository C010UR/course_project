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
                themeNameLabel.Text = "У вас нету дипломных проектов";
                stagesList.Hide();
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
            }
            
        }
    }
}

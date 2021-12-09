using System;
using System.Drawing;
using System.Windows.Forms;

using CourseProject.Classes;
using CourseProject.Forms;

namespace CourseProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Settings.LoadConStr();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void teacherProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActive(sender);

            // Show TeacherProjectsControl and hide others
            hideAllControls();
            teacherProjectsControl.Show();
            teacherProjectsControl.ItemsLoad();
        }

        private void teacherGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActive(sender);

            // Show TeacherGroupsControl and hide others
            hideAllControls();
            teacherGroupsControl.Show();
            teacherGroupsControl.ItemsLoad();
        }

        private void studentProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActive(sender);

            // Show StudentProjectControl and hide others
            hideAllControls();
            studentProjectControl.Show();
            studentProjectControl.ItemsLoad();
        }

        private void setActive(object sender)
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
                item.ForeColor = Color.FromArgb(164, 165, 169);
            if (sender != null)
                ((ToolStripMenuItem)sender).ForeColor = Color.FromArgb(116, 86, 174);
        }

        public void hideAllControls()
        {
            studentProjectControl.Hide();
            teacherGroupsControl.Hide();
            teacherGroupsThemesControl.Hide();
            teacherProjectsControl.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            teacherGroupsTimer.Start();

            // Initialize database connection
            ConnectionForm connection = new ConnectionForm();
            if (!Settings.LoadConStr())
            {
                if (connection.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }

            // Authorize user
            LoginForm login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }

            if (Settings.user.is_teacher)
            {
                // TEACHER
                // Set tool bar name
                this.Text = "Преподаватель: " + Settings.user.name;

                // Add menu strip items
                ToolStripMenuItem project = new ToolStripMenuItem("projects")
                {
                    Text = "Курсовые проекты",
                    ShortcutKeys = Keys.Control | Keys.Q
                };
                project.Click += teacherProjectsToolStripMenuItem_Click;
                menuStrip.Items.Add(project);

                ToolStripMenuItem groups = new ToolStripMenuItem("groups")
                {
                    Text = "Группы",
                    ShortcutKeys = Keys.Control | Keys.W
                };
                groups.Click += teacherGroupsToolStripMenuItem_Click;
                menuStrip.Items.Add(groups);

                // Show TeacherGroupsControl and hide others
                hideAllControls();
                teacherGroupsControl.Show();
                teacherGroupsControl.ItemsLoad();

                // Activate menu strip button
                setActive(menuStrip.Items[1]);
            }
            else
            {
                // STUDENT
                // Set tool bar name
                this.Text = "Учащийся: " + Settings.user.name;

                // Add menu strip items
                ToolStripMenuItem project = new ToolStripMenuItem("projects")
                {
                    Text = "Курсовые проекты",
                    ShortcutKeys = Keys.Control | Keys.Q
                };
                project.Click += studentProjectsToolStripMenuItem_Click;
                menuStrip.Items.Add(project);

                // Show StudentProjectControl and hide others
                hideAllControls();
                studentProjectControl.Show();
                studentProjectControl.ItemsLoad();

                // Activate menu strip button
                setActive(menuStrip.Items[0]);
            }

            // Add additional menu strip items
            ToolStripMenuItem logout = new ToolStripMenuItem("logout")
            {
                Text = "Выход",
                ShortcutKeys = Keys.Control | Keys.R
            };
            logout.Click += logoutToolStripMenuItem_Click;
            menuStrip.Items.Add(logout);

            ToolStripMenuItem exit = new ToolStripMenuItem("exit")
            {
                Text = "Завершить работу",
                ShortcutKeys = Keys.Control | Keys.T
            };
            Click += exitToolStripMenuItem_Click;
            menuStrip.Items.Add(exit);

            menuStrip.ForeColor = Color.FromArgb(164, 165, 169);
        }

        private void teacherGroupsTimer_Tick(object sender, EventArgs e)
        {
            if (teacherGroupsControl.studentId > 0)
            {
                hideAllControls();
                teacherGroupsThemesControl.Show();
                teacherGroupsThemesControl.ItemsLoad(teacherGroupsControl.studentId, teacherGroupsControl.studentName, teacherGroupsControl.themeId);
                
                teacherGroupsControl.studentId = 0;
                teacherGroupsControl.studentName = null;
                teacherGroupsControl.themeId = 0;

                setActive(null);
            }

            if (teacherGroupsThemesControl.exit)
            {
                hideAllControls();
                teacherGroupsControl.Show();
                teacherGroupsControl.ItemsLoad();

                teacherGroupsThemesControl.exit = false;
            }
        }
    }
}

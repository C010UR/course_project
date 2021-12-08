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
        }

        private void teacherGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActive(sender);
        }

        private void studentProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActive(sender);
        }

        private void setActive(object sender)
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
                item.ForeColor = Color.FromArgb(164, 165, 169);
            ((ToolStripMenuItem)sender).ForeColor = Color.FromArgb(116, 86, 174);
        }

        public void hideAllControls()
        {
            studentProjectControl.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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
                ToolStripMenuItem project = new ToolStripMenuItem("projects");
                project.Text = "Курсовые проекты";
                project.ShortcutKeys = Keys.Control | Keys.Q;
                project.Click += teacherProjectsToolStripMenuItem_Click;
                menuStrip.Items.Add(project);

                ToolStripMenuItem groups = new ToolStripMenuItem("groups");
                groups.Text = "Группы";
                groups.ShortcutKeys = Keys.Control | Keys.W;
                groups.Click += teacherGroupsToolStripMenuItem_Click;
                menuStrip.Items.Add(groups);

                // Show TeacherGroupsControl and hide others
                hideAllControls();
            }
            else
            {
                // STUDENT
                // Set tool bar name
                this.Text = "Учащийся: " + Settings.user.name;

                // Add menu strip items
                ToolStripMenuItem project = new ToolStripMenuItem("projects");
                project.Text = "Курсовые проекты";
                project.ShortcutKeys = Keys.Control | Keys.Q;
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
            ToolStripMenuItem logout = new ToolStripMenuItem("logout");
            logout.Text = "Выход";
            logout.ShortcutKeys = Keys.Control | Keys.R;
            logout.Click += logoutToolStripMenuItem_Click;
            menuStrip.Items.Add(logout);

            ToolStripMenuItem exit = new ToolStripMenuItem("exit");
            exit.Text = "Завершить работу";
            exit.ShortcutKeys = Keys.Control | Keys.T;
            exit.Click += exitToolStripMenuItem_Click;
            menuStrip.Items.Add(exit);

            menuStrip.ForeColor = Color.FromArgb(164, 165, 169);
        }
    }
}

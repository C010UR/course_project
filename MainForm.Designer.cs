namespace CourseProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.teacherGroupsControl = new CourseProject.Forms.TeacherGroupsControl();
            this.studentProjectControl = new CourseProject.Forms.StudentProjectControl();
            this.teacherGroupsTimer = new System.Windows.Forms.Timer(this.components);
            this.teacherGroupsThemesControl = new CourseProject.Forms.TeacherGroupsThemesControl();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // teacherGroupsControl
            // 
            this.teacherGroupsControl.BackColor = System.Drawing.Color.GhostWhite;
            this.teacherGroupsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherGroupsControl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherGroupsControl.Location = new System.Drawing.Point(0, 24);
            this.teacherGroupsControl.Margin = new System.Windows.Forms.Padding(5);
            this.teacherGroupsControl.Name = "teacherGroupsControl";
            this.teacherGroupsControl.Size = new System.Drawing.Size(1264, 657);
            this.teacherGroupsControl.TabIndex = 2;
            // 
            // studentProjectControl
            // 
            this.studentProjectControl.BackColor = System.Drawing.Color.GhostWhite;
            this.studentProjectControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentProjectControl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentProjectControl.Location = new System.Drawing.Point(0, 24);
            this.studentProjectControl.Margin = new System.Windows.Forms.Padding(5);
            this.studentProjectControl.Name = "studentProjectControl";
            this.studentProjectControl.Size = new System.Drawing.Size(1264, 657);
            this.studentProjectControl.TabIndex = 1;
            // 
            // teacherGroupsTimer
            // 
            this.teacherGroupsTimer.Tick += new System.EventHandler(this.teacherGroupsTimer_Tick);
            // 
            // teacherGroupsThemesControl
            // 
            this.teacherGroupsThemesControl.BackColor = System.Drawing.Color.GhostWhite;
            this.teacherGroupsThemesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherGroupsThemesControl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherGroupsThemesControl.Location = new System.Drawing.Point(0, 24);
            this.teacherGroupsThemesControl.Margin = new System.Windows.Forms.Padding(5);
            this.teacherGroupsThemesControl.Name = "teacherGroupsThemesControl";
            this.teacherGroupsThemesControl.Size = new System.Drawing.Size(1264, 657);
            this.teacherGroupsThemesControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.teacherGroupsThemesControl);
            this.Controls.Add(this.teacherGroupsControl);
            this.Controls.Add(this.studentProjectControl);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "Курсовые проекты";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private Forms.StudentProjectControl studentProjectControl;
        private Forms.TeacherGroupsControl teacherGroupsControl;
        private System.Windows.Forms.Timer teacherGroupsTimer;
        private Forms.TeacherGroupsThemesControl teacherGroupsThemesControl;
    }
}


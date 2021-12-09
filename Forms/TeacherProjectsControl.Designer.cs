namespace CourseProject.Forms
{
    partial class TeacherProjectsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.datesLabel = new System.Windows.Forms.Label();
            this.checkedLabel = new System.Windows.Forms.Label();
            this.themeNameLabel = new System.Windows.Forms.Label();
            this.stagesList = new System.Windows.Forms.ListBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.currentProgressLabel = new System.Windows.Forms.Label();
            this.studentsList = new System.Windows.Forms.ListBox();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.safeTeacherName = new System.Windows.Forms.Label();
            this.econTeacherName = new System.Windows.Forms.Label();
            this.mainTeacherName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datesLabel
            // 
            this.datesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datesLabel.AutoSize = true;
            this.datesLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.datesLabel.Location = new System.Drawing.Point(233, 472);
            this.datesLabel.Name = "datesLabel";
            this.datesLabel.Size = new System.Drawing.Size(317, 20);
            this.datesLabel.TabIndex = 5;
            this.datesLabel.Text = "Дата начала этапа: Дата окончания этапа";
            // 
            // checkedLabel
            // 
            this.checkedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedLabel.AutoSize = true;
            this.checkedLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.checkedLabel.Location = new System.Drawing.Point(230, 435);
            this.checkedLabel.Name = "checkedLabel";
            this.checkedLabel.Size = new System.Drawing.Size(332, 37);
            this.checkedLabel.TabIndex = 6;
            this.checkedLabel.Text = "Статус: Не проверено";
            // 
            // themeNameLabel
            // 
            this.themeNameLabel.AutoSize = true;
            this.themeNameLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.themeNameLabel.Location = new System.Drawing.Point(230, 30);
            this.themeNameLabel.Name = "themeNameLabel";
            this.themeNameLabel.Size = new System.Drawing.Size(213, 37);
            this.themeNameLabel.TabIndex = 7;
            this.themeNameLabel.Text = "Тема проекта";
            // 
            // stagesList
            // 
            this.stagesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stagesList.BackColor = System.Drawing.Color.GhostWhite;
            this.stagesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stagesList.FormattingEnabled = true;
            this.stagesList.ItemHeight = 22;
            this.stagesList.Location = new System.Drawing.Point(232, 97);
            this.stagesList.Margin = new System.Windows.Forms.Padding(5);
            this.stagesList.Name = "stagesList";
            this.stagesList.Size = new System.Drawing.Size(1018, 266);
            this.stagesList.TabIndex = 9;
            this.stagesList.SelectedIndexChanged += new System.EventHandler(this.stagesList_SelectedIndexChanged);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1000;
            // 
            // currentProgressLabel
            // 
            this.currentProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentProgressLabel.AutoSize = true;
            this.currentProgressLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.currentProgressLabel.Location = new System.Drawing.Point(33, 572);
            this.currentProgressLabel.Name = "currentProgressLabel";
            this.currentProgressLabel.Size = new System.Drawing.Size(151, 20);
            this.currentProgressLabel.TabIndex = 8;
            this.currentProgressLabel.Text = "Текущий прогресс";
            // 
            // studentsList
            // 
            this.studentsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.studentsList.BackColor = System.Drawing.Color.GhostWhite;
            this.studentsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentsList.FormattingEnabled = true;
            this.studentsList.ItemHeight = 22;
            this.studentsList.Location = new System.Drawing.Point(30, 30);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(194, 640);
            this.studentsList.TabIndex = 13;
            this.studentsList.SelectedIndexChanged += new System.EventHandler(this.studentsList_SelectedIndexChanged);
            // 
            // percentageLabel
            // 
            this.percentageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.percentageLabel.Location = new System.Drawing.Point(230, 522);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(239, 37);
            this.percentageLabel.TabIndex = 6;
            this.percentageLabel.Text = "Выполнено: 0%";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.submitButton.Location = new System.Drawing.Point(568, 442);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(216, 30);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Проверить";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.cancelButton.Location = new System.Drawing.Point(568, 442);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(216, 30);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // safeTeacherName
            // 
            this.safeTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.safeTeacherName.AutoSize = true;
            this.safeTeacherName.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.safeTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.safeTeacherName.Location = new System.Drawing.Point(233, 599);
            this.safeTeacherName.Name = "safeTeacherName";
            this.safeTeacherName.Size = new System.Drawing.Size(316, 20);
            this.safeTeacherName.TabIndex = 16;
            this.safeTeacherName.Text = "Руководитель по разделу охраны труда:";
            // 
            // econTeacherName
            // 
            this.econTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.econTeacherName.AutoSize = true;
            this.econTeacherName.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.econTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.econTeacherName.Location = new System.Drawing.Point(233, 579);
            this.econTeacherName.Name = "econTeacherName";
            this.econTeacherName.Size = new System.Drawing.Size(341, 20);
            this.econTeacherName.TabIndex = 17;
            this.econTeacherName.Text = "Руководитель по экономическому разделу:";
            // 
            // mainTeacherName
            // 
            this.mainTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mainTeacherName.AutoSize = true;
            this.mainTeacherName.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.mainTeacherName.Location = new System.Drawing.Point(233, 559);
            this.mainTeacherName.Name = "mainTeacherName";
            this.mainTeacherName.Size = new System.Drawing.Size(295, 20);
            this.mainTeacherName.TabIndex = 18;
            this.mainTeacherName.Text = "Руководитель по основному разделу:";
            // 
            // TeacherProjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.safeTeacherName);
            this.Controls.Add(this.econTeacherName);
            this.Controls.Add(this.mainTeacherName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.datesLabel);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.checkedLabel);
            this.Controls.Add(this.themeNameLabel);
            this.Controls.Add(this.stagesList);
            this.Controls.Add(this.currentProgressLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TeacherProjectsControl";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label datesLabel;
        private System.Windows.Forms.Label checkedLabel;
        private System.Windows.Forms.Label themeNameLabel;
        private System.Windows.Forms.ListBox stagesList;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label currentProgressLabel;
        private System.Windows.Forms.ListBox studentsList;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label safeTeacherName;
        private System.Windows.Forms.Label econTeacherName;
        private System.Windows.Forms.Label mainTeacherName;
    }
}

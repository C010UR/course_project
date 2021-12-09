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
            this.studentsList = new System.Windows.Forms.ListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.safeTeacherName = new System.Windows.Forms.Label();
            this.econTeacherName = new System.Windows.Forms.Label();
            this.mainTeacherName = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.percentageBox = new System.Windows.Forms.TextBox();
            this.percentageBar = new System.Windows.Forms.TrackBar();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.stageTeacherLabel = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.percentageBar)).BeginInit();
            this.SuspendLayout();
            // 
            // datesLabel
            // 
            this.datesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datesLabel.AutoSize = true;
            this.datesLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.datesLabel.Location = new System.Drawing.Point(233, 492);
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
            this.checkedLabel.Size = new System.Drawing.Size(796, 37);
            this.checkedLabel.TabIndex = 6;
            this.checkedLabel.Text = "Статус (Выставляется преподавателем): Не выполнен";
            // 
            // themeNameLabel
            // 
            this.themeNameLabel.AutoSize = true;
            this.themeNameLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.themeNameLabel.Location = new System.Drawing.Point(230, 30);
            this.themeNameLabel.Name = "themeNameLabel";
            this.themeNameLabel.Size = new System.Drawing.Size(405, 37);
            this.themeNameLabel.TabIndex = 7;
            this.themeNameLabel.Text = "Тема дипломного проекта:";
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
            this.stagesList.Location = new System.Drawing.Point(237, 132);
            this.stagesList.Margin = new System.Windows.Forms.Padding(5);
            this.stagesList.Name = "stagesList";
            this.stagesList.Size = new System.Drawing.Size(1018, 266);
            this.stagesList.TabIndex = 2;
            this.stagesList.SelectedIndexChanged += new System.EventHandler(this.stagesList_SelectedIndexChanged);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
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
            this.studentsList.TabIndex = 1;
            this.studentsList.SelectedIndexChanged += new System.EventHandler(this.studentsList_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.submitButton.Location = new System.Drawing.Point(1039, 442);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(216, 30);
            this.submitButton.TabIndex = 3;
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
            this.cancelButton.Location = new System.Drawing.Point(1039, 442);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelButton.Size = new System.Drawing.Size(216, 30);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // safeTeacherName
            // 
            this.safeTeacherName.AutoSize = true;
            this.safeTeacherName.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.safeTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.safeTeacherName.Location = new System.Drawing.Point(233, 107);
            this.safeTeacherName.Name = "safeTeacherName";
            this.safeTeacherName.Size = new System.Drawing.Size(316, 20);
            this.safeTeacherName.TabIndex = 16;
            this.safeTeacherName.Text = "Руководитель по разделу охраны труда:";
            // 
            // econTeacherName
            // 
            this.econTeacherName.AutoSize = true;
            this.econTeacherName.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.econTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.econTeacherName.Location = new System.Drawing.Point(233, 87);
            this.econTeacherName.Name = "econTeacherName";
            this.econTeacherName.Size = new System.Drawing.Size(341, 20);
            this.econTeacherName.TabIndex = 17;
            this.econTeacherName.Text = "Руководитель по экономическому разделу:";
            // 
            // mainTeacherName
            // 
            this.mainTeacherName.AutoSize = true;
            this.mainTeacherName.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.mainTeacherName.Location = new System.Drawing.Point(233, 67);
            this.mainTeacherName.Name = "mainTeacherName";
            this.mainTeacherName.Size = new System.Drawing.Size(295, 20);
            this.mainTeacherName.TabIndex = 18;
            this.mainTeacherName.Text = "Руководитель по основному разделу:";
            // 
            // percentLabel
            // 
            this.percentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentLabel.AutoSize = true;
            this.percentLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentLabel.Location = new System.Drawing.Point(658, 569);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(24, 22);
            this.percentLabel.TabIndex = 22;
            this.percentLabel.Text = "%";
            // 
            // percentageBox
            // 
            this.percentageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentageBox.Location = new System.Drawing.Point(556, 567);
            this.percentageBox.Name = "percentageBox";
            this.percentageBox.Size = new System.Drawing.Size(100, 27);
            this.percentageBox.TabIndex = 21;
            this.percentageBox.Text = "0";
            this.percentageBox.TextChanged += new System.EventHandler(this.percentageBox_TextChanged);
            // 
            // percentageBar
            // 
            this.percentageBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentageBar.LargeChange = 10;
            this.percentageBar.Location = new System.Drawing.Point(237, 567);
            this.percentageBar.Maximum = 100;
            this.percentageBar.Name = "percentageBar";
            this.percentageBar.Size = new System.Drawing.Size(313, 45);
            this.percentageBar.TabIndex = 20;
            this.percentageBar.TickFrequency = 10;
            this.percentageBar.Scroll += new System.EventHandler(this.percentageBar_Scroll);
            // 
            // percentageLabel
            // 
            this.percentageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.percentageLabel.Location = new System.Drawing.Point(233, 544);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(151, 20);
            this.percentageLabel.TabIndex = 19;
            this.percentageLabel.Text = "Текущий прогресс";
            // 
            // stageTeacherLabel
            // 
            this.stageTeacherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stageTeacherLabel.AutoSize = true;
            this.stageTeacherLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stageTeacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.stageTeacherLabel.Location = new System.Drawing.Point(233, 472);
            this.stageTeacherLabel.Name = "stageTeacherLabel";
            this.stageTeacherLabel.Size = new System.Drawing.Size(248, 20);
            this.stageTeacherLabel.TabIndex = 23;
            this.stageTeacherLabel.Text = "Проверяющий преподаватель: ";
            // 
            // reportButton
            // 
            this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.reportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.reportButton.Location = new System.Drawing.Point(1039, 94);
            this.reportButton.Name = "reportButton";
            this.reportButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportButton.Size = new System.Drawing.Size(216, 30);
            this.reportButton.TabIndex = 24;
            this.reportButton.Text = "Отчет";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // TeacherProjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.stageTeacherLabel);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.percentageBox);
            this.Controls.Add(this.percentageBar);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.safeTeacherName);
            this.Controls.Add(this.econTeacherName);
            this.Controls.Add(this.mainTeacherName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.datesLabel);
            this.Controls.Add(this.checkedLabel);
            this.Controls.Add(this.themeNameLabel);
            this.Controls.Add(this.stagesList);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TeacherProjectsControl";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.percentageBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label datesLabel;
        private System.Windows.Forms.Label checkedLabel;
        private System.Windows.Forms.Label themeNameLabel;
        private System.Windows.Forms.ListBox stagesList;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ListBox studentsList;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label safeTeacherName;
        private System.Windows.Forms.Label econTeacherName;
        private System.Windows.Forms.Label mainTeacherName;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.TextBox percentageBox;
        private System.Windows.Forms.TrackBar percentageBar;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Label stageTeacherLabel;
        private System.Windows.Forms.Button reportButton;
    }
}

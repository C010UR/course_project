
namespace CourseProject.Forms
{
    partial class StudentProjectControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.stagesList = new System.Windows.Forms.ListBox();
            this.themeNameLabel = new System.Windows.Forms.Label();
            this.checkedLabel = new System.Windows.Forms.Label();
            this.datesLabel = new System.Windows.Forms.Label();
            this.mainTeacherName = new System.Windows.Forms.Label();
            this.econTeacherName = new System.Windows.Forms.Label();
            this.safeTeacherName = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.stageTeacherLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.stagesList.Location = new System.Drawing.Point(37, 132);
            this.stagesList.Margin = new System.Windows.Forms.Padding(5);
            this.stagesList.Name = "stagesList";
            this.stagesList.Size = new System.Drawing.Size(1220, 266);
            this.stagesList.TabIndex = 1;
            this.stagesList.SelectedIndexChanged += new System.EventHandler(this.stagesList_SelectedIndexChanged);
            // 
            // themeNameLabel
            // 
            this.themeNameLabel.AutoSize = true;
            this.themeNameLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.themeNameLabel.Location = new System.Drawing.Point(30, 30);
            this.themeNameLabel.Name = "themeNameLabel";
            this.themeNameLabel.Size = new System.Drawing.Size(398, 37);
            this.themeNameLabel.TabIndex = 0;
            this.themeNameLabel.Text = "Тема дипломного проекта";
            // 
            // checkedLabel
            // 
            this.checkedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedLabel.AutoSize = true;
            this.checkedLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.checkedLabel.Location = new System.Drawing.Point(30, 428);
            this.checkedLabel.Name = "checkedLabel";
            this.checkedLabel.Size = new System.Drawing.Size(796, 37);
            this.checkedLabel.TabIndex = 0;
            this.checkedLabel.Text = "Статус (Выставляется преподавателем): Не выполнен";
            // 
            // datesLabel
            // 
            this.datesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datesLabel.AutoSize = true;
            this.datesLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.datesLabel.Location = new System.Drawing.Point(33, 485);
            this.datesLabel.Name = "datesLabel";
            this.datesLabel.Size = new System.Drawing.Size(317, 20);
            this.datesLabel.TabIndex = 0;
            this.datesLabel.Text = "Дата начала этапа: Дата окончания этапа";
            // 
            // mainTeacherName
            // 
            this.mainTeacherName.AutoSize = true;
            this.mainTeacherName.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.mainTeacherName.Location = new System.Drawing.Point(33, 67);
            this.mainTeacherName.Name = "mainTeacherName";
            this.mainTeacherName.Size = new System.Drawing.Size(295, 20);
            this.mainTeacherName.TabIndex = 0;
            this.mainTeacherName.Text = "Руководитель по основному разделу:";
            // 
            // econTeacherName
            // 
            this.econTeacherName.AutoSize = true;
            this.econTeacherName.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.econTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.econTeacherName.Location = new System.Drawing.Point(33, 87);
            this.econTeacherName.Name = "econTeacherName";
            this.econTeacherName.Size = new System.Drawing.Size(341, 20);
            this.econTeacherName.TabIndex = 0;
            this.econTeacherName.Text = "Руководитель по экономическому разделу:";
            // 
            // safeTeacherName
            // 
            this.safeTeacherName.AutoSize = true;
            this.safeTeacherName.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.safeTeacherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.safeTeacherName.Location = new System.Drawing.Point(33, 107);
            this.safeTeacherName.Name = "safeTeacherName";
            this.safeTeacherName.Size = new System.Drawing.Size(316, 20);
            this.safeTeacherName.TabIndex = 0;
            this.safeTeacherName.Text = "Руководитель по разделу охраны труда:";
            // 
            // percentageLabel
            // 
            this.percentageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.percentageLabel.Location = new System.Drawing.Point(30, 535);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(239, 37);
            this.percentageLabel.TabIndex = 7;
            this.percentageLabel.Text = "Выполнено: 0%";
            // 
            // stageTeacherLabel
            // 
            this.stageTeacherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stageTeacherLabel.AutoSize = true;
            this.stageTeacherLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stageTeacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.stageTeacherLabel.Location = new System.Drawing.Point(33, 465);
            this.stageTeacherLabel.Name = "stageTeacherLabel";
            this.stageTeacherLabel.Size = new System.Drawing.Size(248, 20);
            this.stageTeacherLabel.TabIndex = 0;
            this.stageTeacherLabel.Text = "Проверяющий преподаватель: ";
            // 
            // StudentProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.safeTeacherName);
            this.Controls.Add(this.econTeacherName);
            this.Controls.Add(this.mainTeacherName);
            this.Controls.Add(this.stageTeacherLabel);
            this.Controls.Add(this.datesLabel);
            this.Controls.Add(this.checkedLabel);
            this.Controls.Add(this.themeNameLabel);
            this.Controls.Add(this.stagesList);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StudentProjectControl";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stagesList;
        private System.Windows.Forms.Label themeNameLabel;
        private System.Windows.Forms.Label checkedLabel;
        private System.Windows.Forms.Label datesLabel;
        private System.Windows.Forms.Label mainTeacherName;
        private System.Windows.Forms.Label econTeacherName;
        private System.Windows.Forms.Label safeTeacherName;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Label stageTeacherLabel;
    }
}

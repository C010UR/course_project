
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
            this.components = new System.ComponentModel.Container();
            this.stagesList = new System.Windows.Forms.ListBox();
            this.themeNameLabel = new System.Windows.Forms.Label();
            this.checkedLabel = new System.Windows.Forms.Label();
            this.datesLabel = new System.Windows.Forms.Label();
            this.percentageBar = new System.Windows.Forms.TrackBar();
            this.percentageBox = new System.Windows.Forms.TextBox();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.currentProgressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.percentageBar)).BeginInit();
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
            this.stagesList.Location = new System.Drawing.Point(30, 97);
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
            this.themeNameLabel.Size = new System.Drawing.Size(213, 37);
            this.themeNameLabel.TabIndex = 0;
            this.themeNameLabel.Text = "Тема проекта";
            // 
            // checkedLabel
            // 
            this.checkedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedLabel.AutoSize = true;
            this.checkedLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.checkedLabel.Location = new System.Drawing.Point(30, 435);
            this.checkedLabel.Name = "checkedLabel";
            this.checkedLabel.Size = new System.Drawing.Size(332, 37);
            this.checkedLabel.TabIndex = 0;
            this.checkedLabel.Text = "Статус: Не проверено";
            // 
            // datesLabel
            // 
            this.datesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datesLabel.AutoSize = true;
            this.datesLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.datesLabel.Location = new System.Drawing.Point(33, 472);
            this.datesLabel.Name = "datesLabel";
            this.datesLabel.Size = new System.Drawing.Size(317, 20);
            this.datesLabel.TabIndex = 0;
            this.datesLabel.Text = "Дата начала этапа: Дата окончания этапа";
            // 
            // percentageBar
            // 
            this.percentageBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentageBar.LargeChange = 10;
            this.percentageBar.Location = new System.Drawing.Point(37, 545);
            this.percentageBar.Maximum = 100;
            this.percentageBar.Name = "percentageBar";
            this.percentageBar.Size = new System.Drawing.Size(313, 45);
            this.percentageBar.TabIndex = 2;
            this.percentageBar.TickFrequency = 10;
            this.percentageBar.Scroll += new System.EventHandler(this.percentageBar_Scroll);
            // 
            // percentageBox
            // 
            this.percentageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percentageBox.Location = new System.Drawing.Point(356, 545);
            this.percentageBox.Name = "percentageBox";
            this.percentageBox.Size = new System.Drawing.Size(100, 27);
            this.percentageBox.TabIndex = 3;
            this.percentageBox.Text = "0";
            this.percentageBox.TextChanged += new System.EventHandler(this.percentageBox_TextChanged);
            // 
            // percentageLabel
            // 
            this.percentageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentageLabel.Location = new System.Drawing.Point(458, 547);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(24, 22);
            this.percentageLabel.TabIndex = 4;
            this.percentageLabel.Text = "%";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // currentProgressLabel
            // 
            this.currentProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentProgressLabel.AutoSize = true;
            this.currentProgressLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.currentProgressLabel.Location = new System.Drawing.Point(33, 522);
            this.currentProgressLabel.Name = "currentProgressLabel";
            this.currentProgressLabel.Size = new System.Drawing.Size(151, 20);
            this.currentProgressLabel.TabIndex = 0;
            this.currentProgressLabel.Text = "Текущий прогресс";
            // 
            // StudentProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.percentageBox);
            this.Controls.Add(this.percentageBar);
            this.Controls.Add(this.currentProgressLabel);
            this.Controls.Add(this.datesLabel);
            this.Controls.Add(this.checkedLabel);
            this.Controls.Add(this.themeNameLabel);
            this.Controls.Add(this.stagesList);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StudentProjectControl";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.StudentProjectControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.percentageBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stagesList;
        private System.Windows.Forms.Label themeNameLabel;
        private System.Windows.Forms.Label checkedLabel;
        private System.Windows.Forms.Label datesLabel;
        private System.Windows.Forms.TrackBar percentageBar;
        private System.Windows.Forms.TextBox percentageBox;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label currentProgressLabel;
    }
}

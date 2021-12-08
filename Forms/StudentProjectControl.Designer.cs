
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
            this.SuspendLayout();
            // 
            // stagesList
            // 
            this.stagesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stagesList.BackColor = System.Drawing.Color.GhostWhite;
            this.stagesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stagesList.FormattingEnabled = true;
            this.stagesList.ItemHeight = 22;
            this.stagesList.Location = new System.Drawing.Point(5, 97);
            this.stagesList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.stagesList.Name = "stagesList";
            this.stagesList.Size = new System.Drawing.Size(1455, 308);
            this.stagesList.TabIndex = 0;
            // 
            // themeNameLabel
            // 
            this.themeNameLabel.AutoSize = true;
            this.themeNameLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.themeNameLabel.Location = new System.Drawing.Point(3, 30);
            this.themeNameLabel.Name = "themeNameLabel";
            this.themeNameLabel.Size = new System.Drawing.Size(213, 37);
            this.themeNameLabel.TabIndex = 1;
            this.themeNameLabel.Text = "Тема проекта";
            // 
            // StudentProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.themeNameLabel);
            this.Controls.Add(this.stagesList);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "StudentProjectControl";
            this.Size = new System.Drawing.Size(1467, 833);
            this.Load += new System.EventHandler(this.StudentProjectControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stagesList;
        private System.Windows.Forms.Label themeNameLabel;
    }
}

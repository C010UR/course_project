namespace CourseProject.Forms
{
    partial class TeacherGroupsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.groupsGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theme_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherGroupsControlEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.groupLabel.Location = new System.Drawing.Point(30, 30);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(124, 37);
            this.groupLabel.TabIndex = 1;
            this.groupLabel.Text = "Группы";
            // 
            // groupsListBox
            // 
            this.groupsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupsListBox.BackColor = System.Drawing.Color.GhostWhite;
            this.groupsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.ItemHeight = 22;
            this.groupsListBox.Location = new System.Drawing.Point(30, 97);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(194, 596);
            this.groupsListBox.TabIndex = 2;
            this.groupsListBox.SelectedIndexChanged += new System.EventHandler(this.groupsListBox_SelectedIndexChanged);
            // 
            // groupsGrid
            // 
            this.groupsGrid.AllowCustomTheming = true;
            this.groupsGrid.AllowUserToAddRows = false;
            this.groupsGrid.AllowUserToDeleteRows = false;
            this.groupsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.groupsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.groupsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupsGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.groupsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.groupsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(106)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.groupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_name,
            this.phone,
            this.theme_name,
            this.percentage});
            this.groupsGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.groupsGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.groupsGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.groupsGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.groupsGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.GhostWhite;
            this.groupsGrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.groupsGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.groupsGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.groupsGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.groupsGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupsGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(106)))), ((int)(((byte)(194)))));
            this.groupsGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.GhostWhite;
            this.groupsGrid.CurrentTheme.Name = null;
            this.groupsGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.Lavender;
            this.groupsGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.groupsGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.groupsGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.groupsGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.groupsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.groupsGrid.EnableHeadersVisualStyles = false;
            this.groupsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.groupsGrid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.groupsGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.groupsGrid.HeaderForeColor = System.Drawing.Color.GhostWhite;
            this.groupsGrid.Location = new System.Drawing.Point(251, 97);
            this.groupsGrid.MultiSelect = false;
            this.groupsGrid.Name = "groupsGrid";
            this.groupsGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.groupsGrid.RowHeadersVisible = false;
            this.groupsGrid.RowTemplate.DividerHeight = 1;
            this.groupsGrid.RowTemplate.Height = 50;
            this.groupsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.groupsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupsGrid.Size = new System.Drawing.Size(998, 596);
            this.groupsGrid.TabIndex = 3;
            this.groupsGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            // 
            // student_name
            // 
            this.student_name.HeaderText = "Учащийся";
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // theme_name
            // 
            this.theme_name.HeaderText = "Тема";
            this.theme_name.Name = "theme_name";
            this.theme_name.ReadOnly = true;
            // 
            // percentage
            // 
            this.percentage.HeaderText = "Процент выполнения";
            this.percentage.Name = "percentage";
            this.percentage.ReadOnly = true;
            // 
            // TeacherGroupsControlEllipse
            // 
            this.TeacherGroupsControlEllipse.ElipseRadius = 7;
            this.TeacherGroupsControlEllipse.TargetControl = this.groupsGrid;
            // 
            // TeacherGroupsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.groupsGrid);
            this.Controls.Add(this.groupsListBox);
            this.Controls.Add(this.groupLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TeacherGroupsControl";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ListBox groupsListBox;
        private Bunifu.UI.WinForms.BunifuDataGridView groupsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn theme_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
        private Bunifu.Framework.UI.BunifuElipse TeacherGroupsControlEllipse;
    }
}

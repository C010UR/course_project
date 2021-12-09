namespace CourseProject.Forms
{
    partial class TeacherGroupsThemesControl
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
            this.stagesGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.stage_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stage_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLabel = new System.Windows.Forms.Label();
            this.TeacherGroupsControlEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.themeBox = new System.Windows.Forms.TextBox();
            this.themeLabel = new System.Windows.Forms.Label();
            this.mainTeacherLabel = new System.Windows.Forms.Label();
            this.econTeacherLabel = new System.Windows.Forms.Label();
            this.safeTeacherLabel = new System.Windows.Forms.Label();
            this.mainTeacherBox = new System.Windows.Forms.ComboBox();
            this.econTeacherBox = new System.Windows.Forms.ComboBox();
            this.safeTeacherBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.stageTeacherLabel = new System.Windows.Forms.Label();
            this.stageTeacherBox = new System.Windows.Forms.ComboBox();
            this.stageDateStartedPicker = new System.Windows.Forms.DateTimePicker();
            this.stageDateEndedPicker = new System.Windows.Forms.DateTimePicker();
            this.stageDateStartedLabel = new System.Windows.Forms.Label();
            this.stageDateEndedLabel = new System.Windows.Forms.Label();
            this.stageEditButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.stagesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // stagesGrid
            // 
            this.stagesGrid.AllowCustomTheming = true;
            this.stagesGrid.AllowUserToAddRows = false;
            this.stagesGrid.AllowUserToDeleteRows = false;
            this.stagesGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.stagesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stagesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stagesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stagesGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.stagesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stagesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.stagesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(106)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stagesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stagesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stagesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stage_id,
            this.stage_name,
            this.teacher_id,
            this.teacher_name,
            this.date_added,
            this.date_ended});
            this.stagesGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.stagesGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.stagesGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.stagesGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.stagesGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.GhostWhite;
            this.stagesGrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.stagesGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.stagesGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.stagesGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.stagesGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.GhostWhite;
            this.stagesGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(106)))), ((int)(((byte)(194)))));
            this.stagesGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.GhostWhite;
            this.stagesGrid.CurrentTheme.Name = null;
            this.stagesGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.Lavender;
            this.stagesGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.stagesGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.stagesGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.stagesGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stagesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.stagesGrid.EnableHeadersVisualStyles = false;
            this.stagesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.stagesGrid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.stagesGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.stagesGrid.HeaderForeColor = System.Drawing.Color.GhostWhite;
            this.stagesGrid.Location = new System.Drawing.Point(37, 325);
            this.stagesGrid.MultiSelect = false;
            this.stagesGrid.Name = "stagesGrid";
            this.stagesGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stagesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.stagesGrid.RowHeadersVisible = false;
            this.stagesGrid.RowTemplate.DividerHeight = 1;
            this.stagesGrid.RowTemplate.Height = 40;
            this.stagesGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stagesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stagesGrid.Size = new System.Drawing.Size(1220, 271);
            this.stagesGrid.TabIndex = 8;
            this.stagesGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            this.stagesGrid.SelectionChanged += new System.EventHandler(this.stagesGrid_SelectionChanged);
            // 
            // stage_id
            // 
            this.stage_id.HeaderText = "stage_id";
            this.stage_id.Name = "stage_id";
            this.stage_id.ReadOnly = true;
            this.stage_id.Visible = false;
            // 
            // stage_name
            // 
            this.stage_name.HeaderText = "Этап";
            this.stage_name.Name = "stage_name";
            this.stage_name.ReadOnly = true;
            // 
            // teacher_id
            // 
            this.teacher_id.HeaderText = "teacher_id";
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.ReadOnly = true;
            this.teacher_id.Visible = false;
            // 
            // teacher_name
            // 
            this.teacher_name.HeaderText = "Преподаватель";
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.ReadOnly = true;
            // 
            // date_added
            // 
            this.date_added.HeaderText = "Дата начала";
            this.date_added.Name = "date_added";
            this.date_added.ReadOnly = true;
            // 
            // date_ended
            // 
            this.date_ended.HeaderText = "Дата окончания";
            this.date_ended.Name = "date_ended";
            this.date_ended.ReadOnly = true;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.studentLabel.Location = new System.Drawing.Point(30, 30);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(179, 37);
            this.studentLabel.TabIndex = 4;
            this.studentLabel.Text = "Учащийся: ";
            // 
            // TeacherGroupsControlEllipse
            // 
            this.TeacherGroupsControlEllipse.ElipseRadius = 7;
            this.TeacherGroupsControlEllipse.TargetControl = this.stagesGrid;
            // 
            // themeBox
            // 
            this.themeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.themeBox.Location = new System.Drawing.Point(37, 90);
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(543, 27);
            this.themeBox.TabIndex = 1;
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.themeLabel.Location = new System.Drawing.Point(33, 67);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(45, 20);
            this.themeLabel.TabIndex = 8;
            this.themeLabel.Text = "Тема";
            // 
            // mainTeacherLabel
            // 
            this.mainTeacherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTeacherLabel.AutoSize = true;
            this.mainTeacherLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTeacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.mainTeacherLabel.Location = new System.Drawing.Point(710, 67);
            this.mainTeacherLabel.Name = "mainTeacherLabel";
            this.mainTeacherLabel.Size = new System.Drawing.Size(291, 20);
            this.mainTeacherLabel.TabIndex = 8;
            this.mainTeacherLabel.Text = "Преподаватель по основному отделу";
            // 
            // econTeacherLabel
            // 
            this.econTeacherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.econTeacherLabel.AutoSize = true;
            this.econTeacherLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.econTeacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.econTeacherLabel.Location = new System.Drawing.Point(710, 123);
            this.econTeacherLabel.Name = "econTeacherLabel";
            this.econTeacherLabel.Size = new System.Drawing.Size(337, 20);
            this.econTeacherLabel.TabIndex = 8;
            this.econTeacherLabel.Text = "Преподаватель по экономическому отделу";
            // 
            // safeTeacherLabel
            // 
            this.safeTeacherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.safeTeacherLabel.AutoSize = true;
            this.safeTeacherLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.safeTeacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.safeTeacherLabel.Location = new System.Drawing.Point(710, 179);
            this.safeTeacherLabel.Name = "safeTeacherLabel";
            this.safeTeacherLabel.Size = new System.Drawing.Size(312, 20);
            this.safeTeacherLabel.TabIndex = 8;
            this.safeTeacherLabel.Text = "Преподаватель по отделу охраны труда";
            // 
            // mainTeacherBox
            // 
            this.mainTeacherBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTeacherBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mainTeacherBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mainTeacherBox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTeacherBox.FormattingEnabled = true;
            this.mainTeacherBox.Location = new System.Drawing.Point(714, 90);
            this.mainTeacherBox.Name = "mainTeacherBox";
            this.mainTeacherBox.Size = new System.Drawing.Size(543, 30);
            this.mainTeacherBox.TabIndex = 2;
            // 
            // econTeacherBox
            // 
            this.econTeacherBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.econTeacherBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.econTeacherBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.econTeacherBox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.econTeacherBox.FormattingEnabled = true;
            this.econTeacherBox.Location = new System.Drawing.Point(714, 146);
            this.econTeacherBox.Name = "econTeacherBox";
            this.econTeacherBox.Size = new System.Drawing.Size(543, 30);
            this.econTeacherBox.TabIndex = 3;
            // 
            // safeTeacherBox
            // 
            this.safeTeacherBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.safeTeacherBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.safeTeacherBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.safeTeacherBox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safeTeacherBox.FormattingEnabled = true;
            this.safeTeacherBox.Location = new System.Drawing.Point(714, 202);
            this.safeTeacherBox.Name = "safeTeacherBox";
            this.safeTeacherBox.Size = new System.Drawing.Size(543, 30);
            this.safeTeacherBox.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.deleteButton.Location = new System.Drawing.Point(819, 259);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(216, 30);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.addButton.Location = new System.Drawing.Point(1041, 259);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(216, 30);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Создать";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.updateButton.Location = new System.Drawing.Point(1041, 259);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(216, 30);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // stageTeacherLabel
            // 
            this.stageTeacherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stageTeacherLabel.AutoSize = true;
            this.stageTeacherLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stageTeacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.stageTeacherLabel.Location = new System.Drawing.Point(33, 599);
            this.stageTeacherLabel.Name = "stageTeacherLabel";
            this.stageTeacherLabel.Size = new System.Drawing.Size(126, 20);
            this.stageTeacherLabel.TabIndex = 8;
            this.stageTeacherLabel.Text = "Преподаватель";
            // 
            // stageTeacherBox
            // 
            this.stageTeacherBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stageTeacherBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stageTeacherBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stageTeacherBox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stageTeacherBox.FormattingEnabled = true;
            this.stageTeacherBox.Location = new System.Drawing.Point(37, 622);
            this.stageTeacherBox.Name = "stageTeacherBox";
            this.stageTeacherBox.Size = new System.Drawing.Size(543, 30);
            this.stageTeacherBox.TabIndex = 9;
            // 
            // stageDateStartedPicker
            // 
            this.stageDateStartedPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stageDateStartedPicker.CustomFormat = "dd.MM.yyyy";
            this.stageDateStartedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stageDateStartedPicker.Location = new System.Drawing.Point(609, 624);
            this.stageDateStartedPicker.Name = "stageDateStartedPicker";
            this.stageDateStartedPicker.Size = new System.Drawing.Size(172, 27);
            this.stageDateStartedPicker.TabIndex = 10;
            this.stageDateStartedPicker.Value = new System.DateTime(2021, 12, 9, 0, 0, 0, 0);
            // 
            // stageDateEndedPicker
            // 
            this.stageDateEndedPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stageDateEndedPicker.CustomFormat = "dd.MM.yyyy";
            this.stageDateEndedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stageDateEndedPicker.Location = new System.Drawing.Point(810, 624);
            this.stageDateEndedPicker.Name = "stageDateEndedPicker";
            this.stageDateEndedPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stageDateEndedPicker.Size = new System.Drawing.Size(172, 27);
            this.stageDateEndedPicker.TabIndex = 11;
            this.stageDateEndedPicker.Value = new System.DateTime(2021, 12, 9, 0, 0, 0, 0);
            // 
            // stageDateStartedLabel
            // 
            this.stageDateStartedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stageDateStartedLabel.AutoSize = true;
            this.stageDateStartedLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stageDateStartedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.stageDateStartedLabel.Location = new System.Drawing.Point(605, 597);
            this.stageDateStartedLabel.Name = "stageDateStartedLabel";
            this.stageDateStartedLabel.Size = new System.Drawing.Size(99, 20);
            this.stageDateStartedLabel.TabIndex = 8;
            this.stageDateStartedLabel.Text = "Дата начала";
            // 
            // stageDateEndedLabel
            // 
            this.stageDateEndedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stageDateEndedLabel.AutoSize = true;
            this.stageDateEndedLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stageDateEndedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.stageDateEndedLabel.Location = new System.Drawing.Point(806, 597);
            this.stageDateEndedLabel.Name = "stageDateEndedLabel";
            this.stageDateEndedLabel.Size = new System.Drawing.Size(130, 20);
            this.stageDateEndedLabel.TabIndex = 8;
            this.stageDateEndedLabel.Text = "Дата окончания";
            // 
            // stageEditButton
            // 
            this.stageEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stageEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.stageEditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.stageEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stageEditButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stageEditButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.stageEditButton.Location = new System.Drawing.Point(1041, 624);
            this.stageEditButton.Name = "stageEditButton";
            this.stageEditButton.Size = new System.Drawing.Size(216, 30);
            this.stageEditButton.TabIndex = 12;
            this.stageEditButton.Text = "Изменить";
            this.stageEditButton.UseVisualStyleBackColor = false;
            this.stageEditButton.Click += new System.EventHandler(this.stageEditButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(37, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 3);
            this.panel1.TabIndex = 13;
            // 
            // TeacherGroupsThemesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stageEditButton);
            this.Controls.Add(this.stageDateEndedPicker);
            this.Controls.Add(this.stageDateStartedPicker);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.stageTeacherBox);
            this.Controls.Add(this.safeTeacherBox);
            this.Controls.Add(this.econTeacherBox);
            this.Controls.Add(this.mainTeacherBox);
            this.Controls.Add(this.stageDateEndedLabel);
            this.Controls.Add(this.stageDateStartedLabel);
            this.Controls.Add(this.stageTeacherLabel);
            this.Controls.Add(this.safeTeacherLabel);
            this.Controls.Add(this.econTeacherLabel);
            this.Controls.Add(this.mainTeacherLabel);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.themeBox);
            this.Controls.Add(this.stagesGrid);
            this.Controls.Add(this.studentLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TeacherGroupsThemesControl";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.stagesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView stagesGrid;
        private System.Windows.Forms.Label studentLabel;
        private Bunifu.Framework.UI.BunifuElipse TeacherGroupsControlEllipse;
        private System.Windows.Forms.TextBox themeBox;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.Label mainTeacherLabel;
        private System.Windows.Forms.Label econTeacherLabel;
        private System.Windows.Forms.Label safeTeacherLabel;
        private System.Windows.Forms.ComboBox mainTeacherBox;
        private System.Windows.Forms.ComboBox econTeacherBox;
        private System.Windows.Forms.ComboBox safeTeacherBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn stage_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stage_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ended;
        private System.Windows.Forms.Label stageTeacherLabel;
        private System.Windows.Forms.ComboBox stageTeacherBox;
        private System.Windows.Forms.DateTimePicker stageDateStartedPicker;
        private System.Windows.Forms.DateTimePicker stageDateEndedPicker;
        private System.Windows.Forms.Label stageDateStartedLabel;
        private System.Windows.Forms.Label stageDateEndedLabel;
        private System.Windows.Forms.Button stageEditButton;
        private System.Windows.Forms.Panel panel1;
    }
}

namespace CourseProject.Forms
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.showPassCheck = new System.Windows.Forms.CheckBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.databaseBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.cancelButton.Location = new System.Drawing.Point(36, 483);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(216, 30);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.connectButton.Location = new System.Drawing.Point(37, 447);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(216, 30);
            this.connectButton.TabIndex = 16;
            this.connectButton.Text = "Подключиться";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // showPassCheck
            // 
            this.showPassCheck.AutoSize = true;
            this.showPassCheck.BackColor = System.Drawing.Color.Transparent;
            this.showPassCheck.Location = new System.Drawing.Point(110, 310);
            this.showPassCheck.Name = "showPassCheck";
            this.showPassCheck.Size = new System.Drawing.Size(144, 22);
            this.showPassCheck.TabIndex = 14;
            this.showPassCheck.Text = "&показать пароль";
            this.showPassCheck.UseVisualStyleBackColor = false;
            this.showPassCheck.CheckedChanged += new System.EventHandler(this.showPassCheck_CheckedChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(38, 274);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(216, 30);
            this.passwordBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(35, 253);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 18);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Пароль";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(35, 199);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(136, 18);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Имя пользователя";
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.mainLabel.Location = new System.Drawing.Point(31, 25);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(222, 37);
            this.mainLabel.TabIndex = 7;
            this.mainLabel.Text = "Подключение";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameBox.Location = new System.Drawing.Point(37, 220);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(216, 30);
            this.usernameBox.TabIndex = 12;
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(35, 91);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(40, 18);
            this.hostLabel.TabIndex = 9;
            this.hostLabel.Text = "Хост";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(35, 145);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(43, 18);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "Порт";
            // 
            // portBox
            // 
            this.portBox.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portBox.Location = new System.Drawing.Point(38, 166);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(216, 30);
            this.portBox.TabIndex = 11;
            // 
            // hostBox
            // 
            this.hostBox.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hostBox.Location = new System.Drawing.Point(37, 112);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(216, 30);
            this.hostBox.TabIndex = 10;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(34, 335);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(98, 18);
            this.databaseLabel.TabIndex = 9;
            this.databaseLabel.Text = "База данных";
            // 
            // databaseBox
            // 
            this.databaseBox.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.databaseBox.Location = new System.Drawing.Point(36, 356);
            this.databaseBox.Name = "databaseBox";
            this.databaseBox.Size = new System.Drawing.Size(216, 30);
            this.databaseBox.TabIndex = 15;
            // 
            // ConnectionForm
            // 
            this.AcceptButton = this.connectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(290, 543);
            this.ControlBox = false;
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.databaseBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.showPassCheck);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.mainLabel);
            this.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.CheckBox showPassCheck;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.TextBox databaseBox;
    }
}
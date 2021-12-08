using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CourseProject.Classes;

namespace CourseProject.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        List<User> users = new List<User>();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            users = DataBaseGet.Users("");

            foreach (User val in users)
            {
                usernameBox.Items.Add(val);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void showPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!showPassCheck.Checked)
                passwordBox.PasswordChar = '*';
            else
                passwordBox.PasswordChar = char.MinValue;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.SelectedIndex < 0)
                MessageBox.Show("Логин либо пароль не верны", "Ошибка авторизации");
            else
            {
                if (DataBaseGet.PasswordIsValid(((User)usernameBox.SelectedItem).user_id, passwordBox.Text))
                {
                    Settings.user = (User)usernameBox.SelectedItem;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Логин либо пароль не верны", "Ошибка авторизации");
                    MessageBox.Show(((User)usernameBox.SelectedItem).id.ToString(), passwordBox.Text);
                }
            } 

        }
    }
}

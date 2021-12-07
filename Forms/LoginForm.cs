using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            users = DataBaseGet.Users();

            foreach (User val in users)
            {
                usernameBox.Items.Add(val.name);
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
                if (DataBaseGet.PasswordIsValid(users[usernameBox.SelectedIndex].id, passwordBox.Text))
                {
                    Settings.user = users[usernameBox.SelectedIndex];
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Логин либо пароль не верны", "Ошибка авторизации");
                }
            } 

        }
    }
}

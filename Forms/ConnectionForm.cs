using System;
using System.Windows.Forms;

using Npgsql;

using CourseProject.Classes;

namespace CourseProject.Forms
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void showPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!showPassCheck.Checked)
                passwordBox.PasswordChar = '*';
            else
                passwordBox.PasswordChar = char.MinValue;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            int port = 0;
            if (!int.TryParse(portBox.Text, out port))
            {
                MessageBox.Show("Порт может содержать только цифры!", "Ошибка подключения");
            }
            else
            {
                NpgsqlConnectionStringBuilder temp = new NpgsqlConnectionStringBuilder();
                temp.Host = hostBox.Text;
                temp.Port = port;
                temp.Username = usernameBox.Text;
                temp.Password = passwordBox.Text;
                temp.Database = databaseBox.Text;

                if (Settings.CheckDatabaseConnection(temp))
                {
                    Settings.conStr = temp;
                    Settings.SaveConStr();
                    MessageBox.Show("Успешно подключено!", "Успешное подключение");
                    this.DialogResult = DialogResult.OK;
                } 
                else
                {
                    MessageBox.Show("Невозможно подключиться к базе данных!\nУбедитесь, что данные введены верно и база данных активна.", "Ошибка подключения");
                } 

            }
        }
    }
}

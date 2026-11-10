using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = !showPassword.Checked;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text;

            if (username == "" || password == "")
            {
                errorLabel.Text = "Please enter username and password.";
            }
            else if (username == "thierry" && password == "thierry")
            {
                Hide();
                MainForm main = new MainForm(username);
                main.FormClosed += (s, args) => Close();
                main.Show();
            }
            else
            {
                errorLabel.Text = "Wrong username or password.";
                passwordBox.Clear();
            }
        }
    }
}

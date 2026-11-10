using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm() : this("User") { }   // lets Visual Studio open this form in the designer

        public MainForm(string username)
        {
            InitializeComponent();
            welcomeLabel.Text = "Welcome, " + username + "!";
        }

        private void MushroomButton_Click(object sender, EventArgs e)
        {
            new MushroomForm().ShowDialog(this);
        }

        private void BicycleButton_Click(object sender, EventArgs e)
        {
            new BicycleForm().ShowDialog(this);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

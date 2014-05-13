using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatClient3AC
{
    public partial class ChatClientForm : Form
    {
        public ChatClientForm()
        {
            InitializeComponent();
        }

        private void emoBox_Click(object sender, EventArgs e)
        {
            EmoticonBox emoticonBox = new EmoticonBox();

            emoticonBox.Deactivate += delegate
            {
                emoticonBox.Close();
            };

            emoticonBox.Location = new Point(sendButton.Location.X, sendButton.Location.Y);
            emoticonBox.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccountForm newAccountForm = new NewAccountForm();
            newAccountForm.ShowDialog();
        }
    }
}

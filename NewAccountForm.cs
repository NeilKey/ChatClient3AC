using System;
using System.Windows.Forms;

namespace ChatClient3AC
{
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();

            UpdateCreateButtonState();
        }

        // Accessors ai tre campi nickname, username e password
        public String Nickname
        {
            get { return nickname.Text; }
        }

        public String Username
        {
            get { return username.Text; }
        }

        public String Password
        {
            get { return password.Text; }
        }

        private void UpdateCreateButtonState()
        {
            // Abilita il button di Create solo se i campi nickname, username e password non sono vuoti
            this.create.Enabled = (this.nicknameText.Text.Length > 0 &&
                this.usernameText.Text.Length > 0 &&
                this.passwordText.Text.Length > 0) ? true : false;
        }

        private void OnNicknameChanged(object sender, EventArgs e)
        {
            // Il campo nickname è stato modificato, aggiorna lo stato del button Create
            UpdateCreateButtonState();
        }

        private void OnNicknameKeyPress(object sender, KeyPressEventArgs e)
        {
            // Filtra i caratteri ':' e ',' (non permessi)
            if (e.KeyChar == ':' || e.KeyChar == ',')
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void OnUsernameChanged(object sender, EventArgs e)
        {
            // Il campo username è stato modificato, aggiorna lo stato del button Create
            UpdateCreateButtonState();
        }

        private void OnUsernameKeyPress(object sender, KeyPressEventArgs e)
        {
            // Filtra i caratteri ':' e ',' (non permessi)
            if (e.KeyChar == ':' || e.KeyChar == ',')
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            // Il campo password è stato modificato, aggiorna lo stato del button Create
            UpdateCreateButtonState();
        }

        private void OnPasswordKeyPress(object sender, KeyPressEventArgs e)
        {
            // Filtra i caratteri ':' e ',' (non permessi)
            if (e.KeyChar == ':' || e.KeyChar == ',')
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void CloseNewAccount(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

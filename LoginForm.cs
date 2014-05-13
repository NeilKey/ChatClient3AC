using System;
using System.Windows.Forms;
using ChatClient3AC.Properties;

namespace ChatClient3AC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Inizializza i checkboxes
            this.usernameCheckbox.Checked = Settings.Default.saveUsername;
            this.passwordCheckbox.Checked = Settings.Default.savePassword;
            this.passwordCheckbox.Enabled = Settings.Default.saveUsername;

            // Inizializza username e password in funzione dei rispettivi checkboxes
            if (Settings.Default.saveUsername)
            {
                this.username.Text = Settings.Default.username;
                if (Settings.Default.savePassword)
                    this.password.Text = Settings.Default.password;
            }

            // Aggiorna lo stato del button Login
            UpdateLoginButtonState();
        }

        private void UpdateLoginButtonState()
        {
            // Abilita il button di Login solo se i campi username e password non sono vuoti
            this.login.Enabled = this.username.Text.Length > 0 && this.password.Text.Length > 0;
        }

        private void OnUsernameChanged(object sender, EventArgs e)
        {
            // Il campo username è stato modificato, aggiorna lo stato del button Login
            UpdateLoginButtonState();
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
            // Il campo password è stato modificato, aggiorna lo stato del button Login
            UpdateLoginButtonState();
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

        private void OnPasswordCheckChanged(object sender, EventArgs e)
        {
            Settings.Default.savePassword = this.passwordCheckbox.Checked;
        }

        private void OnUsernameCheckChanged(object sender, EventArgs e)
        {
            this.passwordCheckbox.Enabled = this.usernameCheckbox.Checked;
            Settings.Default.saveUsername = this.usernameCheckbox.Checked;
        }

        private void OnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnLogin(object sender, EventArgs e)
        {
            // Salva lo username nei Settings se il relativo checkbox è selezionato
            if (this.usernameCheckbox.Checked) Settings.Default.username = this.username.Text;
            else Settings.Default.username = "";

            // Salva la password nei Settings se i due checkboxes sono selezionati
            if (this.usernameCheckbox.Checked && this.passwordCheckbox.Checked) Settings.Default.password = this.password.Text;
            else Settings.Default.password = "";
        }

        // Accessors ai due campi username e password
        public string Username
        {
            get { return this.username.Text; }
        }

        public string Password
        {
            get { return this.password.Text; }
        }
    }
}

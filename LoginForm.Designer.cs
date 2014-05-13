namespace ChatClient3AC
{
    partial class LoginForm
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
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usernameCheckbox = new System.Windows.Forms.CheckBox();
            this.passwordCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(265, 139);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 22);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.OnClose);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Data";
            // 
            // login
            // 
            this.login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.login.Enabled = false;
            this.login.Location = new System.Drawing.Point(177, 139);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(73, 22);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.OnLogin);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(88, 59);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(192, 20);
            this.username.TabIndex = 5;
            this.username.TextChanged += new System.EventHandler(this.OnUsernameChanged);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnUsernameKeyPress);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(86, 102);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(194, 20);
            this.password.TabIndex = 6;
            this.password.TextChanged += new System.EventHandler(this.OnPasswordChanged);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPasswordKeyPress);
            // 
            // usernameCheckbox
            // 
            this.usernameCheckbox.AutoSize = true;
            this.usernameCheckbox.Location = new System.Drawing.Point(286, 61);
            this.usernameCheckbox.Name = "usernameCheckbox";
            this.usernameCheckbox.Size = new System.Drawing.Size(100, 17);
            this.usernameCheckbox.TabIndex = 7;
            this.usernameCheckbox.Text = "Save username";
            this.usernameCheckbox.UseVisualStyleBackColor = true;
            this.usernameCheckbox.CheckedChanged += new System.EventHandler(this.OnUsernameCheckChanged);
            // 
            // passwordCheckbox
            // 
            this.passwordCheckbox.AutoSize = true;
            this.passwordCheckbox.Enabled = false;
            this.passwordCheckbox.Location = new System.Drawing.Point(286, 104);
            this.passwordCheckbox.Name = "passwordCheckbox";
            this.passwordCheckbox.Size = new System.Drawing.Size(99, 17);
            this.passwordCheckbox.TabIndex = 8;
            this.passwordCheckbox.Text = "Save password";
            this.passwordCheckbox.UseVisualStyleBackColor = true;
            this.passwordCheckbox.CheckedChanged += new System.EventHandler(this.OnPasswordCheckChanged);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(457, 174);
            this.Controls.Add(this.passwordCheckbox);
            this.Controls.Add(this.usernameCheckbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox usernameCheckbox;
        private System.Windows.Forms.CheckBox passwordCheckbox;
    }
}
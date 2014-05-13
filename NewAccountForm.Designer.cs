namespace ChatClient3AC
{
    partial class NewAccountForm
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
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.Label();
            this.nicknameText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(43, 157);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(56, 13);
            this.password.TabIndex = 0;
            this.password.Text = "Password:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(43, 106);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(58, 13);
            this.username.TabIndex = 1;
            this.username.Text = "Username:";
            // 
            // nickname
            // 
            this.nickname.AutoSize = true;
            this.nickname.Location = new System.Drawing.Point(43, 60);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(58, 13);
            this.nickname.TabIndex = 2;
            this.nickname.Text = "Nickname:";
            // 
            // nicknameText
            // 
            this.nicknameText.Location = new System.Drawing.Point(105, 60);
            this.nicknameText.Name = "nicknameText";
            this.nicknameText.Size = new System.Drawing.Size(190, 20);
            this.nicknameText.TabIndex = 3;
            this.nicknameText.TextChanged += new System.EventHandler(this.OnNicknameChanged);
            this.nicknameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNicknameKeyPress);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(105, 106);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(190, 20);
            this.usernameText.TabIndex = 4;
            this.usernameText.TextChanged += new System.EventHandler(this.OnUsernameChanged);
            this.usernameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnUsernameKeyPress);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(105, 150);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(190, 20);
            this.passwordText.TabIndex = 5;
            this.passwordText.TextChanged += new System.EventHandler(this.OnPasswordChanged);
            this.passwordText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPasswordKeyPress);
            // 
            // create
            // 
            this.create.Enabled = false;
            this.create.Location = new System.Drawing.Point(147, 204);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(76, 23);
            this.create.TabIndex = 6;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(229, 204);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(76, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.CloseNewAccount);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "New Account Data";
            // 
            // NewAccountForm
            // 
            this.AcceptButton = this.create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(330, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.nicknameText);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewAccountForm";
            this.ShowInTaskbar = false;
            this.Text = "NewAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.TextBox nicknameText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
    }
}
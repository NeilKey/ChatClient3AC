namespace ChatClient3AC
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.gB_Conversation = new System.Windows.Forms.GroupBox();
            this.l_output = new System.Windows.Forms.Label();
            this.l_input = new System.Windows.Forms.Label();
            this.b_Out_Font = new System.Windows.Forms.Button();
            this.b_Out_Color = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.b_In_Font = new System.Windows.Forms.Button();
            this.b_In_Color = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gB_Language = new System.Windows.Forms.GroupBox();
            this.cB_Language = new System.Windows.Forms.ComboBox();
            this.gB_Host = new System.Windows.Forms.GroupBox();
            this.tB_HostPort = new System.Windows.Forms.TextBox();
            this.tB_HostName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gB_Outgoing = new System.Windows.Forms.GroupBox();
            this.l_out_mex = new System.Windows.Forms.Label();
            this.b_Mex_Font = new System.Windows.Forms.Button();
            this.b_Mex_Color = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gB_Background = new System.Windows.Forms.GroupBox();
            this.b_color_outgoing = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.b_color_conv = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.gB_Conversation.SuspendLayout();
            this.gB_Language.SuspendLayout();
            this.gB_Host.SuspendLayout();
            this.gB_Outgoing.SuspendLayout();
            this.gB_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_Conversation
            // 
            this.gB_Conversation.Controls.Add(this.l_output);
            this.gB_Conversation.Controls.Add(this.l_input);
            this.gB_Conversation.Controls.Add(this.b_Out_Font);
            this.gB_Conversation.Controls.Add(this.b_Out_Color);
            this.gB_Conversation.Controls.Add(this.label4);
            this.gB_Conversation.Controls.Add(this.b_In_Font);
            this.gB_Conversation.Controls.Add(this.b_In_Color);
            this.gB_Conversation.Controls.Add(this.label3);
            this.gB_Conversation.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.gB_Conversation, "gB_Conversation");
            this.gB_Conversation.Name = "gB_Conversation";
            this.gB_Conversation.TabStop = false;
            // 
            // l_output
            // 
            this.l_output.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.l_output, "l_output");
            this.l_output.Name = "l_output";
            // 
            // l_input
            // 
            this.l_input.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.l_input, "l_input");
            this.l_input.Name = "l_input";
            // 
            // b_Out_Font
            // 
            resources.ApplyResources(this.b_Out_Font, "b_Out_Font");
            this.b_Out_Font.Name = "b_Out_Font";
            this.b_Out_Font.UseVisualStyleBackColor = true;
            this.b_Out_Font.Click += new System.EventHandler(this.b_Out_Font_Click);
            // 
            // b_Out_Color
            // 
            resources.ApplyResources(this.b_Out_Color, "b_Out_Color");
            this.b_Out_Color.Name = "b_Out_Color";
            this.b_Out_Color.UseVisualStyleBackColor = true;
            this.b_Out_Color.Click += new System.EventHandler(this.b_Out_Color_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // b_In_Font
            // 
            resources.ApplyResources(this.b_In_Font, "b_In_Font");
            this.b_In_Font.Name = "b_In_Font";
            this.b_In_Font.UseVisualStyleBackColor = true;
            this.b_In_Font.Click += new System.EventHandler(this.b_In_Font_Click);
            // 
            // b_In_Color
            // 
            resources.ApplyResources(this.b_In_Color, "b_In_Color");
            this.b_In_Color.Name = "b_In_Color";
            this.b_In_Color.UseVisualStyleBackColor = true;
            this.b_In_Color.Click += new System.EventHandler(this.b_In_Color_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // gB_Language
            // 
            this.gB_Language.Controls.Add(this.cB_Language);
            resources.ApplyResources(this.gB_Language, "gB_Language");
            this.gB_Language.Name = "gB_Language";
            this.gB_Language.TabStop = false;
            // 
            // cB_Language
            // 
            this.cB_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Language.FormattingEnabled = true;
            this.cB_Language.Items.AddRange(new object[] {
            resources.GetString("cB_Language.Items"),
            resources.GetString("cB_Language.Items1")});
            resources.ApplyResources(this.cB_Language, "cB_Language");
            this.cB_Language.Name = "cB_Language";
            this.cB_Language.Sorted = true;
            this.cB_Language.SelectedIndexChanged += new System.EventHandler(this.cB_Language_SelectedIndexChanged);
            // 
            // gB_Host
            // 
            this.gB_Host.Controls.Add(this.tB_HostPort);
            this.gB_Host.Controls.Add(this.tB_HostName);
            this.gB_Host.Controls.Add(this.label2);
            this.gB_Host.Controls.Add(this.label1);
            resources.ApplyResources(this.gB_Host, "gB_Host");
            this.gB_Host.Name = "gB_Host";
            this.gB_Host.TabStop = false;
            // 
            // tB_HostPort
            // 
            resources.ApplyResources(this.tB_HostPort, "tB_HostPort");
            this.tB_HostPort.Name = "tB_HostPort";
            // 
            // tB_HostName
            // 
            resources.ApplyResources(this.tB_HostName, "tB_HostName");
            this.tB_HostName.Name = "tB_HostName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gB_Outgoing
            // 
            this.gB_Outgoing.Controls.Add(this.l_out_mex);
            this.gB_Outgoing.Controls.Add(this.b_Mex_Font);
            this.gB_Outgoing.Controls.Add(this.b_Mex_Color);
            this.gB_Outgoing.Controls.Add(this.label5);
            resources.ApplyResources(this.gB_Outgoing, "gB_Outgoing");
            this.gB_Outgoing.Name = "gB_Outgoing";
            this.gB_Outgoing.TabStop = false;
            // 
            // l_out_mex
            // 
            this.l_out_mex.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.l_out_mex, "l_out_mex");
            this.l_out_mex.Name = "l_out_mex";
            // 
            // b_Mex_Font
            // 
            resources.ApplyResources(this.b_Mex_Font, "b_Mex_Font");
            this.b_Mex_Font.Name = "b_Mex_Font";
            this.b_Mex_Font.UseVisualStyleBackColor = true;
            this.b_Mex_Font.Click += new System.EventHandler(this.b_Mex_Font_Click);
            // 
            // b_Mex_Color
            // 
            resources.ApplyResources(this.b_Mex_Color, "b_Mex_Color");
            this.b_Mex_Color.Name = "b_Mex_Color";
            this.b_Mex_Color.UseVisualStyleBackColor = true;
            this.b_Mex_Color.Click += new System.EventHandler(this.b_Mex_Color_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // gB_Background
            // 
            this.gB_Background.Controls.Add(this.b_color_outgoing);
            this.gB_Background.Controls.Add(this.label8);
            this.gB_Background.Controls.Add(this.b_color_conv);
            this.gB_Background.Controls.Add(this.label9);
            resources.ApplyResources(this.gB_Background, "gB_Background");
            this.gB_Background.Name = "gB_Background";
            this.gB_Background.TabStop = false;
            // 
            // b_color_outgoing
            // 
            resources.ApplyResources(this.b_color_outgoing, "b_color_outgoing");
            this.b_color_outgoing.Name = "b_color_outgoing";
            this.b_color_outgoing.UseVisualStyleBackColor = true;
            this.b_color_outgoing.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // b_color_conv
            // 
            resources.ApplyResources(this.b_color_conv, "b_color_conv");
            this.b_color_conv.Name = "b_color_conv";
            this.b_color_conv.UseVisualStyleBackColor = true;
            this.b_color_conv.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // b_Save
            // 
            resources.ApplyResources(this.b_Save, "b_Save");
            this.b_Save.Name = "b_Save";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Cancel
            // 
            resources.ApplyResources(this.b_Cancel, "b_Cancel");
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.gB_Background);
            this.Controls.Add(this.gB_Outgoing);
            this.Controls.Add(this.gB_Host);
            this.Controls.Add(this.gB_Language);
            this.Controls.Add(this.gB_Conversation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.gB_Conversation.ResumeLayout(false);
            this.gB_Conversation.PerformLayout();
            this.gB_Language.ResumeLayout(false);
            this.gB_Host.ResumeLayout(false);
            this.gB_Host.PerformLayout();
            this.gB_Outgoing.ResumeLayout(false);
            this.gB_Outgoing.PerformLayout();
            this.gB_Background.ResumeLayout(false);
            this.gB_Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_Conversation;
        private System.Windows.Forms.GroupBox gB_Language;
        private System.Windows.Forms.ComboBox cB_Language;
        private System.Windows.Forms.GroupBox gB_Host;
        private System.Windows.Forms.TextBox tB_HostPort;
        private System.Windows.Forms.TextBox tB_HostName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Out_Font;
        private System.Windows.Forms.Button b_Out_Color;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_In_Font;
        private System.Windows.Forms.Button b_In_Color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gB_Outgoing;
        private System.Windows.Forms.Button b_Mex_Font;
        private System.Windows.Forms.Button b_Mex_Color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gB_Background;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.Label l_output;
        private System.Windows.Forms.Label l_input;
        private System.Windows.Forms.Label l_out_mex;
        private System.Windows.Forms.Button b_color_outgoing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button b_color_conv;
        private System.Windows.Forms.Label label9;
    }
}
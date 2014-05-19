using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ChatClient3AC
{
    public partial class SettingsForm : Form
    {
        private String hostName;
        private int hostPort;
        private String culture = "it";
        private String culture_temp = "it";

        private System.Drawing.Color inColor;
        private System.Drawing.Color outColor;
        private System.Drawing.Color mexColor;

        private System.Drawing.Color inFontColor;
        private System.Drawing.Color outFontColor;
        private System.Drawing.Color mexFontColor;

        private System.Drawing.Font inFont;
        private System.Drawing.Font outFont;
        private System.Drawing.Font mexFont;

        public SettingsForm()
        {
            InitializeComponent();
            cB_Language.SelectedIndex = Properties.Settings.Default.languageIndex;

            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(SettingsForm));
                resources.ApplyResources(c, c.Name, new CultureInfo(Properties.Settings.Default.language));
            }

            culture = Properties.Settings.Default.language;
            tB_HostName.Text = Properties.Settings.Default.hostName;
            tB_HostPort.Text = ""+Properties.Settings.Default.hostPort;

            inColor = Properties.Settings.Default.colorInput;
            outColor = Properties.Settings.Default.colorOutput;
            mexColor = Properties.Settings.Default.colorMex;

            l_input.BackColor = Properties.Settings.Default.colorInput;
            l_output.BackColor = Properties.Settings.Default.colorOutput;
            l_out_mex.BackColor = Properties.Settings.Default.colorMex;

            inFontColor = Properties.Settings.Default.fontColorIn;
            outFontColor = Properties.Settings.Default.fontColorOut;
            mexFontColor = Properties.Settings.Default.fontColorMex;

            l_input.ForeColor = Properties.Settings.Default.fontColorIn;
            l_output.ForeColor = Properties.Settings.Default.fontColorOut;
            l_out_mex.ForeColor = Properties.Settings.Default.fontColorMex;

            inFont = Properties.Settings.Default.fontIn;
            outFont = Properties.Settings.Default.fontOut;
            mexFont = Properties.Settings.Default.fontMex;

            l_input.Font = Properties.Settings.Default.fontIn;
            l_output.Font = Properties.Settings.Default.fontOut;
            l_out_mex.Font = Properties.Settings.Default.fontMex;
        }

        private void b_In_Color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            MyDialog.FullOpen = true;
            MyDialog.Color = l_input.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_input.ForeColor = MyDialog.Color;
                Properties.Settings.Default.fontColorIn = MyDialog.Color;
            }
        }

        private void b_Out_Color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            MyDialog.FullOpen = true;
            MyDialog.Color = l_output.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_output.ForeColor = MyDialog.Color;
                Properties.Settings.Default.fontColorOut = MyDialog.Color;
            }
        }

        private void b_Mex_Color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            MyDialog.FullOpen = true;
            MyDialog.Color = l_out_mex.ForeColor;  

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_out_mex.ForeColor = MyDialog.Color;
                Properties.Settings.Default.fontColorMex = MyDialog.Color;
            }
        }

        private void b_In_Font_Click(object sender, EventArgs e)
        {
            FontDialog MyDialog = new FontDialog();

            MyDialog.ShowColor = false;

            MyDialog.Font = l_input.Font;
            MyDialog.Color = l_input.ForeColor;

            if (MyDialog.ShowDialog() != DialogResult.Cancel)
            {
                l_input.Font = MyDialog.Font;
                Properties.Settings.Default.fontIn = MyDialog.Font;
                l_input.ForeColor = MyDialog.Color;
            }
        }

        private void b_Out_Font_Click(object sender, EventArgs e)
        {
            FontDialog MyDialog = new FontDialog();

            MyDialog.ShowColor = false;

            MyDialog.Font = l_output.Font;
            MyDialog.Color = l_output.ForeColor;

            if (MyDialog.ShowDialog() != DialogResult.Cancel)
            {
                l_output.Font = MyDialog.Font;
                Properties.Settings.Default.fontOut = MyDialog.Font;
                l_output.ForeColor = MyDialog.Color;
            }
        }

        private void b_Mex_Font_Click(object sender, EventArgs e)
        {
            FontDialog MyDialog = new FontDialog();

            MyDialog.ShowColor = false;

            MyDialog.Font = l_out_mex.Font;
            MyDialog.Color = l_out_mex.ForeColor;

            if (MyDialog.ShowDialog() != DialogResult.Cancel)
            {
                l_out_mex.Font = MyDialog.Font;
                Properties.Settings.Default.fontMex = MyDialog.Font;
                l_out_mex.ForeColor = MyDialog.Color;
            }
        }

        private void cB_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cB_Language.SelectedItem.ToString() == "English") 
            {
                foreach (Control c in this.Controls)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(SettingsForm));
                    resources.ApplyResources(c, c.Name, new CultureInfo("en"));
                    Properties.Settings.Default.language = CultureInfo.CurrentCulture.Name;
                    Properties.Settings.Default.languageIndex = 0;
                }
                culture_temp = CultureInfo.CurrentCulture.Name;
            }
            else if (cB_Language.SelectedItem.ToString() == "Italiano")
            {
                foreach (Control c in this.Controls)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(SettingsForm));
                    resources.ApplyResources(c, c.Name, new CultureInfo("it"));
                    Properties.Settings.Default.language = CultureInfo.CurrentCulture.Name;
                    Properties.Settings.Default.languageIndex = 0;
                }
                culture_temp = CultureInfo.CurrentCulture.Name;
            }
        }

        private void bgConv_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            MyDialog.FullOpen = true;
            MyDialog.Color = l_input.BackColor;
            MyDialog.Color = l_output.BackColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_input.BackColor = MyDialog.Color;
                Properties.Settings.Default.colorInput = MyDialog.Color;
                l_output.BackColor = MyDialog.Color;
                Properties.Settings.Default.colorOutput = MyDialog.Color;
            }
            MyDialog.Reset();
        }

        private void bgOut_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            MyDialog.FullOpen = true;
            MyDialog.Color = l_out_mex.BackColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_out_mex.BackColor = MyDialog.Color;
                Properties.Settings.Default.colorMex = MyDialog.Color;
            }
            MyDialog.Reset();
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(ChatClientForm));
                resources.ApplyResources(c, c.Name, new CultureInfo(culture_temp));
            }

            hostName = tB_HostName.Text;
            Properties.Settings.Default.hostName = hostName;

            try
            {
                hostPort = int.Parse(tB_HostPort.Text);
                Properties.Settings.Default.hostPort = hostPort;
            }
            catch (Exception) { }

            Close();
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(SettingsForm));
                resources.ApplyResources(c, c.Name, new CultureInfo(culture));
            }

            Properties.Settings.Default.colorMex = mexColor;
            Properties.Settings.Default.colorInput = inColor;
            Properties.Settings.Default.colorOutput = outColor;

            Properties.Settings.Default.fontColorMex = mexFontColor;
            Properties.Settings.Default.fontColorIn = inFontColor;
            Properties.Settings.Default.fontColorOut = outFontColor;

            Properties.Settings.Default.fontMex = mexFont;
            Properties.Settings.Default.fontIn = inFont;
            Properties.Settings.Default.fontOut = outFont;

            Close();
        }

    }
}

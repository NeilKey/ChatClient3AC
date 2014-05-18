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
        private String culture = "";
        private String culture_temp = "";

        public SettingsForm()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture.Name;
            cB_Language.SelectedIndex = 0;
        }


        private void b_Cancel_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(SettingsForm));
                resources.ApplyResources(c, c.Name, new CultureInfo(culture));
            }
            Close();
        }

        private void b_BG_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.FullOpen = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = l_input.BackColor;
            MyDialog.Color = l_output.BackColor;
            // Update the text box color if the user clicks OK  
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_input.BackColor = MyDialog.Color;
                l_output.BackColor = MyDialog.Color;
            }
            MyDialog.Reset();
        }

        private void b_In_Color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.FullOpen = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = l_input.ForeColor;
            // Update the text box color if the user clicks OK  
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_input.ForeColor = MyDialog.Color;
            }
        }

        private void b_Out_Color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.FullOpen = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = l_output.ForeColor;
            // Update the text box color if the user clicks OK  
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_output.ForeColor = MyDialog.Color;
            }
        }

        private void b_Mex_Color_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.FullOpen = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = l_out_mex.ForeColor;
            // Update the text box color if the user clicks OK  
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_out_mex.ForeColor = MyDialog.Color;
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
                l_out_mex.ForeColor = MyDialog.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.FullOpen = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = l_out_mex.BackColor;
            // Update the text box color if the user clicks OK  
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_out_mex.BackColor = MyDialog.Color;
            }
            MyDialog.Reset();
        }

        private void cB_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cB_Language.SelectedItem.ToString() == "English") 
            {
                foreach (Control c in this.Controls)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(SettingsForm));
                    resources.ApplyResources(c, c.Name, new CultureInfo("en"));
                }
                culture_temp = CultureInfo.CurrentCulture.Name;
            }
            else if (cB_Language.SelectedItem.ToString() == "Italiano")
            {
                foreach (Control c in this.Controls)
                {
                    ComponentResourceManager resources = new ComponentResourceManager(typeof(SettingsForm));
                    resources.ApplyResources(c, c.Name, new CultureInfo("it"));
                }
                culture_temp = CultureInfo.CurrentCulture.Name;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.FullOpen = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = l_input.BackColor;
            MyDialog.Color = l_output.BackColor;
            // Update the text box color if the user clicks OK  
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_input.BackColor = MyDialog.Color;
                l_output.BackColor = MyDialog.Color;
            }
            MyDialog.Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.FullOpen = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = l_out_mex.BackColor;
            // Update the text box color if the user clicks OK  
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                l_out_mex.BackColor = MyDialog.Color;
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
            try
            {
                hostPort = int.Parse(tB_HostPort.Text);
            }
            catch (Exception) { }

            Close();
        }

        protected String getHostName()
        {
            return hostName;
        }

        protected int getHostPort()
        {
            return hostPort;
        }
    }
}

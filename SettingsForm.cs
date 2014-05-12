using System;
using System.Windows.Forms;

namespace ChatClient3AC
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void tB_Out_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB_In_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB_Mex_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
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

        private void gB_Language_Enter(object sender, EventArgs e)
        {

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

        }

        private void label9_Click(object sender, EventArgs e)
        {

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
    }
}

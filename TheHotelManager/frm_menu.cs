using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheHotelManager
{
    public partial class frm_menu : Form
    {


        public frm_menu()
        {
            InitializeComponent();
        }

        //Save it as RTF
        private void btn_save_Click(object sender, EventArgs e)
        {
            SQLInteraction.InsertIntoMenu("menu", rtb_menuEditor.Rtf);
            rtb_menuEditor.Text = "";

        }

        private void btn_bold_Click(object sender, EventArgs e)
        {
            if (rtb_menuEditor.SelectionFont != null)
            {
                FontStyle style = rtb_menuEditor.SelectionFont.Style;
                if (rtb_menuEditor.SelectionFont.Bold)
                {
                    style &= FontStyle.Bold;
                }
                else
                {
                    style |= FontStyle.Bold;
                }
                rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.SelectionFont, style);

            }


        }

        private void btn_italic_Click(object sender, EventArgs e)
        {
            if (rtb_menuEditor.SelectionFont != null)
            {
                FontStyle style = rtb_menuEditor.SelectionFont.Style;
                if (rtb_menuEditor.SelectionFont.Italic)
                {
                    style &= FontStyle.Italic;
                }
                else
                {
                    style |= FontStyle.Italic;
                }
                rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.SelectionFont, style);

            }
        }

        private void btn_underline_Click(object sender, EventArgs e)
        {
            if (rtb_menuEditor.SelectionFont != null)
            {
                FontStyle style = rtb_menuEditor.SelectionFont.Style;
                if (rtb_menuEditor.SelectionFont.Underline)
                {
                    style &= FontStyle.Underline;
                }
                else
                {
                    style |= FontStyle.Underline;
                }
                rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.SelectionFont, style);

            }
        }

        private void btn_backR_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_restaurant menuRestaurant = new frm_restaurant();
            menuRestaurant.ShowDialog();
            this.Close();
        }

        //Change FontSize
        private void cb_fontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size;
            if (float.TryParse(cb_fontSize.Text, out size))
            {
                rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.SelectionFont.FontFamily, size, rtb_menuEditor.SelectionFont.Style);
            }
        }

        //Delete everything
        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete everything?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                rtb_menuEditor.Text = "";
            }

        }

        //Allign Text to the center
        private void btn_center_Click(object sender, EventArgs e)
        {
            if (rtb_menuEditor.SelectionAlignment != HorizontalAlignment.Center)
            {
                rtb_menuEditor.SelectionAlignment = HorizontalAlignment.Center;
                btn_center.Text = "Left";
            }
            else if (rtb_menuEditor.SelectionAlignment == HorizontalAlignment.Center)
            {
                rtb_menuEditor.SelectionAlignment = HorizontalAlignment.Left;
                btn_center.Text = "Center";
            }
        }

        //Allign Text to the right
        private void btn_right_Click(object sender, EventArgs e)
        {
            if (rtb_menuEditor.SelectionAlignment != HorizontalAlignment.Right)
            {
                rtb_menuEditor.SelectionAlignment = HorizontalAlignment.Right;
                btn_right.Text = "Left";
            }
            else if (rtb_menuEditor.SelectionAlignment == HorizontalAlignment.Right)
            {
                rtb_menuEditor.SelectionAlignment = HorizontalAlignment.Left;
                btn_right.Text = "Right";
            }
        }
    }
}

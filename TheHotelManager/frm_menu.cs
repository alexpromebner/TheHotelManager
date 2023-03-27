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

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_bold_Click(object sender, EventArgs e)
        {
            if(rtb_menuEditor.SelectionFont.Style != FontStyle.Bold)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Bold);
            }
            else if(rtb_menuEditor.SelectionFont.Style == FontStyle.Bold)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            
        }

        private void btn_italic_Click(object sender, EventArgs e)
        {
            if (rtb_menuEditor.SelectionFont.Style != FontStyle.Italic)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Italic);
            }
            else
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
        }
        private void btn_underline_Click(object sender, EventArgs e)
        {
            if (rtb_menuEditor.SelectionFont.Style != FontStyle.Underline)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Underline);
            }
            else
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
        }

        private void btn_backR_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main menuRestaurant = new frm_main();
            menuRestaurant.ShowDialog();
            this.Close();
        }

        private void cb_fontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_fontSize.SelectedIndex == 0)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex + 1);
            }
            else if (cb_fontSize.SelectedIndex == 1)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 2)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 3)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 4)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 5)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 6)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 7)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 8)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 9)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 10)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 11)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 12)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 13)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 14)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 15)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 16)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 17)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 18)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 19)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex, FontStyle.Regular);
            }
            else if (cb_fontSize.SelectedIndex == 20)
            {
                rtb_menuEditor.SelectionFont = new Font("Arial", cb_fontSize.SelectedIndex);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete everything?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialog == DialogResult.Yes)
            {
                rtb_menuEditor.Text = "";
            }
            
        }

        private void rtb_menuEditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_center_Click(object sender, EventArgs e)
        {
            if(rtb_menuEditor.SelectionAlignment != HorizontalAlignment.Center)
            {
                rtb_menuEditor.SelectionAlignment = HorizontalAlignment.Center;
                btn_center.Text = "Left";
            }
            else if(rtb_menuEditor.SelectionAlignment == HorizontalAlignment.Center)
            {
                rtb_menuEditor.SelectionAlignment = HorizontalAlignment.Left;
                btn_center.Text = "Center";
            }
        }

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

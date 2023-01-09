using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheHotelManager
{
    public partial class frm_menu : Form
    {
        private bool isBold = false;
        private bool isItalic = false;
        private bool isUnderlined = false;

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
            if (isBold == false)
            {
                Bold();
            }
            else if (isBold == true)
            {
                ResetBold();
            }
        }

        private void btn_italic_Click(object sender, EventArgs e)
        {
            if (isItalic == true)
            {
                Italic();
            }
            else if (isItalic == false)
            {
                ResetItalic();
            }
        }
        private void btn_underline_Click(object sender, EventArgs e)
        {
            if (isUnderlined == true)
            {
                Underline();
            }
            else if (isUnderlined == false)
            {
                ResetUnderline();
            }
            
        }

        public void Bold()
        {
            rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.Font, FontStyle.Bold);
            btn_bold.BackColor = Color.Blue;
            btn_bold.ForeColor = Color.White;
            isBold = true;
        }
        public void BoldItalic()
        {
            rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.Font, FontStyle.Bold & FontStyle.Italic);
            btn_bold.BackColor = Color.Blue;
            btn_bold.ForeColor = Color.White;
            isBold = true;
        }
        public void ResetBold()
        {
            rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.Font, FontStyle.Regular);
            btn_bold.BackColor = Color.White;
            btn_bold.ForeColor = Color.Black;
            isBold = false;
        }

        public void Italic()
        {
            rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.Font, FontStyle.Italic);
            btn_italic.BackColor = Color.Blue;
            btn_italic.ForeColor = Color.White;
            isItalic = true;
        }

        public void ResetItalic()
        {
            rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.Font, FontStyle.Regular);
            btn_italic.BackColor = Color.White;
            btn_italic.ForeColor = Color.Black;
            isItalic = false;
        }
        public void Underline()
        {
            rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.Font, FontStyle.Underline);
            btn_underline.BackColor = Color.Blue;
            btn_underline.ForeColor = Color.White;
            isUnderlined = true;
        }

        public void ResetUnderline()
        {
            rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.Font, FontStyle.Regular);
            btn_underline.BackColor = Color.White;
            btn_underline.ForeColor = Color.Black;
            isUnderlined = false;
        } 

        private void btn_backR_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main menuRestaurant = new frm_main();
            menuRestaurant.ShowDialog();
            this.Close();
        }
    }
}

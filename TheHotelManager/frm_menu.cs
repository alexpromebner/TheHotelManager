using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHotelManager
{
    public partial class frm_menu : Form
    {
        private bool isBold = false;
        private bool isItalic = false;

        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_bold_Click(object sender, EventArgs e)
        {
            if (!isBold)
            {
                Bold();
            }
            else
            {
                ResetBold();
            }
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_italic_Click(object sender, EventArgs e)
        {
            if (!isItalic)
            {
                Italic();
            }
            else
            {
                ResetItalic();
            }
        }

        public void Bold()
        {
            rtb_menuEditor.SelectionFont = new Font(rtb_menuEditor.Font, FontStyle.Bold);
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
    }
}

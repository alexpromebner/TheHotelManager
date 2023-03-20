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
           
        }

        private void btn_italic_Click(object sender, EventArgs e)
        {
           
        }
        private void btn_underline_Click(object sender, EventArgs e)
        {
           
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

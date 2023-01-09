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
    public partial class frm_contactAdmin : Form
    {
        public frm_contactAdmin()
        {
            InitializeComponent();
        }

        private void btn_backA_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main contactAdminMain = new frm_main();
            contactAdminMain.ShowDialog();
            this.Close();
        }

        private void cb_problems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_problems.Text == "Other")
            {
                txt_other.Enabled = true;
            }
            else if (cb_problems.Text != "Other")
            {
                txt_other.Enabled = false;
            }
        }
    }
}

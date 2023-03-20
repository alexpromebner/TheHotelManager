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
    public partial class frm_warehouse : Form
    {
        public frm_warehouse()
        {
            InitializeComponent();
        }

        private void btn_backWh_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_hotel warehouseHotel = new frm_hotel();
            warehouseHotel.ShowDialog();
            this.Close();
        }

        private void frm_warehouse_Load(object sender, EventArgs e)
        {

        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            //add code for adding order on the database (method)
        }

        private void edit_cancelOrder_Click(object sender, EventArgs e)
        {
            //open the contact admin form and automatically choose cancellation
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            lbl_info.Text = "If you want to order other \n products please contact an admin";
            lbl_info.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lbl_info.Visible = false;
        }

        private void lbl_otherProducts_Click(object sender, EventArgs e)
        {
            frm_contactAdmin orderProducts = new frm_contactAdmin();
            orderProducts.cb_problems.Text = "Cancellation";
            orderProducts.btn_backWarehouse.Enabled = true;
            this.Hide();
            orderProducts.ShowDialog();
            this.Close();
        }
    }
}

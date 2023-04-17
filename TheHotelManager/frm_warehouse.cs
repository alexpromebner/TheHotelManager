using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

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

        public static MySqlConnection con = new MySqlConnection();
        MySqlDataAdapter adap;
        DataTable dtset;
        BindingSource bsource = new BindingSource();

        void GetWarehouseData()
        {

            con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
            con.Open();
            adap = new MySqlDataAdapter("Select * From warehouse;", con);
            //adap.SelectCommand = cmd;
            dtset = new DataTable();
            adap.Fill(dtset);

            bsource.DataSource = dtset;
            dgv_warehouse.DataSource = bsource;
            adap.Update(dtset);
            con.Close();
        }

        private void frm_warehouse_Load(object sender, EventArgs e)
        {
            GetWarehouseData();
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            //fix department
            frm_login frm_Login = new frm_login();
            SQLInteraction sQLInteraction = new SQLInteraction();
            sQLInteraction.InsertIntoWarehouse(frm_Login.departmentGiver, cb_product.Text, Convert.ToInt32(nud_quantity.Value), txt_notes.Text);
            MessageBox.Show("The order was completed successfully!");
        }

        private void edit_cancelOrder_Click(object sender, EventArgs e)
        {
            //open the contact admin form and automatically choose cancellation + automatically show product ID in the notes field
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
            orderProducts.cb_problems.Text = "Other";
            orderProducts.btn_backWarehouse.Enabled = true;
            orderProducts.btn_backWarehouse.Visible = true;
            this.Hide();
            orderProducts.ShowDialog();
            this.Close();
        }
    }
}

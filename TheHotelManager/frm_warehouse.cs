using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TheHotelManager
{
    public partial class frm_warehouse : Form
    {
        public int id = 0;
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
            GetWarehouseData();
            SQLInteraction sQLInteraction = new SQLInteraction();

            if (cb_product.Text != "")
            {
                sQLInteraction.InsertIntoWarehouse(frm_login.department, cb_product.Text, Convert.ToInt32(nud_quantity.Value), txt_notes.Text);
                MessageBox.Show("The order was completed successfully!");
            }
            else
            {
                MessageBox.Show("Please select a product to continue.", "No product selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void edit_cancelOrder_Click(object sender, EventArgs e)
        {
            frm_contactAdmin orderProducts = new frm_contactAdmin();
            orderProducts.cb_problems.Text = "Cancellation";
            orderProducts.btn_backWarehouse.Enabled = true;
            orderProducts.btn_backWarehouse.Visible = true;
            orderProducts.txt_other.Text = "Product ID: " + id.ToString();
            this.Hide();
            orderProducts.ShowDialog();
            this.Close();
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
        private void ClearData()
        {
            txt_notes.Text = "";
            cb_product.Text = "";
            nud_quantity.Value = 1;
            id = 0;
        }

        private void btn_delivered_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to mark this as completed? This action cannot be reverted.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (id != 0)
                    {
                        con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                        MySqlCommand cmd = new MySqlCommand("delete from warehouse where id=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Deleted Successfully!");
                        GetWarehouseData();
                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Record to Delete");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dgv_warehouse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgv_warehouse.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}

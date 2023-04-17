using System;
using System.Windows.Forms;

namespace TheHotelManager
{
    public partial class frm_restaurant : Form
    {
        public frm_restaurant()
        {
            InitializeComponent();
        }

        private void btn_tables_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_tables tables = new frm_tables();
            tables.ShowDialog();
            this.Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_menu menu = new frm_menu();
            menu.ShowDialog();
            this.Close();
        }

        private void btn_backR_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main main = new frm_main();
            main.ShowDialog();
            this.Close();
        }

        private void btn_warehouseR_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_warehouse warehouse = new frm_warehouse();
            warehouse.ShowDialog();
            this.Close();
        }
    }
}

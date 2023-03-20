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
    }
}

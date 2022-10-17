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
    public partial class frm_hotel : Form
    {
        public frm_hotel()
        {
            InitializeComponent();
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_rooms rooms = new frm_rooms();
            rooms.ShowDialog();
            this.Close();
        }

        private void btn_warehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_warehouse warehouse = new frm_warehouse();
            warehouse.ShowDialog();
            this.Close();
        }
    }
}

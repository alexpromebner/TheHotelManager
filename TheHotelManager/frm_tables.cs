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
    public partial class frm_tables : Form
    {
        public frm_tables()
        {
            InitializeComponent();
        }

        private void btn_backRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_restaurant tablesRestaurant = new frm_restaurant();
            tablesRestaurant.ShowDialog();
            this.Close();
        }
    }
}

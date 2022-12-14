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
    }
}

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

        private void nud_tNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_tables_Load(object sender, EventArgs e)
        {

        }

        private void btn_addR_Click(object sender, EventArgs e)
        {
            SQLInteraction.InsertIntoTables("tables",txt_Tname.Text,txt_Tsurname.Text,Convert.ToInt32(nud_tNumber.Value),Convert.ToInt32(nud_amount.Value),dtp_date.Value.ToString(),txt_notes.Text);
        }
    }
}

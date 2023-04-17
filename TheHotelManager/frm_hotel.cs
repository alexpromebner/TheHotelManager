using System;
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

        private void btn_cleaning_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_cleaning cleaning = new frm_cleaning();
            cleaning.ShowDialog();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main hotelMain = new frm_main();
            hotelMain.ShowDialog();
            this.Close();
        }
    }
}

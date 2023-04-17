using System;
using System.Drawing;
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

        private void btn_addR_Click(object sender, EventArgs e)
        {
            SQLInteraction.InsertIntoTables("tables", txt_Tname.Text, txt_Tsurname.Text, Convert.ToInt32(nud_tNumber.Value), Convert.ToInt32(nud_amount.Value), dtp_date.Value.ToString(), txt_notes.Text);
        }

        private void txt_Tname_Click(object sender, EventArgs e)
        {
            txt_Tname.Text = "";
            txt_Tname.ForeColor = Color.Black;
        }

        private void txt_Tsurname_Click(object sender, EventArgs e)
        {
            txt_Tsurname.Text = "";
            txt_Tsurname.ForeColor = Color.Black;
        }

        private void txt_notes_Click(object sender, EventArgs e)
        {
            txt_notes.Text = "";
            txt_notes.ForeColor = Color.Black;
        }

        private void edit_reservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_editReservation frm = new frm_editReservation();
            frm.ShowDialog();
            this.Close();
        }
    }
}

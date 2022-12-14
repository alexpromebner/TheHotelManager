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
    public partial class frm_cleaning : Form
    {
        public frm_cleaning()
        {
            InitializeComponent();
        }
    
        private void btn_cleaned_Click(object sender, EventArgs e)
        {
            //enter room number, get room status from data bank, show room number and status on label
            lbl_room.BackColor = Color.Green;
            //if mit label wenn Daten erfolgreich geändert auf Datenbank
        }

        private void btn_dirty_Click(object sender, EventArgs e)
        {
            lbl_room.BackColor = Color.Red;
            //if mit label wenn Daten erfolgreich geändert auf Datenbank
        }

        private void btn_seach_Click(object sender, EventArgs e)
        {
            lbl_room.Text = "Room: " + txt_addSearch.Text;
        }

        private void txt_addSearch_Click(object sender, EventArgs e)
        {
            txt_addSearch.Text = "";
            txt_addSearch.ForeColor = Color.Black;
        }

        private void btn_backR_Click(object sender, EventArgs e)
        {
                this.Hide();
                frm_hotel cleaningHotel = new frm_hotel();
                cleaningHotel.ShowDialog();
                this.Close();
        }
    }
}

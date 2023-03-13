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
        public bool cD;
        public int roomNumber;
        public frm_cleaning()
        {
            InitializeComponent();
        }
    
        private void btn_cleaned_Click(object sender, EventArgs e)
        {
            lbl_room.BackColor = Color.Green;
            cD = true;
            roomNumber = Convert.ToInt32(txt_addSearch.Text);
            SQLInteraction.UpdateRooms(roomNumber, cD);
        }

        private void btn_dirty_Click(object sender, EventArgs e)
        {
            lbl_room.BackColor = Color.Red;
            cD = false;
            roomNumber = Convert.ToInt32(txt_addSearch.Text);
            SQLInteraction.UpdateRooms(roomNumber, cD);
        }

        private void btn_seach_Click(object sender, EventArgs e)
        {
            roomNumber = Convert.ToInt32(txt_addSearch.Text);
            SQLInteraction.GetRooms(roomNumber, false);
            lbl_room.Text = "Room: " + txt_addSearch.Text;
            SQLInteraction.GetStatus(roomNumber);

            if (SQLInteraction.roomStatus == 0)
            {
                lbl_room.BackColor = Color.Red;
            }
            else if (SQLInteraction.roomStatus == 1)
            {
                lbl_room.BackColor = Color.Green;
            }
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

        private void frm_cleaning_Load(object sender, EventArgs e)
        {

        }
    }
}

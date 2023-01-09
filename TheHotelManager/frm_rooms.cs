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
    public partial class frm_rooms : Form
    {
        public string peopleNumber;
        public string roomType;
        public string name;
        public string surname;
        public string from;
        public string to;

        public frm_rooms()
        {
            InitializeComponent();
        }

        private void txt_name_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_name.ForeColor = Color.Black;
        }

        private void btn_backRooms_Click(object sender, EventArgs e)
        {
            DialogResult saveChanges = MessageBox.Show("Are you sure you want to quit? All unsaved data will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (saveChanges == DialogResult.Yes)
            {
                this.Hide();
                frm_hotel roomsHotel = new frm_hotel();
                roomsHotel.ShowDialog();
                this.Close();
            }
        }

        private void btn_addR_Click(object sender, EventArgs e)
        {
            if(cb_peopleNumber.Text == "" || cb_roomType.Text == "" || txt_name.Text == "" || txt_surname.Text == "" || txt_name.Text == "Name" || txt_surname.Text == "Surname")
            {
                MessageBox.Show("Please fill out the full form to continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult controlDate = new DialogResult();
                controlDate = MessageBox.Show("Is the date from " + dtp_dateFrom.Text + " to " + dtp_dateTo.Text + " correct?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (controlDate.Equals(DialogResult.Yes))
                {
                    peopleNumber = cb_peopleNumber.Text;
                    roomType = cb_roomType.Text;
                    name = txt_name.Text;
                    surname = txt_surname.Text;
                    from = dtp_dateFrom.Text;
                    to = dtp_dateTo.Text;
                    
                    DialogResult addRoom = new DialogResult();
                    addRoom = MessageBox.Show("The room has been successfully reserved. Do you want to add another?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (addRoom.Equals(DialogResult.Yes))
                    {
                        this.Hide();
                        frm_rooms addNewRoom = new frm_rooms();
                        addNewRoom.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        frm_hotel addNoRoom = new frm_hotel();
                        addNoRoom.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void txt_surname_Click(object sender, EventArgs e)
        {
            txt_surname.Text = "";
            txt_surname.ForeColor = Color.Black;
        }

        private void cb_peopleNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            SingleStandard();
            //single bed, double bed, three beds, four beds
        }

        private void cb_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SingleStandard();
            //Standard, Luxury, Kids, Youth
        }

        public void SingleStandard()
        {
            if (cb_peopleNumber.Text.Equals("single bed") && cb_roomType.Text.Equals("Standard"))
            {
                double date = Math.Round(35.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
                string dateToString = date.ToString();
                lbl_price.Text = "Price: " + dateToString + " €";
            }
        }
    }
}

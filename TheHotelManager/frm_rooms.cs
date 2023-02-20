using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

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
        public double price;
        public double priceShort;
       

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
            if(dtp_dateTo.Value < dtp_dateFrom.Value)
            {
                MessageBox.Show("The 'to' date has to be a later date than the 'from' date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult controlDate = new DialogResult();
                controlDate = MessageBox.Show("Is the date from " + dtp_dateFrom.Text + " to " + dtp_dateTo.Text + " correct?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (controlDate.Equals(DialogResult.Yes))
                {
                    //fix price sql con
                    SQLInteraction.InsertIntoReservation("Rooms", cb_peopleNumber.Text, cb_roomType.Text, txt_name.Text, txt_surname.Text, dtp_dateFrom.Value.ToString(), dtp_dateTo.Value.ToString(), priceShort);

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
            if (cb_peopleNumber.Text == "" || cb_roomType.Text == "" || txt_name.Text == "" || txt_surname.Text == "" || txt_name.Text == "Name" || txt_surname.Text == "Surname")
            {
                MessageBox.Show("Please fill out the full form to continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_surname_Click(object sender, EventArgs e)
        {
            txt_surname.Text = "";
            txt_surname.ForeColor = Color.Black;
        }

        private void cb_peopleNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller();
            CheckDate();
            //single bed, double bed, three beds, four beds
        }

        private void cb_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller();
            CheckDate();
            //Standard, Luxury, Youth
        }

        private void dtp_dateFrom_ValueChanged(object sender, EventArgs e)
        {
            Controller();
            CheckDate();
        }

        private void dtp_dateTo_ValueChanged(object sender, EventArgs e)
        {
            Controller();
            CheckDate();
        }

        public void CheckDate()
        {
            if (dtp_dateTo.Value < dtp_dateFrom.Value)
            {
                lbl_price.Text = "Wrong date!";
            }
        }

        public void Controller()
        {
            if (cb_peopleNumber.Text.Equals("single bed") && cb_roomType.Text.Equals("Standard"))
            {
                SingleStandard();
                lbl_pricePerDay.Text = "Price per day: 35.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("double bed") && cb_roomType.Text.Equals("Standard"))
            {
                DoubleStandard();
                lbl_pricePerDay.Text = "Price per day: 69.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("three beds") && cb_roomType.Text.Equals("Standard"))
            {
                ThreeStandard();
                lbl_pricePerDay.Text = "Price per day: 99.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("four beds") && cb_roomType.Text.Equals("Standard"))
            {
                FourStandard();
                lbl_pricePerDay.Text = "Price per day: 134.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("single bed") && cb_roomType.Text.Equals("Luxury"))
            {
                SingleLuxury();
                lbl_pricePerDay.Text = "Price per day: 69.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("double bed") && cb_roomType.Text.Equals("Luxury"))
            {
                DoubleLuxury();
                lbl_pricePerDay.Text = "Price per day: 119.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("three beds") && cb_roomType.Text.Equals("Luxury"))
            {
                ThreeLuxury();
                lbl_pricePerDay.Text = "Price per day: 169.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("four beds") && cb_roomType.Text.Equals("Luxury"))
            {
                FourLuxury();
                lbl_pricePerDay.Text = "Price per day: 249.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("single bed") && cb_roomType.Text.Equals("Youth"))
            {
                SingleYouth();
                lbl_pricePerDay.Text = "Price per day: 19.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("double bed") && cb_roomType.Text.Equals("Youth"))
            {
                DoubleYouth();
                lbl_pricePerDay.Text = "Price per day: 39.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("three beds") && cb_roomType.Text.Equals("Youth"))
            {
                ThreeYouth();
                lbl_pricePerDay.Text = "Price per day: 59.99 €";
            }
            else if (cb_peopleNumber.Text.Equals("four beds") && cb_roomType.Text.Equals("Youth"))
            {
                FourYouth();
                lbl_pricePerDay.Text = "Price per day: 79.99 €";
            }
        }

        public void SingleStandard()
        {
                price = Math.Round(35.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
                string dateToString = price.ToString();
                lbl_price.Text = "Price: " + dateToString + " €";
                priceShort = Math.Round(price, 0);
        }

        public void DoubleStandard()
        {
                price = Math.Round(69.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
                string dateToString = price.ToString();
                lbl_price.Text = "Price: " + dateToString + " €";
                priceShort = Math.Round(price, 0);
        }

        public void ThreeStandard()
        {
                price = Math.Round(99.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
                string dateToString = price.ToString();
                lbl_price.Text = "Price: " + dateToString + " €";
                priceShort = Math.Round(price, 0);
        }
        public void FourStandard()
        {
                price = Math.Round(134.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
                string dateToString = price.ToString();
                lbl_price.Text = "Price: " + dateToString + " €";
                priceShort = Math.Round(price, 0);
        }
        public void SingleLuxury()
        {
                price = Math.Round(69.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
                string dateToString = price.ToString();
                lbl_price.Text = "Price: " + dateToString + " €";
                priceShort = Math.Round(price, 0);
        }

        public void DoubleLuxury()
        {
                price = Math.Round(119.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
                string dateToString = price.ToString();
                lbl_price.Text = "Price: " + dateToString + " €";
                priceShort = Math.Round(price, 0);
        }

        public void ThreeLuxury()
        {
                price = Math.Round(169.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
                string dateToString = price.ToString();
                lbl_price.Text = "Price: " + dateToString + " €";
                priceShort = Math.Round(price, 0);
        }
        public void FourLuxury()
        {
                price = Math.Round(249.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
                string dateToString = price.ToString();
                lbl_price.Text = "Price: " + dateToString + " €";
                priceShort = Math.Round(price, 0);
        }
        public void SingleYouth()
        {
            price = Math.Round(19.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
            string dateToString = price.ToString();
            lbl_price.Text = "Price: " + dateToString + " €";
            priceShort = Math.Round(price, 0);
        }

        public void DoubleYouth()
        {
            price = Math.Round(39.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
            string dateToString = price.ToString();
            lbl_price.Text = "Price: " + dateToString + " €";
            priceShort = Math.Round(price, 0);
        }

        public void ThreeYouth()
        {
            price = Math.Round(59.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
            string dateToString = price.ToString();
            lbl_price.Text = "Price: " + dateToString + " €";
            priceShort = Math.Round(price, 0);
        }

        public void FourYouth()
        {
            price = Math.Round(79.99 * (dtp_dateTo.Value - dtp_dateFrom.Value).TotalDays, 2);
            string dateToString = price.ToString();
            lbl_price.Text = "Price: " + dateToString + " €";
            priceShort = Math.Round(price, 0);
        }

        private void edit_reservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_editRoom frm = new frm_editRoom();
            frm.ShowDialog();
            this.Close();
        }

        private void frm_rooms_Load(object sender, EventArgs e)
        {

        }
    }
}

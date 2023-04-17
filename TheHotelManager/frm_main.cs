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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_hotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_hotel hotel = new frm_hotel();
            hotel.ShowDialog();
            this.Close();
        }

        private void btn_restaurant_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_restaurant restaurant = new frm_restaurant();
            restaurant.ShowDialog();
            this.Close();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_employee employees = new frm_employee();
            employees.ShowDialog();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
            this.Close();
        }

        private void lbl_contactAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_contactAdmin contactAdmin = new frm_contactAdmin();
            contactAdmin.ShowDialog();
            this.Close();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            switch (frm_login.department)
            {
                case "Cleaning":
                    btn_employee.Enabled = false;
                    btn_restaurant.Enabled = false;
                    break;

                case "Restaurant":
                    btn_employee.Enabled = false;
                    btn_hotel.Enabled = false;
                    break;

                case "Reception":
                    btn_employee.Enabled = false;
                    btn_restaurant.Enabled = false;
                    break;
            }
            lbl_welcome.Text = "Welcome, " + frm_login.department + "!";
        }
    }
}

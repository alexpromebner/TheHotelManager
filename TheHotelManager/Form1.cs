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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }


        public static int id;
        public static string usernameSQLcon;

        public static int getid;
        public string departmentGiver;


        private void frm_login_Load(object sender, EventArgs e)
        {
            SQLInteraction.CreateDatabase("a.promebner_hotelmanager");
            SQLInteraction.CreateTable("a.promebner_hotelmanager", "login");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            departmentGiver = cb_department.Text;
            this.Hide();
            usernameSQLcon = txt_password.Text;
            SQLInteraction.CheckTable("login", cb_department.Text, txt_password.Text);
            
            SQLInteraction.GetID("login", cb_department.Text, "id");
            SQLInteraction.con.Close();

            frm_main frm = new frm_main();
            if (cb_department.Text == "admin")
            {
                frm.lbl_welcome.Text = "Welcome, Admin!";
            }
            else if(cb_department.Text == "Cleaning")
            {
                frm.lbl_welcome.Text = "Welcome, Cleaning Staff!";
                frm.btn_employee.Enabled = false;
                frm.btn_restaurant.Enabled = false;
            }
            else if (cb_department.Text == "Restaurant")
            {
                frm.lbl_welcome.Text = "Welcome, Restaurant Staff!";
                frm.btn_employee.Enabled = false;
                frm.btn_hotel.Enabled = false;
            }
            else if (cb_department.Text == "Reception")
            {
                frm.lbl_welcome.Text = "Welcome, Reception Staff!";
                frm.btn_employee.Enabled = false;
                frm.btn_restaurant.Enabled = false;
            }
            frm.ShowDialog();
            this.Close();
        }
    }
}

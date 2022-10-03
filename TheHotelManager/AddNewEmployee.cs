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
    public partial class frm_editemployee : Form
    {
        public frm_editemployee()
        {
            InitializeComponent();
        }

        private void btn_finished_Click(object sender, EventArgs e)
        {
            string salt;
            string hashedpw;

            if (txt_password.Text == txt_repeatpw.Text)
            {
                salt = BCrypt.GenerateSalt();

                hashedpw = BCrypt.HashPassword(txt_password.Text, salt);

                SQLInteraction.InsertInto("login", txt_name.Text, txt_surname.Text, hashedpw, txt_department.Text);
            }
            else
            {
                MessageBox.Show("Error!","Check Passwords!");
            }
        }
    }
}

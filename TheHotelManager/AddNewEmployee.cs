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

            if (String.IsNullOrEmpty(txt_name.Text) || String.IsNullOrEmpty(txt_surname.Text) || String.IsNullOrEmpty(txt_surname.Text) || String.IsNullOrEmpty(cmb_department.Text) || String.IsNullOrEmpty(txt_password.Text) || String.IsNullOrEmpty(txt_repeatpw.Text))
            {
                MessageBox.Show("Check Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password.Text != txt_repeatpw.Text)
            {
                MessageBox.Show("Check Passwords!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password.TextLength < 5 || txt_repeatpw.TextLength < 5)
            {
                MessageBox.Show("Check Passwordlength! Should be higher than 5!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txt_password.Text == txt_repeatpw.Text)
            {               
                salt = BCrypt.GenerateSalt();

                hashedpw = BCrypt.HashPassword(txt_password.Text, salt);

                SQLInteraction.InsertInto("login", txt_name.Text, txt_surname.Text, hashedpw, cmb_department.Text);
            }
            
        }

        private void frm_editemployee_Load(object sender, EventArgs e)
        {

        }
    }
}

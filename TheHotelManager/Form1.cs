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

        public static int getid;

        private void frm_login_Load(object sender, EventArgs e)
        {
            SQLInteraction.CreateDatabase("a.promebner_hotelmanager");
            SQLInteraction.CreateTable("a.promebner_hotelmanager", "login");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SQLInteraction.CheckTable("login", cb_department.Text, txt_password.Text);

            getid = SQLInteraction.GetID("login", cb_department.Text, "id");
            SQLInteraction.con.Close();
        }
    }
}

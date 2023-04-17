using System;
using System.Windows.Forms;

namespace TheHotelManager
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        #region Variablen
        public static int id;
        public static string usernameSQLcon;
        public static string department;
        public static int getid;
        public string departmentGiver;
        #endregion

        private void frm_login_Load(object sender, EventArgs e)
        {
            //Create the Database if not exists
            SQLInteraction.CreateDatabase("a.promebner_hotelmanager");
            //Create the Table if not exists
            SQLInteraction.CreateTable("a.promebner_hotelmanager", "login");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            departmentGiver = cb_department.Text;
            this.Hide();
            usernameSQLcon = txt_password.Text;

            //checks the database if department and password is correct
            SQLInteraction.CheckTable("login", cb_department.Text, txt_password.Text);


            SQLInteraction.GetID("login", cb_department.Text, "id");
            SQLInteraction.con.Close();

            //opens the main form
            frm_main frm = new frm_main();
            department = cb_department.Text;
            frm.ShowDialog();
            this.Close();
        }

        private void btn_guestuser_Click(object sender, EventArgs e)
        {
            //opens the menu
            frm_GuestMenu frm = new frm_GuestMenu();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_guestuser_Click_1(object sender, EventArgs e)
        {

        }
    }
}

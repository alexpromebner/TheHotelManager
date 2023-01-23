using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TheHotelManager
{
    public partial class frm_employee : Form
    {
        public static MySqlConnection con = new MySqlConnection();
        public frm_employee()
        {
            InitializeComponent();
        }

        private void txt_addSearch_Click(object sender, EventArgs e)
        {
            txt_addSearch.Text = "";
            txt_addSearch.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_employee_Load(object sender, EventArgs e)
        {
            GetData();
        }
        
        MySqlDataAdapter adap;
        DataTable dtset;
        BindingSource bsource = new BindingSource();
        void GetData()
        {
            con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
            con.Open();
            //MySqlCommand cmd = new MySqlCommand("Select * From login;", con);
            adap = new MySqlDataAdapter("Select * From login;", con);
            //adap.SelectCommand = cmd;
            dtset = new DataTable();
            adap.Fill(dtset);

            bsource.DataSource = dtset;
            dgv_employees.DataSource = bsource;
            adap.Update(dtset);
            con.Close();
   
        }

        

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_addemployee addemployee = new frm_addemployee();
            addemployee.ShowDialog();
            this.Close();
        }

        private void txt_addSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

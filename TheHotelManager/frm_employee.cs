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

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_employee_Load(object sender, EventArgs e)
        {
            GetData();
        }
        
        MySqlDataAdapter adap;
       
        void GetData()
        {
            try
            {
                con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                DataTable dt = new DataTable();
                adap = new MySqlDataAdapter("select * from login", con);
                adap.Fill(dt);
                dgv_employees.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void ClearData()
        {
            txt_name.Text = "";
            txt_surname.Text = "";
            txt_password.Text = "";
            cb_department.Text = "";
            ID = 0;
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
        int ID = 0;
        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                if (ID != 0)
                {
                    con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                    MySqlCommand cmd = new MySqlCommand("delete from login where id=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    GetData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgv_employees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgv_employees.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_name.Text = dgv_employees.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_surname.Text = dgv_employees.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_password.Text = dgv_employees.Rows[e.RowIndex].Cells[3].Value.ToString();
            cb_department.Text = dgv_employees.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            string salt;
            string hashedpw;
            try
            {
                if (txt_name.Text != "" && txt_surname.Text != "" && txt_password.Text != "" && cb_department.Text != "")
                {
                    con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                    MySqlCommand cmd = new MySqlCommand("update login set name=@name,surname=@surname,password=@password,department=@department where ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@surname", txt_surname.Text);
                    salt = BCrypt.GenerateSalt();

                    hashedpw = BCrypt.HashPassword(txt_password.Text, salt);
                    cmd.Parameters.AddWithValue("@password", hashedpw);
                    cmd.Parameters.AddWithValue("@department", cb_department.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                    GetData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

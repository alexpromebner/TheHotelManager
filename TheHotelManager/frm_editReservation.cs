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
    public partial class frm_editReservation : Form
    {
        int ID = 0;

        public frm_editReservation()
        {
            InitializeComponent();
        }

        private void frm_editReservation_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public static MySqlConnection con = new MySqlConnection();
        MySqlDataAdapter adap;
        DataTable dtset;
        BindingSource bsource = new BindingSource();

        void GetData()
        {

            con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
            con.Open();
            adap = new MySqlDataAdapter("Select * From tables;", con);
            //adap.SelectCommand = cmd;
            dtset = new DataTable();
            adap.Fill(dtset);

            bsource.DataSource = dtset;
            dgv_tables.DataSource = bsource;
            adap.Update(dtset);
            con.Close();

        }

        private void btn_backEditRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_tables tables = new frm_tables();
            tables.ShowDialog();
            this.Close();
        }

        private void btn_deleteR_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                    MySqlCommand cmd = new MySqlCommand("delete from tables where id=@id", con);
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

        private void dgv_tables_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgv_tables.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Tname.Text = dgv_tables.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Tsurname.Text = dgv_tables.Rows[e.RowIndex].Cells[2].Value.ToString();
            nud_tNumber.Text = dgv_tables.Rows[e.RowIndex].Cells[3].Value.ToString();
            nud_amount.Text = dgv_tables.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtp_date.Text = dgv_tables.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_notes.Text = dgv_tables.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ClearData()
        {
            txt_notes.Text = "";
            txt_Tname.Text = "";
            txt_Tsurname.Text = "";

            ID = 0;
        }

        private void btn_saveR_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Tname.Text != "" && txt_Tsurname.Text != "" && txt_notes.Text != "" && nud_amount.Text != "" && nud_amount.Text != "" && dtp_date.Text != "")
                {
                    con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                    MySqlCommand cmd = new MySqlCommand("UPDATE tables SET name = @name, surname = @surname, tablenum = @tablenum, people = @people, date = @date, comment = @comment where ID = @id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@name", txt_Tname.Text);
                    cmd.Parameters.AddWithValue("@surname", txt_Tsurname.Text);
                    cmd.Parameters.AddWithValue("@tablenum", nud_tNumber.Text);
                    cmd.Parameters.AddWithValue("@people", nud_amount.Text);
                    cmd.Parameters.AddWithValue("@date", dtp_date.Value);
                    cmd.Parameters.AddWithValue("@comment", txt_notes.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

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
    public partial class frm_editRoom : Form
    {
        //id important for filter the right room
        int ID = 0;

        public frm_editRoom()
        {
            InitializeComponent();
        }

        private void frm_editRoom_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public static MySqlConnection con = new MySqlConnection();
        MySqlDataAdapter adap;
        DataTable dtset;
        BindingSource bsource = new BindingSource();

        //get newest Data from Database
        void GetData()
        {

            con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
            con.Open();
            adap = new MySqlDataAdapter("Select * From Rooms;", con);
            //adap.SelectCommand = cmd;
            dtset = new DataTable();
            adap.Fill(dtset);

            bsource.DataSource = dtset;
            dgv_rooms.DataSource = bsource;
            adap.Update(dtset);
            con.Close();

        }

        //empty textboxes
        private void ClearData()
        {
            txt_name.Text = "";
            txt_surname.Text = "";
            txt_price.Text = "";
            ID = 0;
        }

        //delete a room
        private void btn_deleteR_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                    MySqlCommand cmd = new MySqlCommand("delete from Rooms where id=@id", con);
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

        //fill up the textboxes
        private void dgv_rooms_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgv_rooms.Rows[e.RowIndex].Cells[0].Value.ToString());
            cb_roomNumber.Text = dgv_rooms.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_roomType.Text = dgv_rooms.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_name.Text = dgv_rooms.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_surname.Text = dgv_rooms.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtp_dateFrom.Text = dgv_rooms.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtp_dateTo.Text = dgv_rooms.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_price.Text = dgv_rooms.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        //save the updates on database
        private void btn_saveR_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (cb_roomNumber.Text != "" && cb_roomType.Text != "" && txt_name.Text != "" && txt_surname.Text != "" && dtp_dateTo.Text != "" && dtp_dateFrom.Text != "" && txt_price.Text != "")
                {
                    con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                    MySqlCommand cmd = new MySqlCommand("UPDATE Rooms SET BedNumber = @bednumber, RoomType = @roomtype, Name = @name, Surname = @surname, FromDate = @fromdate, ToDate = @todate, Price = @price where ID = @id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@bednumber", cb_roomNumber.Text);
                    cmd.Parameters.AddWithValue("@roomtype", cb_roomType.Text);
                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@surname", txt_surname.Text);
                    cmd.Parameters.AddWithValue("@fromdate", dtp_dateFrom.Value);
                    cmd.Parameters.AddWithValue("@todate", dtp_dateTo.Value);
                    cmd.Parameters.AddWithValue("@price", txt_price.Text);
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

        //going one form back
        private void btn_backEditRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_rooms frm = new frm_rooms();
            frm.ShowDialog();
            this.Close();
        }
    }
}

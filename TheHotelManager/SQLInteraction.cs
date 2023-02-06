using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TheHotelManager
{
    class SQLInteraction : frm_login
    {

        public static MySqlConnection con = new MySqlConnection();
        static MySqlCommand cmd;


        //public static string username1 = frm_login.usernameSQLcon;


        //Creates Database if not exists
        public static void CreateDatabase(string dbname)
        {

            try
            {
                con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password=MyDatabase034;";
                con.Open();
                string text = "CREATE DATABASE IF NOT EXISTS '" + dbname + "';";
                cmd = new MySqlCommand(text, con);
                //MessageBox.Show("Database opened!");
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);
            }

        }

        //Creates Table if not exists
        public static void CreateTable(string dbname, string tablename)
        {
            try
            {
                con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                string text = "use [" + dbname + "] if not exists(select * from sysobjects where name = '" + tablename + "') begin create table " + tablename + "(Id int NOT NULL Primary Key,username varchar(20),password varchar(70)) end";
                cmd = new MySqlCommand(text, con);
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Login Check for the password
        public static void CheckTable(string tablename, string role, string password)
        {
            string hashedpw;
            try
            {
                con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                cmd.CommandText = "Select password From login Where department='" + role + "'";
                hashedpw = (string)cmd.ExecuteScalar();
                //hashedpw = v_password;
                if (hashedpw != null)
                {
                    if (BCrypt.CheckPassword(password, hashedpw))
                    {
                        MessageBox.Show("You are now logged in!", "Logged In!");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!", "Error!");
                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //New Account inserts into the database 
        public static void InsertInto(string tablename, string name, string surname, string password, string department)
        {

            try
            {
                con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                string text = "INSERT INTO " + tablename + " (name,surname,password,department) VALUES('" + name + "', '" + surname + "', '" + password + "', '" + department + "')";
                cmd = new MySqlCommand(text, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        //New Reservation
        public static void InsertIntoReservation(string tablename, string bednumber, string roomtype, string name, string surname, string datefrom, string dateto, double price)
        {

            try
            {
                con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                string text = "INSERT INTO " + tablename + " (BedNumber,RoomType,Name,Surname,FromDate,ToDate,Price) VALUES('" + bednumber + "', '" + roomtype + "', '" + name + "', '" + surname + "', '" + datefrom + "', '" + dateto + "', '" + price + "')";
                cmd = new MySqlCommand(text, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void Update(string tablename, string columnname)
        {
            try
            {
                con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                //cmd.CommandText = "UPDATE " + tablename + " SET " + columnname + " = " + columnname + " + 1 WHERE id = " + id + ";";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static int GetID(string tablename, string v_username, string name)
        {
            try
            {
                con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
                con.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd.CommandText = "SELECT " + name + " FROM " + tablename + " WHERE username = '" + v_username + "';";
                cmd.ExecuteNonQuery();
                //con.Close();          
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return (int)cmd.ExecuteScalar();
        }

        public static string getusername()
        {
            string username;

            con.ConnectionString = "server=eduweb20;database=a.promebner_hotelmanager;UID=a.promebner;password='MyDatabase034';";
            con.Open();
            cmd.Connection = con;
            //cmd.CommandText = "Select Username from Login where Username = '" + username1 + "';";
            username = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            //to return the username as string at the end of the method
            return username;
        }
    }
}

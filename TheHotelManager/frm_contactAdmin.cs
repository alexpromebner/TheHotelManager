using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Org.BouncyCastle.Crypto;

namespace TheHotelManager
{
    public partial class frm_contactAdmin : Form
    {
        public frm_contactAdmin()
        {
            InitializeComponent();
        }

        private void btn_backA_Click(object sender, EventArgs e)
        {

        }

        private void cb_problems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_problems.Text == "Other")
            {
                txt_other.Enabled = true;
            }
            else if (cb_problems.Text != "Other")
            {
                txt_other.Enabled = false;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage newMail = new MailMessage();
                // use the Gmail SMTP Host
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                // Follow the RFS 5321 Email Standard
                newMail.From = new MailAddress("thehotelmanagerswp@gmail.com", "The Hotel Manager");

                newMail.To.Add(txt_email.Text);// declare the email subject

                newMail.Subject = cb_problems.Text; // use HTML for the email body

                newMail.IsBodyHtml = true; newMail.Body = "<h1> This is my first Templated Email in C# </h1>";

                // enable SSL for encryption across channels
                client.EnableSsl = true;
                // Port 465 for SSL communication
                client.Port = 465;
                // Provide authentication information with Gmail SMTP server to authenticate your sender account
                client.Credentials = new System.Net.NetworkCredential("thehotelmanagerswp@gmail.com", "iyuidkyiozmpmcpu");

                client.Send(newMail); // Send the constructed mail
                MessageBox.Show("Email Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -" + ex);
            }

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_email.ForeColor = Color.Black;
        }
    }
}

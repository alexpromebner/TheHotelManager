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
            this.Hide();
            frm_main frm = new frm_main();
            frm.ShowDialog();
            this.Close();
        }

        private void cb_problems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage newMail = new MailMessage();
                // use the Gmail SMTP Host
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Timeout = 500000;

                // Follow the RFS 5321 Email Standard
                newMail.From = new MailAddress("thehotelmanagerswp@gmail.com", "The Hotel Manager");

                newMail.To.Add(txt_email.Text);// declare the email subject

                newMail.Subject = cb_problems.Text; // use HTML for the email body

                //newMail.IsBodyHtml = true; 
                newMail.Body = "Your problem is in the queue! \n \n Your Problem:\n" + txt_other.Text + "\n\n\nThis email is generated automatically!";

                // enable SSL for encryption across channels
                client.EnableSsl = true;
                // Port 465 for SSL communication
                client.Port = 587;
                // Provide authentication information with Gmail SMTP server to authenticate your sender account
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("thehotelmanagerswp@gmail.com", "iyuidkyiozmpmcpu");

                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(newMail); // Send the constructed mail
                MessageBox.Show("Email Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void frm_contactAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cb_problems.ResetText();
            txt_email.ResetText();
            txt_other.ResetText();
        }
    }
}

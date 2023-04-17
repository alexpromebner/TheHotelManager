using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

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



        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage newMail = new MailMessage();
                // use the Gmail SMTP Host
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Timeout = 500000;

                // Follow the RFS 5321 Email Standard
                newMail.From = new MailAddress(txt_email.Text, txt_email.Text);

                newMail.To.Add("thehotelmanagerswp@gmail.com");// declare the email subject

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

        private void txt_email_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_email.ForeColor = Color.Black;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cb_problems.ResetText();
            txt_email.ResetText();
            txt_other.ResetText();
        }

        private void btn_backWarehouse_Click(object sender, EventArgs e)
        {
            frm_warehouse frm_Warehouse = new frm_warehouse();
            this.Hide();
            frm_Warehouse.ShowDialog();
            this.Close();
        }
    }
}

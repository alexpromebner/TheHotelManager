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
    public partial class frm_employee : Form
    {
        public frm_employee()
        {
            InitializeComponent();
        }

        private void txt_addSearch_Click(object sender, EventArgs e)
        {
            txt_addSearch.Text = "";
            txt_addSearch.ForeColor = Color.Black;
        }

        private void btn_backR_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_main employeeMain = new frm_main();
            employeeMain.ShowDialog();
            this.Close();
        }
    }
}

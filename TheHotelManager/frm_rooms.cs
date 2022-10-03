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
    public partial class frm_rooms : Form
    {
        public frm_rooms()
        {
            InitializeComponent();
        }

        private void frm_rooms_Load(object sender, EventArgs e)
        {

        }

        private void txt_name_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_name.ForeColor = Color.Black;
        }
    }
}

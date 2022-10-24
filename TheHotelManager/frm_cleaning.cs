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
    public partial class frm_cleaning : Form
    {
        public frm_cleaning()
        {
            InitializeComponent();
        }

        private void btn_cleaned_Click(object sender, EventArgs e)
        {
            string rooms = lb_rooms.SelectedItem.ToString();
        }
    }
}

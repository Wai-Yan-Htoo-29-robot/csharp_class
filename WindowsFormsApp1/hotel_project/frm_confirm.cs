using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.hotel_project
{
    public partial class frm_confirm : Form
    {
        public frm_confirm()
        {
            InitializeComponent();
        }

        private void frm_confirm_Load(object sender, EventArgs e)
        {
            lbl_start_date.Text = "";
            lbl_end_date.Text = "";
            lbl_numberofguest.Text = "";
            lbl_numberofroom.Text = "";
            lbl_fees.Text = "";
            lbl_room_type.Text = "";

            lbl_start_date.Text = frm_client_dashboard.startdate;
            lbl_end_date.Text = frm_client_dashboard.enddate;
            lbl_numberofguest.Text = frm_client_dashboard.number_of_guest.ToString();
            lbl_numberofroom.Text = frm_client_dashboard.number_of_room.ToString();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

        }
    }
}

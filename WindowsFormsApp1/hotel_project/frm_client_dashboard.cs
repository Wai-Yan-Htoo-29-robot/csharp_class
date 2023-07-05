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
    public partial class frm_client_dashboard : Form
    {
        public frm_client_dashboard()
        {
            InitializeComponent();
        }

       

        private void btn_plus_Click(object sender, EventArgs e)
        {
            int increase = int.Parse(label6.Text);
            increase++;//2
            //                 "2"
            label6.Text = increase.ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            int decrease = int.Parse(label6.Text);
            if (decrease > 1)
            {
                decrease--;//decrease -= 1; decrease = decrease -1 ;
            }
            label6.Text = $"{decrease}";
        }

        private void frm_client_dashboard_Load(object sender, EventArgs e)
        {

        }

        public static string startdate;
        public static string enddate;
        public static int number_of_room;
        public static int number_of_guest;

        private void btn_bookin_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            startdate = dateTimePicker1.Text;
            enddate = dateTimePicker2.Text;
            number_of_room = Convert.ToInt32(cbo_number_of_room.SelectedItem);
            number_of_guest = int.Parse(label6.Text.ToString());

            frm_confirm frm_Confirm = new frm_confirm();
            frm_Confirm.TopLevel = false;
            this.panel1.Controls.Add(frm_Confirm);
            frm_Confirm.Show();
        }
    }
}

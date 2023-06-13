using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.kattis
{
    public partial class frm_take_two_stones : Form
    {
        public frm_take_two_stones()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            //             convert.toint32 (3) int.Parse 
            int user_input = Convert.ToInt32(txt_input.Text);
            if ( user_input % 2 == 0)
            {
                MessageBox.Show("Bob");
            }
            else
            {
                MessageBox.Show("Alice");
            }
        }
    }
}

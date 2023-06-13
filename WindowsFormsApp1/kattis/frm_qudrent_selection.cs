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
    public partial class frm_qudrent_selection : Form
    {
        public frm_qudrent_selection()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            int user_input1;
            int user_input2;
            user_input1 = int.Parse(txt_input1.Text);
            user_input2 =int.Parse( txt_input2.Text);
            if (user_input1 >=0 && user_input2>=0)
            {
                MessageBox.Show("Q1");
            }
            else if(user_input1 < 0 && user_input2 >= 0)
            {
                MessageBox.Show("Q2");
            }
            else if (user_input1 < 0 && user_input2 < 0)
            {
                MessageBox.Show("Q3");
            }
            else
            {
                MessageBox.Show("Q4");
            }
            //string interpolation
            MessageBox.Show($"{user_input1 + user_input2}");
        }
    }
}

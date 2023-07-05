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
    public partial class nastyhack : Form
    {
        public nastyhack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] num = { 1, 2, 3, 4, "string" };


            dynamic user_input = textBox1.Text.Split(' ');

            int does_not_r, does_e, c;
            does_not_r = int.Parse(user_input[0]);
            does_e = int.Parse(user_input[1]);
            c =int.Parse( user_input[2]);
            string output;
            if(does_not_r > does_e - c)
            {
                output = "does not advertise";
            }else if(does_not_r == does_e - c)
            {
                output = "does not matter";
            }
            else
            {
                output = "advertise";
            }
            MessageBox.Show(output);
        }
    }
}

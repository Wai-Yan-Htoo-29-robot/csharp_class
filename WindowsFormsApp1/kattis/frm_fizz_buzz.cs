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
    public partial class frm_fizz_buzz : Form
    {
        public frm_fizz_buzz()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            lbl_fizzbuzz.Text = "";
            int i = 1;
            string output;
            int x;
            int y;
            int n;
            x = int.Parse(txt_input1.Text);
            y = int.Parse(txt_input2.Text);
            n = int.Parse(txt_input3.Text);

            while (i<=n)
            {// why these condition are start?
                if(i % x == 0 && i%y==0) 
                {
                    output = "fizzbuzz";
                }
                else if(i%x == 0)
                {
                    output = "fizz";
                }
                else if(i%y == 0)
                {
                    output = "buzz";
                }
                else {
                    output = i.ToString();
                }
                lbl_fizzbuzz.Text += $"{output}\n";
                i += 1;
            }


        }
    }
}

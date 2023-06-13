using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_reset : Form
    {
        public frm_reset()
        {
            InitializeComponent();
        }
        
        int count = 0;//global scope

        private void btn_increase_Click(object sender, EventArgs e)
        {
                
            count +=1;//count++
            //    string     integer.tostring()
            label1.Text=count.ToString();
            //variable datatype

        }

        private void frm_reset_Load(object sender, EventArgs e)
        {

        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            //            false
            if(rbtn_male.Checked == true) 
            {
                MessageBox.Show("male");
            }
            //              false
            else if(rbtn_female.Checked == true)
            {
                MessageBox.Show("female");
            }
            //         true            ==  true
            else
            {
                MessageBox.Show("other");
            }

            // if (input % 2 == 0){ messagebox Bob } else { messagebox Alice }

        }

        private void btn_one_click_Click(object sender, EventArgs e)
        {
            //int i = 5;
            label1.Text = "";
            ////     5 < 5
            //while (i < 5)
            //{
            //    //      0
            //    label1.Text += $"{i}\n";
            //    // i = 5
            //    i += 1; // i = i + 1
            //}
            //MessageBox.Show("nothing to do");
            //for (intilization ; condition ; update )
            //for (int i = 0; i < 5; i++)
            //{
            //    label1.Text += $"{i}\n";
            //}

            int i = 5;
            do
            {
                label1.Text += $"{i}\n";
                i += 1;
            } while (i < 5);


        }
    }
}

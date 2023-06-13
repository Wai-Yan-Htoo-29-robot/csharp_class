using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
             int decrease= int.Parse( label2.Text) ;
            //decrease = 1
            //     1>1
            if ( decrease > 1 ) 
            {
                decrease--;//decrease -= 1; decrease = decrease -1 ;
            }
            
            label2.Text = $"{decrease}";//decrease.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //increase  =  1 integer
            int increase = int.Parse(label2.Text);
            increase++;//2
            //                 "2"
            label2.Text = increase.ToString();
        }
    }
}

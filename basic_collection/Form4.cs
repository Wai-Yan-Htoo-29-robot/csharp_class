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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string data= textBox1.Text;
            int a,b,c,d=1;
            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] == 'A')
                {
                    b = d;
                }else if (data[i] == 'B')
                {
                    c = d;
                }else if (data[i] == 'C')
                {
                    a= d;
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // listener
            this.MouseDown += new MouseEventHandler(this.Form4_MouseDown);
            this.MouseMove += new MouseEventHandler(this.Form4_MouseMove);
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            Random r=new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }
    }
}

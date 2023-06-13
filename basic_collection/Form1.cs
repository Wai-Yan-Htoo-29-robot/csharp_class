using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        public static string pass_value;
        public static int count;

        private void button1_Click(object sender, EventArgs e)
        {
            pass_value = "hello";
            count = 10;
            this.Hide();
            Form2 f2= new Form2();
            f2.ShowDialog();
        }
    }
}

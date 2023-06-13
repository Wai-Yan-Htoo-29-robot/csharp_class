using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection.cafe_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ice_amaricano ice_am=new ice_amaricano();
            ice_am.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cappuciino ice_am=new cappuciino();
            ice_am.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            latte ice_am=new latte();
            ice_am.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            espresso ice_am=new espresso();
            ice_am.ShowDialog();
        }
    }
}

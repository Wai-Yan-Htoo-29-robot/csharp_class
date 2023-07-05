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
    public partial class hotel_dashboard : Form
    {
        public hotel_dashboard()
        {
            InitializeComponent();
        }
        frm_single_room fsr = new frm_single_room();
        frm_double_room fdr = new frm_double_room();
        frm_bungalow fbun = new frm_bungalow();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           panel2.Controls.Clear();
            fsr.TopLevel = false; // form
            //fsr.AutoScroll = true;
            this.panel2.Controls.Add(fsr);
            fsr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fdr.TopLevel = false; // form
            //fsr.AutoScroll = true;
            this.panel2.Controls.Add(fdr);
            fdr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fbun.TopLevel = false; // form
            //fsr.AutoScroll = true;
            this.panel2.Controls.Add(fbun);
            fbun.Show();
        }
    }
}

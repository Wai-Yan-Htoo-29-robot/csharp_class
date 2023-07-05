using System;
using System.Collections;
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
    public partial class frm_list : Form
    {
        public frm_list()
        {
            InitializeComponent();
        }

        ArrayList collection_of_data_type = new ArrayList();
        private void btn_show_list_Click(object sender, EventArgs e)
        {
            //array list
            for (int i = 0; i < collection_of_data_type.Count; i++)
            {
                MessageBox.Show($"{collection_of_data_type[i]}");
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            collection_of_data_type.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("functional programming");
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show("object oriented programming");
            }
        }
    }
}
/*
  Aries, 
Taurus, 
Gemini, 
Cancer, 
Leo, 
Virgo, 
Libra, 
Scorpio, 
Sagittarius, 
Capricorn, 
Aquarius, and 
Pisces
  */
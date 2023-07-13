using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.zodic_sign
{
    public partial class frm_your_furture : Form
    {
        public frm_your_furture()
        {
            InitializeComponent();
        }

        private void cbo_zodic_sign_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            if (cbo_zodic_sign.SelectedIndex == 0)
            {
                //Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\aries_sign.jpg");
                //pictureBox1.Image = image;
                pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\aries_sign.jpg");
                 
            }
            else if(cbo_zodic_sign.SelectedIndex == 1)
            {
                //Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\taurus.jpg");
                //pictureBox1.Image = image;
                pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\taurus.jpg");
                 
            }
            else if (cbo_zodic_sign.SelectedIndex == 2)
            {
                //Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\gemini.jpg");
                //pictureBox1.Image = image;
                pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\gemini.jpg");
                 
            }
            else if (cbo_zodic_sign.SelectedIndex == 3)
            {
                //Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\cancer.jpg");
                //pictureBox1.Image = image;

                pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\cancer.jpg");
            }
            else if (cbo_zodic_sign.SelectedIndex == 4)
            {
                Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\leo.jpg");
                pictureBox1.Image = image;
            }
            else if (cbo_zodic_sign.SelectedIndex == 5)
            {
                Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\virgo.jpg");
                pictureBox1.Image = image;
            }
            else if (cbo_zodic_sign.SelectedIndex == 6)
            {
                Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\libra.jpg");
                pictureBox1.Image = image;
            }
            else if (cbo_zodic_sign.SelectedIndex == 7)
            {
                Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\scorpio.jpg");
                pictureBox1.Image = image;
            }
            else if (cbo_zodic_sign.SelectedIndex == 8)
            {
                Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\sagittarius.jpg");
                pictureBox1.Image = image;
            }
            else if (cbo_zodic_sign.SelectedIndex == 9)
            {
                Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\capricon.jpg");
                pictureBox1.Image = image;
            }
            else if (cbo_zodic_sign.SelectedIndex == 10)
            {
                Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\aquarius.jpg");
                pictureBox1.Image = image;
            }
            else if (cbo_zodic_sign.SelectedIndex == 11)
            {
                Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\WindowsFormsApp1\\zodic_sign\\img\\pisces.jpg");
                pictureBox1.Image = image;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

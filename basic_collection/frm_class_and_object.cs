using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection
{
    public partial class frm_class_and_object : Form
    {
        public frm_class_and_object()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //m              012
            //string input1 = "212";
            //string input2 = "1253";

            //int lastindex1 = input1.Length -1 ;
            //int lastindex2 = input2.Length -1 ;
            //int power1 = int.Parse( input1[lastindex1].ToString());
            //int power2 = int.Parse(input2[lastindex2].ToString());

            //string base1="",base2="";
            //int c_base1,c_base2;
            //for (int i=0;i<input1.Length-1;i++)
            //{
            //    base1 += input1[i];
            //}

            //for (int i = 0; i < input2.Length - 1; i++)
            //{
            //    base2 += input2[i];
            //}
            //c_base1 =  int.Parse( base1);
            //c_base2 = int.Parse( base2);
            //int first_number = (int) Math.Pow(c_base1, power1);
            //int second_number = (int)Math.Pow(c_base2, power2);
            ////MessageBox.Show($"{first_number} {second_number}");
            //int sum = first_number + second_number;
            //MessageBox.Show($"{sum}");



            //int num1 = Convert.ToInt16( Math.Pow(c_base1, power1));

            //int num2 = Convert.ToInt16( Math.Pow(int.Parse(base2), power2));

            // MessageBox.Show($"{Convert.ToInt64( Math.Pow(c_base1, power1) + Math.Pow(c_base2, power2))}" );


            //class obj
            animal_class animal_sound= new animal_class();
            animal_sound.cat_setter("myoy myou");
            animal_sound.Dog = "wote wote wote";
            animal_sound.Cow = "moooooooooooo";
            MessageBox.Show( animal_sound.cat_getter());
            MessageBox.Show(animal_sound.Dog);
            MessageBox.Show(animal_sound.Cow);

            animal_class bird_sound = new animal_class("kyali kyali");
            animal_class animal_info = new animal_class("mo mo",60,"---","1963-12-1","Bahan-kyauk tine");
        }
    }
}

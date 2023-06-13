using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.kattis
{
    public partial class count_the_vowel : Form
    {
        public count_the_vowel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //looping
            // while ( condition ) { block }
           
            
            label1.Text = "";
            int j = 5;
            string rv_numer="";
            while (j >= 1)
            {
                int i = 1;
                while (i <= j)
                {  
                    rv_numer += $"{i}";
                    i++;
                }
                int k = 4;
                while (k >= 0)
                {
                    label1.Text += rv_numer[k];
                    k--;
                }
                rv_numer = "";
                label1.Text += "\n";
                j--;
            }




            //int count = 1;
            //bool check = true;
            //// infinite
            //while (true)
            //{
            //    MessageBox.Show("hello");
            //    count++;
            //    if (count == 5)
            //    {
            //        MessageBox.Show(count.ToString());
            //        break;
            //    }
            //}


            ////array                 0 1 2  3
            //int[] array_variable = {3,2,4 };
            //// 01 02 12
            //int target = 6;
            ////exception handling
            //try
            //{
            //    for (int i = 0; i <= array_variable.Length; i++)
            //    {
            //        //                                    3
            //        if (array_variable[i] + array_variable[i + 1] == target)
            //        {
            //            MessageBox.Show($"[{i},{i + 1}]");
            //        }
            //    }
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show(error.Message);
            //}


            //if (array_variable[0] + array_variable[1] == target)
            //{
            //    MessageBox.Show("[0,1]");
            //}
            //else if (array_variable[0] + array_variable[2] == target)
            //{
            //    MessageBox.Show("[0,2]");
            //}
            //else if (array_variable[1] + array_variable[2] == target)
            //{
            //    MessageBox.Show("[1,2]");
            //}

            ////index
            //MessageBox.Show(array_variable[2].ToString());

            //int normal_variable = 12;



            ////current day , month , year
            //int c_day = DateTime.Now.Day; 
            //int c_month = DateTime.Now.Month; 
            //int c_year = DateTime.Now.Year;

            ////my birthday
            ////                         0   1    2
            ////             1.6.1997  {"1","6","1997"}
            //string[] dob = textBox1.Text.Split('.');

            //int my_age;
            ////
            //if (int.Parse(dob[1]) < c_day)
            //{
            //    my_age = c_year - int.Parse(dob[2])-1;
            //}
            //else
            //{
            //    my_age = c_year - int.Parse(dob[2]);
            //}

            //MessageBox.Show($"{my_age}");



            //int firstnum=int.Parse( textBox1.Text);
            //int secondnum =int.Parse(textBox2.Text);
            //if (firstnum > secondnum)
            //{
            //    MessageBox.Show("1");
            //}
            //else
            //{
            //    MessageBox.Show("0");
            //}





            //int count = 0;
            //string vowel = "aeiou";
            //string user_input = textBox1.Text.ToLower();//aeiou
            ////          11
            //for(int i = 0; i < user_input.Length; i++)
            //{
            //    for(int j = 0;j < vowel.Length; j++)//j = 1
            //    {
            //        if (user_input[i] == vowel[j])
            //        {
            //            count++;
            //            j=vowel.Length;
            //        }
            //    }
            //}
            //MessageBox.Show(count.ToString());
        }

        private void count_the_vowel_Load(object sender, EventArgs e)
        {
            //prime number
           // string prime_not = "";
            
           //for (int i=2; i <= 100; i++)
           // {
           //     int n_prime = 0;
           //     if (i == 2)
           //     {
           //         MessageBox.Show($"{i} is prime");
           //     }
           //     else
           //     {
           //                //      2   8
           //         for(int j = 2; j < i; j++)
           //         {
           //              // 8 % 2
           //             if (i % j != 0)
           //             {
           //                 //prime
           //                 prime_not = "prime";
           //             }
           //             else
           //             {
           //                 //not prime
           //                 prime_not = "not prime";
           //                 j = i; //8

           //                 bool check=true;
           //                 //     true
           //                 while (check)
           //                 {
           //                     //              10 < 11
           //                     for (int k = 2; k < j; k++)
           //                     {
           //                         //  11 % 2
           //                         if (j % k != 0)
           //                         {
           //                            //   11 - 10 1==1
           //                             if (j - k == 1)
           //                             {
           //                                 n_prime = j;
           //                                 check = false;
                                            
           //                             }
           //                         }
           //                         else
           //                         {
           //                             k = j;
           //                         }
           //                     }
           //                     j++;
           //                 }

           //             }
           //         }
           //         MessageBox.Show($"{i} is {prime_not}");
           //         //     5 > 0
           //         if (n_prime>0) 
           //         {
           //             MessageBox.Show($"{n_prime} is nearest prime");
           //         }
                    
                   

            //    }
            //}
        }
    }
}

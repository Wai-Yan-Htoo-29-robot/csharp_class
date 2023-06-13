using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection.ATM
{
    public partial class frm_function : Form
    {
        public frm_function()
        {
            InitializeComponent();
        }

        //strong password
        // 1. length greather than 6
        // 2. special character ( eg : !@#$%^*|,:_;? )
        // 3. alphanumeric ( eg : h1e2l345lo123)
        // 4. Capital letter ( eg: A - Z)
        // 5. small letter ( eg: a - z)

        int count = 0;

        public bool strong_pwd()
        {
            string strong_password = txt_password.Text;
            string special_character = "!@#$%^&*|:?_";

            if (strong_password.Length >= 6)
            {
                for (int i = 0; i < strong_password.Length; i++)
                {
                    if (char.IsDigit(strong_password[i]))
                    {
                        count += 1;
                        MessageBox.Show("found digit");
                        break;
                    }
                }

                for (int i = 0; i < strong_password.Length; i++)
                {
                    if (char.IsUpper(strong_password[i]))
                    {
                        count += 1;
                        MessageBox.Show("found upper");
                        break;
                    }
                }
                for (int i = 0; i < strong_password.Length; i++)
                {
                    if (char.IsLower(strong_password[i]))
                    {
                        count += 1;
                        MessageBox.Show("found lower");
                        break;
                    }

                }

                for (int i = 0; i < special_character.Length; i++)
                {
                    for (int j = 0; j < strong_password.Length; j++)
                    {
                        if (special_character[i] == strong_password[j])
                        {
                            count += 1;
                            MessageBox.Show("found special character");
                            j = strong_password.Length;
                            i = special_character.Length;
                        }
                    }
                }
            }

           
            if (count == 4)
            {
               return true;
            }
            else
            {
                MessageBox.Show("reenter your password");
                txt_password.Clear();// txt_password.text="";
                return false;
                
            }

        }


        private void btn_register_Click(object sender, EventArgs e)
        {
            //  true
          if(strong_pwd())
            {
                MessageBox.Show("registeration success");
            }
          
        }
    }
}

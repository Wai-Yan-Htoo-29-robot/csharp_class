using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1.simple_project
{

    public partial class frm_customers_register : Form
    {
        public frm_customers_register()
        {
            InitializeComponent();
        }
        //connect to db
        // class   obj
        Connect connect = new Connect();
        
        //class      obj
        MySqlCommand cmd = new MySqlCommand();

        //function 
        //1.keyword(public,private,proctected) 2.datatype(void , return(int,string,char,float...))
        //3.function name
        //                            parameter / argument
        public bool strong_password(string password)
        {
            int count=0;
            string special_char = "!@#$%^&*~|;_-";

             // length of password
            if (password.Length >= 6)
            {
                count += 1;
            }

            //special character
            //             0 < 13       
            for (int i = 0; i < special_char.Length; i++)
            {     //           1 < 4
                for (int j = 0; j < password.Length; j++)
                {
                    //                ! == 2
                    if (special_char[i] == password[j])
                    {
                        count +=1;
                        i = special_char.Length;
                        j = password.Length;
                    }
                }
            }

            //upper case
            for (int i = 0; i < password.Length; i++)
            {
                //      true islower, isdigit
                if (char.IsUpper(password[i]))
                {
                    count += 1;
                    break;
                }
            }

            //lowercase
            for (int i = 0; i < password.Length; i++)
            {
                //      true islower, isdigit
                if (char.IsLower(password[i]))
                {
                    count += 1;
                    break;
                }
            }

            //digit
            for (int i = 0; i < password.Length; i++)
            {
                //      true islower, isdigit
                if (char.IsDigit(password[i]))
                {
                    count += 1;
                    break;
                }
            }

            if (count == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string name,email,password, confirm_password;

        private void linlbl_alreadyaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_customers_login fcl=new frm_customers_login();
            fcl.ShowDialog();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            name=txt_username.Text;
            email=txt_email.Text;
            password=txt_password.Text;
            confirm_password=txt_confirm_password.Text;

            //modified function call in signup button
            //MessageBox.Show($"{strong_password(password)}");
           
           
            if(name=="" || email=="" || password=="" || confirm_password == "")
            {
                MessageBox.Show("please enter user name or password ");
            }
            else
            {//       modified strong password
                if (password == confirm_password && strong_password(password))
                {
                    //insert query
                    //
                    cmd = connect.conn.CreateCommand();

                    cmd.CommandText = "insert into user_info(name,email,password,confirm_password)" +
                        "values('"+name+"','"+email+"','"+password+"','"+confirm_password+"')";
                    
                    cmd.ExecuteNonQuery();
                    connect.conn.Close();

                    //redirect to login form
                    this.Hide();
                    frm_customers_login fcl = new frm_customers_login();
                    fcl.ShowDialog();
                }
                else
                {
                    MessageBox.Show("password are invalid");
                }
               
            }
            //strong password alphanumeric specialcharacter capital small length >6

        }
    }
}

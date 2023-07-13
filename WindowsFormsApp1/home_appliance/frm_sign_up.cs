using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.home_appliance
{
    public partial class frm_sign_up : Form
    {
        public frm_sign_up()
        {
            InitializeComponent();
        }

        private string name, password;
      

        public string Name
        {
            get { return name; } set {  name = value; }
        }

        public string Password
        {
            get { return password; } set { password = value; }
        }

        public string strong_password()
        {
            string password = txt_password.Text;
            int count = 0;
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
                        count += 1;
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
                return password;
            }
            else
            {
                password = null;
                return password;
            }
        }
        MySqlCommand cmd;
        Connect connect;

        private void llbl_already_account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_login frm_Login=new frm_login();
            this.Hide();
            frm_Login.Show();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            frm_sign_up frm_Sign_Up = new frm_sign_up();
            frm_Sign_Up.Name = txt_name.Text;
            frm_Sign_Up.Password = strong_password();

            connect = new Connect();
            cmd = new MySqlCommand();

           
            
            if (frm_Sign_Up.Password != null)
            {
                cmd = connect.conn.CreateCommand();
                cmd.CommandText = "insert into tbl_user_lists(user_name,password)" +
                    "values('" + frm_Sign_Up.Name + "','" + frm_Sign_Up.Password + "')";

                cmd.ExecuteNonQuery();
                connect.conn.Close();
                MessageBox.Show("registration success");
            }
            else
            {
                MessageBox.Show("failed");
            }
        }
    }
}

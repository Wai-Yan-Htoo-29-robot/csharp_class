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

namespace WindowsFormsApp1.simple_project
{
    public partial class frm_customers_login : Form
    {
        public frm_customers_login()
        {
            InitializeComponent();
        }
        Connect connect = new Connect();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;
        public string profile_name;

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool check=false;
            string name_email, password;
            name_email = txt_username_email.Text;
            password = txt_password.Text;
            profile_name = name_email;
            //select query
            cmd =connect.conn.CreateCommand();
            cmd.CommandText= "select name,email,password from user_info " +
                "where (name = '" + name_email+ "' or email = '"+name_email+"') and password = '"+password+"'";

            reader=cmd.ExecuteReader();
            //     true=data  false=no data
            while(reader.Read()) 
            {
                //MessageBox.Show($"{reader.GetValue(0)}{reader.GetValue(1)}{reader.GetValue(2)}");
                check = true;
            }
            
                if (check)
                {
                //MessageBox.Show("login success");
                this.Hide();
                frm_dash_board fdb = new frm_dash_board();
                fdb.ShowDialog();
                }
                else
                {
                    MessageBox.Show("invalid user");
                }  
           reader.Close();
        }
    }
}

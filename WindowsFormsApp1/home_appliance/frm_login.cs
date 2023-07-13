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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using WindowsFormsApp1.simple_project;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.ato;

namespace WindowsFormsApp1.home_appliance
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private string name, password;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        MySqlCommand cmd;
        Connect connect;
        MySqlDataReader reader;
        private void btn_login_Click(object sender, EventArgs e)
        {
            bool check=false;
            frm_login frm_Login = new frm_login();
            frm_Login.Name = txt_name.Text;
            frm_Login.Password =txt_password.Text;

            cmd= new MySqlCommand();
            connect = new Connect();

            cmd = connect.conn.CreateCommand();
     
            cmd.CommandText = "select user_name,password from tbl_user_lists " +
                "where user_name = '" + frm_Login.Name + "' and password = '" + frm_Login.Password + "'";

            reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                //MessageBox.Show($"{reader.GetValue(0)}{reader.GetValue(1)}{reader.GetValue(2)}");
                check = true;
            }

            if (check)
            {
                MessageBox.Show("login success");
                if(frm_Login.Name == "admin" && frm_Login.Password == "Admin1!@#")
                {
                    frm_admin_dashboard frm_Admin_Dashboard=new frm_admin_dashboard();
                    this.Hide();
                    frm_Admin_Dashboard.Show();
                }
                else
                {
                    frm_appliance_view frm_Appliance_View = new frm_appliance_view();
                    this.Hide();
                    frm_Appliance_View.Show();
                }
              
            }
            else
            {
                MessageBox.Show("invalid user");
            }
            reader.Close();
        }
    }
}

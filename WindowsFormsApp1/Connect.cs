using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Connect
    {
        //            class     obj
        public MySqlConnection conn;

        //constructor oop auto
        public Connect() 
        {
            //secure 
            string db_info = "server=localhost;port=3306;uid=root;pwd=;database=home_appliance";
            conn = new MySqlConnection(db_info);
            conn.Open();
            //MessageBox.Show("open");
        }
    }
}

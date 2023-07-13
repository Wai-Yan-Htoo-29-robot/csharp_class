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

namespace WindowsFormsApp1.home_appliance
{
    public partial class frm_admin_dashboard : Form
    {
        public frm_admin_dashboard()
        {
            InitializeComponent();
           
        }
        MySqlCommand command;
        Connect connect = new Connect();
        MySqlDataReader reader;

        private void btn_read_Click(object sender, EventArgs e)
        {
            connect = new Connect();

            string query = "select appliance_name,power_usage,typical_usage,estimated_annual_running_costs,weekly_costs,monthly_costs,description from tbl_appliance_lists";
            //  string query = "select * from instock where item_name LIKE '"+name+'%'+"' ";
            command = new MySqlCommand(query, connect.conn);
            reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                dg_appliance_lists.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6));
            }

            reader.Close();
            connect.conn.Close();
        }
    }
}

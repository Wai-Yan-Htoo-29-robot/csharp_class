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

namespace WindowsFormsApp1.ato
{
    public partial class frm_product_list : Form
    {
        public frm_product_list()
        {
            InitializeComponent();
        }
        Connect connect;
        MySqlCommand command;
        MySqlDataReader reader;
        private void btn_search_Click(object sender, EventArgs e)
        {
            string name= txt_product_code.Text;

            connect = new Connect();

            string query = "select item_name,item_type,quantity,item_suplier_price,item_buyer_price from instock where item_name  LIKE '"+name+'%'+"'";
          //  string query = "select * from instock where item_name LIKE '"+name+'%'+"' ";
            command = new MySqlCommand(query, connect.conn);
            reader = command.ExecuteReader();
            int list_of_item = 0;
            while (reader.Read())
            {
                list_of_item=1;
                  
               dg_product_list.Rows.Add(reader.GetValue(0),reader.GetValue(1),reader.GetValue(2),reader.GetValue(3),reader.GetValue(4));
            }

            if (list_of_item == 0)
            {
                MessageBox.Show("no item");
            }


            reader.Close();
            connect.conn.Close();
        }

        private void btn_item_clear_Click(object sender, EventArgs e)
        {
            dg_product_list.Rows.Clear();
        }
    }
}

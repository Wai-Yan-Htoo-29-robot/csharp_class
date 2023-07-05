using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ato
{
    public partial class frm_ato_shop : Form
    {
        public frm_ato_shop()
        {
            InitializeComponent();
        }

        Connect connect = new Connect();
        MySqlCommand command;
        MySqlDataReader reader;

        private void btn_search_Click(object sender, EventArgs e)
        {
            //item search by id
            int id;
            id =int.Parse( txt_item_id.Text);
            string query = "select * from instock where id = '"+id+"' ";
            
            command = new MySqlCommand(query,connect.conn);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                txt_item_quantity.Text = $"{reader.GetValue(3)}";
                MessageBox.Show(
                    $"{reader.GetValue(0)} " +
                    $"{reader.GetValue(1)} " +
                    $"{reader.GetValue(2)} " +
                    $"{reader.GetValue(3)} " +
                    $"{reader.GetValue(4)} " +
                    $"{reader.GetValue(5)}");
            }
            reader.Close();
            connect.conn.Close();
        }

        public void item_history()
        {
            float total;
            int quantity;
            quantity = int.Parse( txt_buyer_quantity.Text);
           
            float current_price;
            current_price = float.Parse( txt_current_price.Text);

            total = current_price * quantity;
            string staff_name, staff_pwd;
            staff_name = frm_login.name;
            staff_pwd = frm_login.password;
            connect = new Connect();
            command = new MySqlCommand();
            command = connect.conn.CreateCommand();
            command.CommandText = "insert into item_history(item_id,sales_person_name," +
                "sale_date,quantity,item_price,itme_total) " +
                "values('" + int.Parse(txt_item_id.Text) + "','" + staff_name + "','"+$"{DateTime.Today.ToString()}"+"','"+quantity+"'," +
                "'"+current_price+"','"+total+"')";
            command.ExecuteNonQuery();
            connect.conn.Close();
        }


        private void btn_print_Click(object sender, EventArgs e)
        {
            
            connect =new Connect();
            int buyer_quantity;
            int quantity;
            quantity = int.Parse(txt_item_quantity.Text);
            buyer_quantity = int.Parse(txt_buyer_quantity.Text);

            command = new MySqlCommand();
            command=connect.conn.CreateCommand();
            command.CommandText = "UPDATE instock SET quantity=" +
                "'"+$"{quantity-buyer_quantity}"+"' WHERE id = '"+int.Parse(txt_item_id.Text)+"'";
            command.ExecuteNonQuery();
            connect.conn.Close() ;

            item_history();
        }
    }
}

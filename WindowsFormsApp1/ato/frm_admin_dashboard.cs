using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ato
{
    public partial class frm_admin_dashboard : Form
    {
        public frm_admin_dashboard()
        {
            InitializeComponent();
        }
        //declare what we use
        Connect connect = new Connect();
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        public string fun_item_code()
        {
            connect=new Connect(); 
            string ic="";
            string query = "select item_code from instock";

            command = new MySqlCommand(query, connect.conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ic=reader.GetValue(0).ToString();
            }
            reader.Close();
            connect.conn.Close();
            return ic;
        }

        string name, type;
        int quantity,item_code;
        float suplier_price, buyer_price;



        private void btn_update_Click(object sender, EventArgs e)
        {
           
            type = txt_itme_type.Text;
            name = txt_item_name.Text;
            quantity = Convert.ToInt32( txt_qty.Text);
            suplier_price = float.Parse(txt_purchase_price.Text);
            buyer_price = float.Parse(txt_selling_price.Text);
            int item_code=Convert.ToInt32(txt_item_code.Text);

            dg_item_list.Rows.Add(name,type,quantity,suplier_price,buyer_price,item_code);

            connect = new Connect();
            command = new MySqlCommand();
            command = connect.conn.CreateCommand();
            command.CommandText = "UPDATE instock SET item_name = '"+name+"'," +
                "item_type = '"+type+"',item_suplier_price = '"+suplier_price+"',item_buyer_price='"+buyer_price+"'" +
                ",quantity=" +
                "'" + quantity + "' WHERE item_code = '" + item_code + "'";
            command.ExecuteNonQuery();
            connect.conn.Close();

            MessageBox.Show("updated");
        }

        //check item code and show value in text box
        private void btn_itemcode_Click(object sender, EventArgs e)
        {
            item_code = int.Parse( txt_item_code.Text);
            connect = new Connect();
            string ic = "";
            string query = "select * from instock where item_code = '"+item_code+"'";

            command = new MySqlCommand(query, connect.conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
              txt_item_name.Text = $"{reader.GetValue(1)}";
                txt_itme_type.Text = $"{reader.GetValue(2)}";
                txt_qty.Text= $"{reader.GetValue(3)}";
                txt_purchase_price.Text = $"{reader.GetValue(4)}";
                txt_selling_price.Text= $"{reader.GetValue(5)}";

            }
            reader.Close();
            connect.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_invoice fi=new frm_invoice();
            this.Hide();
            fi.Show();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {   
            item_code = Convert.ToInt32( fun_item_code()) + 1;
            txt_item_code.Text=item_code.ToString();
            connect=new Connect();
            
            name=txt_item_name.Text;
            type = txt_itme_type.Text;
            quantity = int.Parse(txt_qty.Text);
            suplier_price=float.Parse(txt_purchase_price.Text);
            buyer_price=float.Parse(txt_selling_price.Text);
            command = new MySqlCommand();
            command = connect.conn.CreateCommand();
            command.CommandText = "insert into instock(item_name,item_type,quantity,item_suplier_price,item_buyer_price,item_code) " +
                "values('" + name + "','" + type + "','" + quantity + "','" + suplier_price + "','" + buyer_price + "','" + item_code + "') ";
            command.ExecuteNonQuery();
            connect.conn.Close();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {

        }
    }
}

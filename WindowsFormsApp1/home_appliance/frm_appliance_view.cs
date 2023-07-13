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
using WindowsFormsApp1.kattis;

namespace WindowsFormsApp1.home_appliance
{
    public partial class frm_appliance_view : Form
    {
        public frm_appliance_view()
        {
            InitializeComponent();
        }
        private static string item_path_1;
        private static string item_path_2;
        Connect connect = new Connect();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;

        public static string test;
        
        public static string Item_Path_1
        {
            get { return item_path_1; }
            set { item_path_1 = value; }
        }

        public static string Item_Path_2
        {
            get { return item_path_2; }
            set { item_path_2 = value; }
        }
        string type;
        int column_counts=0;
        private void btn_search_Click(object sender, EventArgs e)
        {
            
            if (column_counts == 1)
            {
                dg_appliance_list.Rows.Clear();
                //dg_appliance_list.Columns.RemoveAt(4);
            }
           
            //DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //{
            //    button.Name = "btn_add_to_cart";
            //    button.HeaderText = "add to cart";
            //    button.Text = "Add to Cart";
            //    button.UseColumnTextForButtonValue = true; //dont forget this line
            //    this.dg_appliance_list.Columns.Add(button);
            //}
            connect = new Connect();
            type= txt_appliance_type.Text.ToLower();
            string query = "select appliance_name,power_usage,typical_usage,estimated_annual_running_costs from tbl_appliance_lists where appliance_name  LIKE '" + '%' + type + "'";
            //  string query = "select * from instock where item_name LIKE '"+name+'%'+"' ";
            command = new MySqlCommand(query, connect.conn);
            reader = command.ExecuteReader();
            int list_of_item = 0;
            while (reader.Read())
            {
                list_of_item = 1;

                dg_appliance_list.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
            }

            if (list_of_item == 0)
            {
                MessageBox.Show("no item");
            }


            reader.Close();
            connect.conn.Close();

            if (type == "tv")
            {
                pictureBox1.Controls.Clear();
                pictureBox2.Controls.Clear();
                pictureBox1.Image = Image.FromFile("LCD TV.jpg");
                pictureBox2.Image = Image.FromFile("toshibatv.jpg");
            }
            else if (type == "freezer")
            {
                pictureBox1.Controls.Clear();
                pictureBox1.Image = Image.FromFile("fridge_freezer.jpg");
                pictureBox2.Controls.Clear();
                pictureBox2.Image = Image.FromFile("freezer1.jpg");
            }
            column_counts = 1;
        }

      


        public static int count;
        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {
            if (type == "tv")
            {
                frm_appliance_view.Item_Path_1 = "LCD TV.jpg";
                test += "lcdtv,";
                MessageBox.Show("item added to cart");
            }
            else if (type == "freezer")
            {
                frm_appliance_view.Item_Path_1 = "fridge_freezer.jpg";
                test += "fridge_freezer,";
                MessageBox.Show("item added to cart");
            }
            count += 1;
           
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            frm_cart fc=new frm_cart();
            fc.Show();
        }

        private void btn_add_to_cart2_Click(object sender, EventArgs e)
        {
              if (type == "tv")
            {
                frm_appliance_view.Item_Path_2 = "toshibatv.jpg";
                test += "toshibatv,";
                MessageBox.Show("item added to cart");
            }
            else if(type =="freezer")
            {
                frm_appliance_view.Item_Path_2 = "freezer1.jpg";
                test += "freezer1,";
                MessageBox.Show("item added to cart");
            }
            count += 1;
        }




        private void dg_appliance_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;



namespace WindowsFormsApp1.ato
{
    public partial class frm_invoice : Form
    {
        public frm_invoice()
        {
            InitializeComponent();
        }

       Connect connect = new Connect();
        MySqlCommand command;
        MySqlDataReader reader;
        int no=1;
        private void frm_invoice_Load(object sender, EventArgs e)
        {
            txt_no.Text = no.ToString();
        }

       public int instock_product_quantity()
        {
            int instock_quantity=0;
            connect = new Connect();
            product_name =txt_product_name.Text;
            string query = "select quantity from instock where item_name = '"+product_name+"'";
           
            command = new MySqlCommand(query, connect.conn);
            reader = command.ExecuteReader();
           
            while (reader.Read())
            {
                instock_quantity= Convert.ToInt32(reader.GetValue(0));
            }
            reader.Close();
            connect.conn.Close();
            return instock_quantity;
        }

        public int instock_item_codes()
        {
            
            string name = txt_product_name.Text;
            int instock_item_code=0;
            connect = new Connect();

            string query = "select item_code from instock where item_name = '"+name+"'";
            //  string query = "select * from instock where item_name LIKE '"+name+'%'+"' ";
            command = new MySqlCommand(query, connect.conn);
            reader = command.ExecuteReader();
           
            while (reader.Read())
            {
                
                 instock_item_code= Convert.ToInt32(reader.GetValue(0));
            }
            reader.Close();
            connect.conn.Close();
            return instock_item_code;
        }


        private void btn_total_Click(object sender, EventArgs e)
        {
            int item_code=instock_item_codes();
            string product_name;
            float unit, total;
            int quantity;
            int instock_quantity=instock_product_quantity();
            
            product_name = txt_product_name.Text;
            unit = float.Parse(txt_unit.Text);
            quantity =int.Parse( txt_qty.Text);
            if (chk_out_of_item.Checked)
            {
                total = quantity * unit;
                dg_buyer_item.Rows.Add(no, product_name, unit, quantity, total);
            }
            else
            {
                if (instock_quantity >= quantity)
                {
                    total = quantity * unit;
                    txt_total.Text = total.ToString();
                    dg_buyer_item.Rows.Add(no, product_name, unit, quantity, total, item_code);
                    instock_update_item_quantity();
                    MessageBox.Show("data success");
                    no++;
                    txt_product_name.Clear();
                    txt_qty.Clear();
                    txt_unit.Clear();
                    txt_total.Clear();
                    txt_no.Text = no.ToString();
                }
                else
                {
                    MessageBox.Show("instock is not enough");
                }
            }

        }

        private void dg_buyer_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string product_name;
        int buyer_no,qty;
        float unit,total;

        public void item_history()
        {

            connect = new Connect();
            command = new MySqlCommand();
            command = connect.conn.CreateCommand();

            for (int i = 0; i < dg_buyer_item.Rows.Count - 1; i++)
            {
                buyer_no = Convert.ToInt32(dg_buyer_item.Rows[i].Cells["Column1"].Value);
                product_name = dg_buyer_item.Rows[i].Cells["Column2"].Value.ToString();
                qty = Convert.ToInt32(dg_buyer_item.Rows[i].Cells["Column4"].Value);
                unit = float.Parse(dg_buyer_item.Rows[i].Cells["Column3"].Value.ToString());
                total = float.Parse(dg_buyer_item.Rows[i].Cells["Column5"].Value.ToString());

                command.CommandText = "insert into item_history(item_id,sales_person_name," +
                "sale_date,item_name,quantity,item_price,itme_total) " +
                "values('" + buyer_no + "','" + frm_login.name + "','" + DateTime.Now.ToString() + "','" + product_name
                + "','" + qty + "','" + unit + "','" + total + "')";
                command.ExecuteNonQuery();
            }
           
            connect.conn.Close();
            MessageBox.Show("history update");
        }

        public void instock_update_item_quantity()
        {
            
            int buyer_quantity;
            int quantity;
            quantity = instock_product_quantity();
            buyer_quantity = int.Parse(txt_qty.Text);
            int item_code = instock_item_codes();
            connect = new Connect();
            command = new MySqlCommand();
            command = connect.conn.CreateCommand();
            command.CommandText = "UPDATE instock SET quantity=" +
                "'" + $"{quantity - buyer_quantity}" + "' WHERE item_code = '" +item_code+ "'";
            command.ExecuteNonQuery();
            connect.conn.Close();

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        void dgv_to_excel()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (i = 0; i <= dg_buyer_item.RowCount - 1; i++)
            {
                for (j = 0; j <= dg_buyer_item.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dg_buyer_item[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            xlWorkBook.SaveAs("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\invoice\\output.xlsx");
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("Excel file created , you can find the file C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\invoice\\output.xlsx");

            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Open("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\invoice\\output.xlsx");
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //app.Visible = false;
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;

            //int _offset = worksheet.UsedRange.Rows.Count;
            //for (int i = 0; i < dg_buyer_item.Rows.Count ; i++)
            //{
            //    for (int j = 0; j < dg_buyer_item.Columns.Count; j++)
            //    {
            //        if (dg_buyer_item.Rows[i].Cells[j].Value != null)
            //            worksheet.Cells[i + 2 + _offset, j + 1] = dg_buyer_item.Rows[i].Cells[j].Value.ToString();
            //        else
            //            worksheet.Cells[i + 2 + _offset, j + 1] = "";
            //    }
            //}
            //MessageBox.Show("exported");
            //workbook.Close(SaveChanges: true);
            //app.Quit();

            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Open("C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\invoice\\output.xlsx");
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Exported from gridview"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            //// storing header part in Excel  
            //for (int i = 1; i < dg_buyer_item.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = dg_buyer_item.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < dg_buyer_item.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < dg_buyer_item.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = dg_buyer_item.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.Save();//"C:\\Users\\DELL\\Desktop\\kbtc\\L4_DC\\OODCP\\firstproject\\csharp_class\\invoice\\output.xlsx");//, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //workbook.Close(SaveChanges: true);
            //MessageBox.Show("exported");
            //app.Quit();
        }


        private void btn_print_Click(object sender, EventArgs e)
        {
            item_history();
            //dgv_to_excel();
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog  
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
            dg_buyer_item.Rows.Clear();
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_admin_dashboard fad=new frm_admin_dashboard();
            this.Hide();
            fad.Show();
        }

        private void btn_product_list_Click(object sender, EventArgs e)
        {
            frm_product_list fpl=new frm_product_list();
            
            fpl.Show(); 
        }
    }
}

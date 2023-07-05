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
    public partial class frm_voucher_report : Form
    {
        public frm_voucher_report()
        {
            InitializeComponent();
        }

        private void frm_voucher_report_Load(object sender, EventArgs e)
        {
            MessageBox.Show("printed");
            frm_invoice frm_Invoice = new frm_invoice();
            string buyer_no,product_name,qty,unit,total;
            
            for (int i = 0; i < frm_Invoice.dg_buyer_item.Rows.Count - 1; i++)
            {
                buyer_no= frm_Invoice.dg_buyer_item.Rows[i].Cells["Column1"].Value.ToString();
                product_name = frm_Invoice.dg_buyer_item.Rows[i].Cells["Column2"].Value.ToString();
                qty = frm_Invoice.dg_buyer_item.Rows[i].Cells["Column4"].Value.ToString();
                unit = frm_Invoice.dg_buyer_item.Rows[i].Cells["Column3"].Value.ToString();
                total = frm_Invoice.dg_buyer_item.Rows[i].Cells["Column5"].Value.ToString();
                MessageBox.Show($"{buyer_no},{product_name},{qty},{unit},{total}");
               
            }
        }
    }
}

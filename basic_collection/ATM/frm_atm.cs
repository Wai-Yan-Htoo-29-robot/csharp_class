using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection.ATM
{
    public partial class frm_atm : Form
    {
        public frm_atm()
        {
            InitializeComponent();
        }

        int count = 0;
        public Account account=new Account();

        private void btn_7_Click(object sender, EventArgs e)
        {
            
            count++;
            if(count <= 4)
            {
                txt_userinput.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            
            count++;
            if (count <= 4)
            {
                txt_userinput.Text += "8";
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            if (txt_userinput.Text == "")
            {
                this.Close();
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_userinput.Text += "0";
            }
        }

        private void btn_A_Click(object sender, EventArgs e)
        {

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_userinput.Text += "3";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_userinput.Text += "2";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_userinput.Text += "1";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_userinput.Text += "6";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_userinput.Text += "5";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_userinput.Text += "4";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= 4)
            {
                txt_userinput.Text += "9";
            }
        }


        public static string pin,amount;

        private void btn_balance_Click(object sender, EventArgs e)
        {
            count = 0;
            account.acc1_setter("1234", "1000");
            account.acc2_setter("1111", "3000");


            if (txt_userinput.Text == account.acc1_pin_getter())
            {
                pin=txt_userinput.Text;
                amount=account.acc1_amount_getter();
                MessageBox.Show(account.acc1_amount_getter());
            }
            else if (txt_userinput.Text == account.acc2_pin_getter())
            {
                pin = txt_userinput.Text;
                amount = account.acc2_amount_getter();
                MessageBox.Show(account.acc2_amount_getter());
            }
            else
            {
                MessageBox.Show("enter pin");
            }
            txt_userinput.Text = "";
        }

        private void btn_withdraw_with_receipt_Click(object sender, EventArgs e)
        {
            float current_amount = float.Parse(txt_userinput.Text);

            if (current_amount <= float.Parse(amount))
            {
                amount = $"{float.Parse(amount) - current_amount}";
                MessageBox.Show($"withdraw amount : {current_amount}\nTotal Balance : {amount}");
            }
            else
            {
                MessageBox.Show("balance not enough");
            }
        }

        private void btn_deny_Click(object sender, EventArgs e)
        {
            txt_userinput.Text = "";
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            float current_amount = float.Parse(txt_userinput.Text);

            if (current_amount <= float.Parse(amount))
            {
                amount = $"{float.Parse(amount) - current_amount}";
                //MessageBox.Show($"withdraw amount : {current_amount}\nTotal Balance : {amount}");
            }
            else
            {
                MessageBox.Show("balance not enough");
            }

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection.ATM
{
    public class Account
    {
        //       pin/acc number    amount
        string[] acc1 = new string[2];
        string[] acc2 = new string[2];
        public Account() {
                    }
        public void acc1_setter(string pin, string amount)
        {
            acc1[0] = pin;
            acc1[1] = amount;
        }

        public string acc1_pin_getter()
        {
            return acc1[0];
        }
        public string acc1_amount_getter()
        {
            return acc1[1];
        }
        public void acc2_setter(string pin, string amount)
        {
            acc2[0] = pin;
            acc2[1] = amount;
        }

        public string acc2_pin_getter()
        {
            return acc2[0];
        }
        public string acc2_amount_getter()
        {
            return acc2[1];
        }
    }
}

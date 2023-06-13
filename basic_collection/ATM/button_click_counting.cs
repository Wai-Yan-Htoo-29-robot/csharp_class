using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace basic_collection.ATM
{
    public class button_click_counting
    {
        public static int count = 0;

        public button_click_counting() 
        { 
            count++;
        }
    }
}

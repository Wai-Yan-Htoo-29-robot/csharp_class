using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class child_class : parent_class //single inheritance
    {

        public override void person()
        {
            MessageBox.Show("child class");
        }
        private string condo;
        public string Condo
        {
            get { return condo; }
            set { condo = value; }
        }
    }
}

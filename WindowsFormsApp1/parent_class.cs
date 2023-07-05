using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class parent_class 
    {

       
        //member
        public int number1;
        public int number2;

        private string jade;

        public string Jade
        {
            get { return jade; }
            set { jade = value; }
        }

        public virtual void person()
        {
            MessageBox.Show("parent class");
        }
        //fucntion overloading
        public string person( string name )
        {
            return "";
        }

        public string person( string name,string nrc )
        {
            return "";
        }

    }
}

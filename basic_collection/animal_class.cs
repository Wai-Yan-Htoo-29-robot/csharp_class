using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection
{
    public class animal_class
    {

        //default constructor
        public animal_class() {
            MessageBox.Show("default constructor");
        }

        //parameterize constructor 
        //when we use
        public animal_class( string bird )
        {
            MessageBox.Show(bird);
        }

        public animal_class(string name,int age,string nrc, string dob, string address)
        {
            MessageBox.Show($"{name}{age}{nrc}{dob}{address}");
        } 


        // class member
        // variable
        string cat = "myou";
        
        string dog = "wote";
        string cow = "moo";

        //encapsulation get set
        //get method
        public string cat_getter()//  function
        {
            return cat;
        }
        //                       parameter / argument
        //post method
        public void cat_setter(string sound)//sound = "myou myou"
        {
            cat = sound;
            //cat = myou myou;
        }

        public string Dog
        {
            get { return dog; }
            set { dog = value; }
        }

        public string Cow
        {
            get { return cow; }
            set { cow = value; }
        }
      
    }
}

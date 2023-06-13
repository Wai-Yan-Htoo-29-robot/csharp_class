using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User 
    {
        //class member
        private string name="msi";
        //get set
        private int age;
        //get set
        private string email;
        //get set
        private string nrc;

        //data retrieve data assign
        //encapsulation (data type getter(return value)  data type setter(value assign))
        //data pass
        public string user_name_getter() 
        { 
            return name;
        }
        //data assign
       public void user_name_setter(string n)
        {
            name = n;
        }
    }
    //default class
    public class Program
    {
        static void Main(string[] args)
        {
          User user = new User();
          user.user_name_setter("Dell xps");
          Console.WriteLine(user.user_name_getter());

        }
    }
}
//what is oop?
//     datatype variable
//unit  class   obj
//ans : rules and regulations   
//(encapsulation ,data abstraction, inheritance, and
//polymorphism--> function overloading)




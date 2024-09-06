using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subproject
{
    public partial class partial_class
    {
        public string name { get; set; }
        public void display()
        {   
            Console.WriteLine("I am dispaly method of first partial part of Partial Class ");
            System.Console.WriteLine("Name: "+this.name);
        }

    }

    public partial class partial_class
    {
        public int age { get; set; }
        public void show()
        {
            Console.WriteLine("I am show method of first partial part of Partial Class ");
            System.Console.WriteLine("age: " + this.age);
        }

    }

}

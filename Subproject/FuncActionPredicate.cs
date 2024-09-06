using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Subproject
{
    //public delegate void Delnamee();
    //public delegate void Delnamee1(string name);
    public class FuncActionPredicate
    {
        //public string name { get; set; }
        //Delnamee delname = delegate () { Console.WriteLine("I am from delegate 1"); };
        //Delnamee1 delnamee1 = delegate (string name) { Console.WriteLine("I am from parameterised delegeate and parameter name is: "+name); };
        //public void display()
        //{

        //    delname();
        //    delnamee1(this.name);
        //}

        public static int Addnumbers(int param1, int param2)
        {
            return param1 + param2;
        }
        public static void Addnumbers1(int param1)
        {
            int result= param1;
        }
        public static bool checkvalue(int a)
        {
            return (a > 0)?true:false;
        }
    }
}

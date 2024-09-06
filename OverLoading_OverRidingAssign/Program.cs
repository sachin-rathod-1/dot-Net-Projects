using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading_OverRidingAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Overloading oao = new Overloading();





            Bank over = new hdfc();
            over.roi();

            over = new icici();
            over.roi();

            over = new axis();
            over.roi();





            Console.ReadLine();
        }
    }
}

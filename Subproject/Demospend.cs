using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subproject
{
    public class Demospend
    {
        public static int TotalB=0;
        static object _lock = new object();
        public void spendmoney(object Amount)
        {
            for(int i=0; i<(int)Amount; i++)
            {
                lock (_lock)
                {
                    TotalB -= 1;
                }
            }
            Console.WriteLine("Show Ballance after spending: "+TotalB);
        }
        public void SaveMonay(object Amount)
        {
            for (int i = 0; i < (int)Amount; i++)
            {
                lock(_lock)
                {
                    TotalB += 1;
                }
            }
            Console.WriteLine("Show Ballance after Saving: " + TotalB);
        }
        public void ShowB()
        {
            Console.WriteLine("Total Ballance is: " + TotalB);
        }
    }
}

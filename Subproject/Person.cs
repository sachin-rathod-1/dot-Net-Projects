using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Subproject
{
    public class Person
    {
        static int total_amount = 0;
        Object val=new object();
        public void spendmoney()
        {
            for(int i=0; i<10; i++)
            {
                Monitor.Enter(val);
                if(total_amount < 1000)
                {
                    Monitor.Wait(val);
                }
                total_amount -= 1000;
                Console.WriteLine("Money Spend 1000");
                Console.WriteLine("Total Amount in Vallet is: " + total_amount);
                Monitor.Exit(val);

            }

        }
        public void savemoney()
        {
            for (int i = 0; i < 10; i++)
            {
                Monitor.Enter(val);
                if (total_amount > 1000)
                {
                    Monitor.Pulse(val);
                }
                total_amount += 1000;
                Console.WriteLine("Money Saved 1000");
                Console.WriteLine("Total Amount in Vallet is: "+total_amount);
                Monitor.Exit(val);

            }

        }


    }
}

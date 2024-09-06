using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Subproject
{


   
    public class UseThreadingWithDep
    {
        double balance = 0;
        static object val=new object();
        public void Withdraw()
        {
            Console.WriteLine("New Thread started of withdraw method");
            for(int i=0; i<100; i++)
            {
                Monitor.Enter(val);
                if (balance < 100)
                {
                    Monitor.Wait(val);
                }
                    balance -= 100 ;
                    Console.WriteLine("Withdraw:{0}",balance);
                    Monitor.Exit(val);
                
            }
        }
        public void Deposite()
        {
            Console.WriteLine("New Thread started of Deposite method");
            for (int i = 0; i < 100; i++)
            {   
                    Monitor.Enter(val);
                if(balance > 100)
                {
                    Monitor.Pulse(val);
                }
                    balance += 100 ;
                    Console.WriteLine("Deposite:{0}",balance);
                    Monitor.Exit(val);
                
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subproject
{
    public class Wait_Await
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method 1");
                    //Do Something
                    Task.Delay(1000).Wait();
                }
            });
        }
        public static void Method2()
        {
            for(int i = 0;i< 100; i++)
            {
                Console.WriteLine("Method 2");
                Task.Delay(1000).Wait();
            }          
        }
    }
}

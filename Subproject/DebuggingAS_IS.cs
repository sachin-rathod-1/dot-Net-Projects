using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subproject
{
    public class DebuggingAS_IS
    {
        public void Triangle()
        {
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
        }
    }
}

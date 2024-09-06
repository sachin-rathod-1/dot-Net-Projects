using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subproject
{
    public class Lambda_Delegate
    {
        public delegate string Delname(string name);
        public Delname delname = massage;
        public static string massage(string name)
        {
            return name + "I am Delegate method";
        }

        public delegate string Delname1(string name);
        public Delname delname1 = (name) => name + "I am Delegate method1";

    }
}

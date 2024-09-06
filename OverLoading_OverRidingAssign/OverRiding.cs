using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading_OverRidingAssign
{

    abstract class Bank
    {
        string movie_type;
        public abstract void roi();
    }

    class hdfc : Bank
    {
        public override void roi()
        {
            Console.WriteLine("ROI for hdfc is 8%");
        }

    }

    class icici : Bank
    {
        public override void roi()
        {
            Console.WriteLine("ROI for icici is 8%");
        }
    }

    class axis : Bank
    {
        public override void roi()
        {
            Console.WriteLine("ROI for axis is 8%");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subproject
{
    public class Cube
    {
        public double length { get; set; }
        public double breadth { get; set; } 
        public double heigth { get; set; }

        public double getVolume()
        {
            return length*breadth*heigth;
        }
        
        public static Cube operator +(Cube A , Cube B)
        {
            Cube C=new Cube();
            C.length = A.length+B.length;
            C.breadth = A.breadth+B.breadth;
            C.heigth = A.heigth+B.heigth;
            return C;
        }

        public class OperatorOverLoading
        {

        }


    }
}

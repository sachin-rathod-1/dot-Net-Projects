using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Subproject
{
   
    public  class Movie
    {
        public delegate void Adipurush(string str);
        public event Adipurush adipurush = null;

        public void Director()
        {
            string[] movie_name = new string[] { "pushpa", "Phir hera Pheri", "Hero", "Martian-2" };
            for(int i=0; i<movie_name.Length;i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine("We are Releasing Adipurush Movie");
                string str = movie_name[i]+" Movie have been Relised ";
                adipurush(str);
            }

            
        }

        public void Prajin(string str)
        {
           
            Console.WriteLine("Hey Prajin!!! " + str);
        }

        public void Aditya(string str)
        {
            Console.WriteLine("Hey Aditya!!! " + str);
        }
        public void Vipul(string str)
        {
            Console.WriteLine("Hey Vipul!!! " + str);
        }
    }
}

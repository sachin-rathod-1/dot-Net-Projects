using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_LINQ_Queries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numberes = { 11, 24, 37, 49, 45, 62, 76, 88, 90, 101, 131, 112,786 };
            int SmallestNumber = Numberes.Min();
            Console.WriteLine("Smallest Number : "+Numberes.Min());
            Console.WriteLine("Smallest Even Number: "+Numberes.Where(n => n%2 == 0).Min());

            Console.WriteLine("Largest Number : " + Numberes.Max());
            Console.WriteLine("Largest Even Number: " + Numberes.Where(n => n % 2 == 0).Max());

            Console.WriteLine("Sum of all Numberes: "+Numberes.Sum());
            Console.WriteLine("Total Even Numberes : " + Numberes.Where(n => n % 2 == 0).Count());
            Console.WriteLine("Sum of all EvenNumberes: " + Numberes.Where(n => n%2 == 0).Sum());

            List<int> marks = new List<int> {11,12,13,14,15,16,17,18,19,20 };
            var result = marks
                .Select((num, index) => new { Number = num, Index = index })
                .Where(x => x.Number % 2 == 0)
                .Select(x => x.Index);

            foreach (var item in result)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }


 

            Console.ReadLine();
        }
    }
}

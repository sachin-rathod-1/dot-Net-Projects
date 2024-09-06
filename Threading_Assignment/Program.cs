using System;
using System.Threading;
using static Threading_Assignment.Threading;

/*
 Create a program which demostrate how to pass value to thread and how to retrieve value from thread.
 */
/*
 ANSWER:-
        In this program we are calculating finalbalance in credit card after provided months of EMI
 */
namespace Threading_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Initial Creditcard balance: ");
            int Initial_balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Total month of EMI: ");
            int EMIMonth = Convert.ToInt32(Console.ReadLine());
            EMICredit EMIMethod = FinalBalance;
            Threading EMI = new Threading(Initial_balance, EMIMonth, EMIMethod);
            Thread t1 = new Thread(EMI.CalculateEMI);
            t1.Start();


            Console.ReadLine();
        }
    }
}

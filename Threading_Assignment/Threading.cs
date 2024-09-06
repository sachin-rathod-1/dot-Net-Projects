using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_Assignment
{
    /*
     Create a program which demostrate how to pass value to thread and how to retrieve value from thread.
     */
    /*
     ANSWER:-
            In this program we are calculating finalbalance in credit card after provided months of EMI
     */


    public class Threading
        {
            public delegate void EMICredit(int EMImethod);
            static int Initial_balance;
            static int EMIMonth;
            EMICredit _eMIMethod;
            public Threading(int initial_balance, int _EMIMonth, EMICredit EMIMethod)
            {
                Initial_balance = initial_balance;
                EMIMonth = _EMIMonth;
                _eMIMethod = EMIMethod;
            }
            public void CalculateEMI()
            {
                int Shopping = 0;
                for (int i = EMIMonth; i >=0 ; i--)
                {
                Shopping += 10000;
                }
                int Finalsaving = Initial_balance - Shopping;
                _eMIMethod(Finalsaving);
            }

            public static void FinalBalance(int Finalsaving)
            {
                Console.WriteLine("Your Final CreditCard Balance is: " + Finalsaving);
            }
        }
}

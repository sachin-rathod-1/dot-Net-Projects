using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subproject
{
    public class FD
    {
        public delegate void FDCallback(int callbackmethod);
        static int Initial_Deposite;
        static int FD_month;
        FDCallback _callbackmethod;
        public FD(int initial_deposite, int fd_month, FDCallback callbackmethod)
        {
            Initial_Deposite = initial_deposite;
            FD_month = fd_month;
            _callbackmethod = callbackmethod;
        }
        public void CalculateSaving()
        {
        int Saving = 0;
        for(int i=0; i< FD_month; i++)
        {
            Saving += 100;
        }
        int TotalAmount = Saving + Initial_Deposite;
        _callbackmethod(TotalAmount);
        }

        public static void showSaving(int TotalAmount)
        {
            Console.WriteLine("Your Total Saving is: "+ TotalAmount);
        }
    }
}

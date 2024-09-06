using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subproject
{
    /*
     Write a program for customer class which has two type 1. Basic customer and Premium customer
    Customer class has discount method . If cutomer buy which 
    is worth of more than 10000 rupee 
    premium customer will get   10 % discount and 
    Basic customer get 5%.
    write the program to implement in program
     */
    public class Customer
    {
        public double BuyValue { get; set; }
        public double Discount { get; set; }
    }
    public class Basic_Cust : Customer
    {
        public Basic_Cust(double BuyValue)
        {
           this.BuyValue = BuyValue;
           if (BuyValue >= 1000)
            {
                Discount = BuyValue * 0.05;
            }
            else
            {
                Discount = 0;
            }
        }
    }
    public class Prime_Cust : Customer
    {
        public Prime_Cust(double BuyValue)
        {
            this.BuyValue = BuyValue;
            if (BuyValue >= 10000)
            {
                Discount = BuyValue * 0.05;
            }
            else
            {
                Discount = 0;
            }
        }
    }
    internal class SurpriseTest
    {
    }
}

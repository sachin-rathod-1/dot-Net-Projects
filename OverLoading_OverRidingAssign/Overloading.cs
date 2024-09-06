using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OverLoading_OverRidingAssign
{

    internal class Overloading
    {
        int price = 1000;
        public int total_bill
        {
            get; set;
        }
        int quantity, pin;
        string upi_id, name, password;
        public Overloading()
        {
            Console.WriteLine("Welcome to goggle store");
            Console.WriteLine("How many goggles u want to purchase");
            quantity = Convert.ToInt32(Console.ReadLine());
            total_bill = quantity * price;

            Console.WriteLine("Toatl Bill : " + total_bill);
            Console.WriteLine("Choose payment method");
            Console.WriteLine("Enter 1 : COD | 2 : UPI | 3 : NET BANKING");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("You have chosen COD");
                payment();
            }
            else if (choice == 2)
            {
                Console.WriteLine("You have chosen UPI payment");
                Console.WriteLine("Enter UPI PIN");
                pin = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter UPI ID");
                upi_id = Console.ReadLine();
                payment(pin, upi_id);
            }
            else if (choice == 3)
            {
                Console.WriteLine("You have chosen net banking");
                Console.WriteLine("Enter name");
                name = Console.ReadLine();

                Console.WriteLine("Enter password");
                password = Console.ReadLine();
                payment(name, password);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
        //OVERLOADED FOR COD
        public void payment()
        {
            Console.WriteLine("order placed");
        }

        //OVERLOADED FOR UPI
        public void payment(int pin, string upi_id)
        {
            int pin1 = 1234;
            string uid = "aditya";
            if (pin == pin1 && upi_id == uid)
            {
                paymentConfirmation();
                Console.WriteLine("order placed");
            }
            else
            {
                Console.WriteLine("invalid password or upi id");
            }
        }

        //OVERLOADED FOR NET BANKING
        public void payment(string name, string password)
        {
            string n = "aditya";
            string pass = "1234";
            if (name == n && pass == password)
            {
                paymentConfirmation();
                Console.WriteLine("order placed");
            }
            else
            {
                Console.WriteLine("invalid password");
            }
        }

        public void paymentConfirmation()
        {
            Console.WriteLine("Waiting for payment confirmation");
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine("Payment Succesful");
        }
    }
}

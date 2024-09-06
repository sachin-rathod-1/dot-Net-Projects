using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PubSub
{
    /*
  Q1.WAP to demostrate pub-sub pattern using delegate.Also explain need to event.
  */
    /*
     Answer: Event is needed to restrict the operation on delegete object. 
             After using Event Only subscribe or Unsubscribe operation can be done.
             A Subsciber Can't set Null value to the delegete.
             Here we are considering the example of college and student. principle will declare the Announcement and 
             only enrolled students will get Announcement. A perticular student can't set delegate value as 0.
     */
    public class PubSub
    {
        public delegate void College(string Announcement);
        public event College enroll = null;

        public void Principle()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine("**********************************************************************");
                Console.WriteLine("Principle is releasing Announcement: " + i);
                string Announcement = "Anouncement: " + i;
                enroll(Announcement);
            }
        }
        public void Vipul(string Announcement)
        {
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Hey Vipul Kindly Acknoledge " + Announcement);
        }
        public void Suraj(string Announcement)
        {
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Hey Suraj Kindly Acknoledge " + Announcement);
        }
        public void Chandan(string Announcement)
        {
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Hey Chandan Kindly Acknoledge " + Announcement);
        }
        public void Girish(string Announcement)
        {
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Hey Girish Kindly Acknoledge " + Announcement);
        }
        public void Rahul(string Announcement)
        {
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Hey Rahul Kindly Acknoledge " + Announcement);
        }
        public void Sachin(string Announcement)
        {
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Hey Sachin Kindly Acknoledge " + Announcement);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            PubSub q1= new PubSub();
            Thread t1 = new Thread(q1.Principle);
            t1.Start();
            q1.enroll += q1.Vipul;
            q1.enroll += q1.Rahul;
            q1.enroll += q1.Chandan;
            q1.enroll += q1.Suraj;
            q1.enroll += q1.Girish;
            q1.enroll += q1.Sachin;
        }
    }
}

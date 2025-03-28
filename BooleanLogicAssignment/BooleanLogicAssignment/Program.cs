using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            int customerAge = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool customerDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int CustomerSpeedingTickets = Convert.ToInt32(Console.ReadLine()); // Read the number of speeding tickets
            //Console.WriteLine(CustomerSpeedingTickets  + 1);
            Console.WriteLine("Qualified? \n " + (customerAge > 15 && customerDUI == false && CustomerSpeedingTickets <= 3));
           // Console.WriteLine(customerAge > 15 && customerDUI == false && CustomerSpeedingTickets <= 3);
        }
    }
}

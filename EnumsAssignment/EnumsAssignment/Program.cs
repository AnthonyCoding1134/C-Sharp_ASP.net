using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it today?");
            string dayOfWeek = Console.ReadLine();


            // Convert the string input to an enum value

            try
            {
                //string Day = Convert.ToString(Enum.Parse(typeof(Days), dayOfWeek));

                // Parse the input string into the Days enum type
                Days currentDay = (Days)Enum.Parse(typeof(Days), dayOfWeek, ignoreCase: true);
             

                if (Enum.IsDefined(typeof(Days), currentDay))
                {
                    Console.WriteLine($"The day of the week is: {currentDay}");
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }

                Console.WriteLine($"The day of the week is: {currentDay}");
            }
           

            catch (Exception)
            {
                Console.WriteLine($"You messed up");
            }



        }

     
    }

    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

}

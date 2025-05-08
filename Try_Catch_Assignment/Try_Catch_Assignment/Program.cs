using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //global variables and Console Output
            int currentYear = 2025;
            Console.WriteLine("What is your age?");
            int userAge;

           
            // Try block to calc year user was born
            try
            {

                //userAge = int.Parse(Console.ReadLine());
                //int.TryParse(Console.ReadLine(), out userAge);
                userAge = Convert.ToInt32(Console.ReadLine());  
                int yearBorn = currentYear - userAge;

                // Check if userAge is less than or equal to 0 and if so throw custom exception
                if (userAge <= 0)
                {
                    
                    throw new NegativeAge();
                }

               
                Console.WriteLine($"You were born in {yearBorn}");
            }


            // catch block to catch custom exception
            catch (NegativeAge)
            {
                Console.WriteLine("Age can't be zero or negative");
            }


            // catch block to catch any other exception
            catch (Exception)
            {
                Console.WriteLine("An error occured");
            }

         

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below");
            Console.WriteLine("Please enter the package weight in pounds:");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());
            if (packageWeight > 50)
            {
                // If the package is over 50 pounds, print a message and exit the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program

            }

            Console.WriteLine("Please enter the package width in inches:");
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package height in inches:");    
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());    
            
            Console.WriteLine("Please enter the package length in inches:");    
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());

            // Calculate the total dimensions of the package
            decimal packageTotalDimensions = packageWidth + packageHeight + packageLength;

            // Check if the total dimensions exceed 50 inches
            if (packageTotalDimensions > 50)
            {
                // If the total dimensions exceed 50 inches, print a message and exit the program
                Console.WriteLine("Package too large to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

           decimal quoteForShipping = packageWidth * packageLength * packageHeight * packageWeight / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quoteForShipping.ToString("0.00") + " \n Thank You!");


        }
    }
}

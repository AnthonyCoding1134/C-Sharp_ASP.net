using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("What ur name?");  
            string yourName = Console.ReadLine();   
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();*/

           /* Console.WriteLine("What is your favorite number?");
            // int favNum = Convert.ToInt32(Console.ReadLine());
            string favNum = Console.ReadLine();
            Console.WriteLine("Your favorite number is: " + favNum);
            int favoriteNumberThatCanBeAdded = Convert.ToInt32(favNum);
            int total = favoriteNumberThatCanBeAdded + 5;
            Console.WriteLine("Your fave number plus 5 is: " + total);
            Console.ReadLine();*/

            byte myByte = 25; // 0 to 255
            bool isStudying = false;
            sbyte currentTemp = -23;
            char randomLetter = 'A';
            char questionMark = '\u2103';
            Console.WriteLine(questionMark);

            decimal moneyInAcct = 1345.5m;
            double heightInCenimeters = 211.4443;
            float secondsLeft = 2.62f;
            short tempOnMArs = -341;

            int currentAge = 25;
            string yearsOld = currentAge.ToString();
            Console.WriteLine("I am " + yearsOld + " now");

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            string otherRainingStatus = isRaining.ToString();
            Console.WriteLine("It is " + otherRainingStatus + " it is raining now");
            Console.WriteLine("It is " + rainingStatus + " it is raining now");

            // Mathmatical Operators
            int num1 = 7;
            int num2 = 25;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2); 

            float num3 = 7.5f;
            float num4 = 2.8f;
            Console.WriteLine(num3 * num4);

            byte num5 = 36;
            byte num7 = 12;

           Console.WriteLine(num5 / num7);
            //Concatenation
            string playerFirstName = "Lebron";
            string playerLastName = "James";
            string playerFullNameNoSpace = playerFirstName + playerLastName;   
            Console.WriteLine(playerFullNameNoSpace);    


        }
    }
}

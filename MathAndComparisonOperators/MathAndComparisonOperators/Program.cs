using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            //  Console.WriteLine("Five plus 10 = " + total);
            Console.WriteLine("Five plus 10 = " + total.ToString());
          //  Console.ReadLine();

            int diff = 23 - 2;
            Console.WriteLine("23 minus 2 = " + diff.ToString());   

            int product = 10 * 5;
            Console.WriteLine("The product is " + product);

            int myQuotient = 24 / 3;
            Console.WriteLine("24 divided by 3 = " + myQuotient.ToString());

            double myQuotient2 = 100.0 / 16.0;
            Console.WriteLine(myQuotient2);  //6.25;

            int remainder = 10 % 2;
            //Console.WriteLine(remainder); //0   

            //int remainder2 = 11 % 2;
            //Console.WriteLine(remainder2); //1  

            //COMPARISON OPERATORS
            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse.ToString());


            int roomTemp = 70;
            int currentTemp = 71;

           //  bool isWarm = currentTemp >= roomTemp; 
           bool isWarm = currentTemp == roomTemp;   //eqUality operator (==)
            Console.WriteLine(isWarm);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class IntegerMethod
    {
        public int myIntegerMethod(int UserInt) 
        {
            UserInt *= 10;
            return UserInt;
        }

        public int myOverloadedMethod(int UserInt)
        {
            UserInt += 10;
            return UserInt;
        }

        public int myOverloadedMethod(int UserInt, int secondUserInt)
        {
            UserInt += secondUserInt;
            return UserInt;
        }

        public decimal myOverloadedMethod(decimal UserInt)
        {
            UserInt += 10.5m;
            return UserInt;
        }

        public int myStringMethod (string UserString)
        {
            // int newstring = Convert.ToInt32(UserString);
            //int newerString = newstring / 2;
            // return newerString;

            int newString  = Int32.Parse(UserString);
            newString *= 3;
            return newString;



            //bool isParsed = Int32.TryParse(UserString, out int parsedValue);
            //return isParsed ? (parsedValue * 4).ToString() : "Invalid input";

        }

        // This method is void and does not return a value

        public void VoidMethod(int UserInt)
        {
            UserInt -= 10;
            Console.WriteLine(UserInt);
        }


    }
}

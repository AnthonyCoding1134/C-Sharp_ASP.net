using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCT_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Number newNum = new Number() { Amount = 100.50m};
            //newNum.Amount = 100.50m;    
            

            Number newerNum = newNum; //creating a new instance of the struct
            newerNum.Amount = 200.75m;

            Console.WriteLine("The amount is: " + newNum.Amount);     //The amount is: 100.50 : because structs are value types the original instance is not changed

        }
    }

    struct Number   //creating Struct which is a value type
    {
        public decimal Amount { get; set; } 
    }
}

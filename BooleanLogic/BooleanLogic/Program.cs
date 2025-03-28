using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && false); // False
            Console.WriteLine(true || false); // True
            Console.WriteLine(true && true); // True        
            Console.WriteLine(false && false); // False 
            Console.WriteLine(true || true); // True    
            Console.WriteLine(false || false); // False 
            Console.WriteLine(!true); // False
            Console.WriteLine(true == true); // True
            Console.WriteLine(false == false); // True
            Console.WriteLine(true != true); // False  (bang operator)  
            Console.WriteLine(false != false); // False
            Console.WriteLine(true != false); // true

            Console.WriteLine(true ^ true); // False    (this is the XOR (exclusive OR) operator)   
            Console.WriteLine(true ^ false); // True    
            Console.WriteLine(false ^ false); // False



        }
    }
}

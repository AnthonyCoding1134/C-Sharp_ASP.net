using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You may enter a second number if you wish, or press enter to skip");
            string input = Console.ReadLine();

            MathOpsinDiffClassButSameNamespace newObject = new MathOpsinDiffClassButSameNamespace();

            if (int.TryParse(input, out int num2))
            {
                Console.WriteLine(newObject.TwoNumberOneOptional(num1, num2));
            }
            else
            {
                Console.WriteLine(newObject.TwoNumberOneOptional(num1));
            }
            
            newClass newClassObj = new newClass();
            newClassObj.DoSomethingElse(24, 4);
            newClassObj.DoSomethingElse(num1: 12, num2: 8);

            newObject.TwoNumberOneOptional(num1: 5, num2: 10);

        }
    }

    

    class newClass
    {
        public void DoSomethingElse(int num1, int num2)
        {
            Console.WriteLine(Math.Sqrt(num1));
            Console.WriteLine(num2);
        }
    }

    class MathOpsinDiffClassButSameNamespace
    {
      public int TwoNumberOneOptional(int num1, int num2 = 0)
        {
            return num1 + num2 + 100; 
        }
    }
}

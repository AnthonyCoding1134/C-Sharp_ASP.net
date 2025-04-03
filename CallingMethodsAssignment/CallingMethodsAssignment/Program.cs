using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
         static void Main(string[] args)

        {
            //MyClass a = new MyClass();
            Console.WriteLine("which number?");
            int usersNum = Convert.ToInt32(Console.ReadLine());

            //This is needed when static keyword id not used on the method
            IntegerReturn myObject = new IntegerReturn();

            Console.WriteLine(myObject.AddFiveToInt(usersNum));
            Console.WriteLine(IntegerReturn.Times6ToInt(usersNum));
            Console.WriteLine(IntegerReturn.SubtractTenFromInt(usersNum));
            Console.WriteLine(IntegerReturn.SquareRoot(usersNum));

        }
    }
}

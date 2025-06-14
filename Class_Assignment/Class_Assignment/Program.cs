using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int UsersAnswer =  Convert.ToInt32(Console.ReadLine());
            SeparateFromMainProgram newObject = new SeparateFromMainProgram();
            newObject.MethodInSeparateClass(UsersAnswer);
            int result;
            int anotherResult;
            newObject.MethodContainingOutKeyword(UsersAnswer, out result);
            newObject.MethodContainingOutKeyword(out anotherResult); 
            Console.WriteLine("The result is " + result);     //The result is 24
            Console.WriteLine("The result in the overloaded method is " + anotherResult);

            Console.WriteLine("Please enter a number to subtract from 100: ");
            int subtractorOfOneHundred = Convert.ToInt32(Console.ReadLine());

            StaticClass.StaticMethod(subtractorOfOneHundred);

          //  StaticClass staticObject = new StaticClass();   ***This dont work bc it's static!
        }
    }
    
     class SeparateFromMainProgram
    {
        public void MethodInSeparateClass(int usersupplied)
        {
            Console.WriteLine("The first method outcome is " + usersupplied / 2);
        }   


        public void MethodContainingOutKeyword(int usersupplied, out int result)
        {
            result = usersupplied * 2;
           // Console.WriteLine("The result is " + result);
            Console.WriteLine("The original number is " + usersupplied);


        }

        public void MethodContainingOutKeyword(out int anotherResult)
        {

            anotherResult =  5;
            anotherResult *= 3;
            


        }

     }

    public static class StaticClass
    {
        public static void StaticMethod(int subtractorOfOneHundred)
        {
            int answer = 100 - subtractorOfOneHundred;
            Console.WriteLine("This is a static method.  The answer is: " + answer);
        }


    }


}

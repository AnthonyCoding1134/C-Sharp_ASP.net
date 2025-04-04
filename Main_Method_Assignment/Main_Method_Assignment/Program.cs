using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            IntegerMethod myMethod = new IntegerMethod();
            // Console.WriteLine(myMethod);
            Console.WriteLine("Please enter a number: ");

            try
            {

                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(myMethod.myIntegerMethod(userInput));

                Console.WriteLine("The first overload is " + myMethod.myOverloadedMethod(3));
                Console.WriteLine("The second overload is " + myMethod.myOverloadedMethod(3, 5));

                Console.WriteLine("The decimal overload is " + myMethod.myOverloadedMethod(12.2m));

                //  Console.WriteLine("The string method is " + myMethod.myStringMethod("5")); 
                Console.WriteLine("the string method is " + myMethod.myStringMethod("5"));


                //try
                //{
                //    myMethod.VoidMethod(userInput);
                //    Console.WriteLine("Void method executed successfully.");
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("This is a void method");
                //}


                myMethod.VoidMethod(25);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Thank you for using the program.");
            }
        }
    }
}
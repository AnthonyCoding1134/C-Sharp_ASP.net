using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lets divide the 2 numbers");
            //int result = num1 / num2;
            //Console.WriteLine("The result is: " + result);

            //try
            //{
            //    Console.WriteLine("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Lets divide the 2 numbers");
            //    int result = num1 / num2;
            //    Console.WriteLine("The result is: " + result);
            //}

            //catch (FormatException ex)   //FormatException would be string instead of int
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("Type a number");
            //    return;
            //}

            //catch (DivideByZeroException ex)
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //catch (Exception ex)    //general exception
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally         //finally block will always run regardless of the result. typically used to log error to database
            //{
            //    Console.WriteLine("This is the finally block");
            //}

       



            try
            {
                List<int> crazyNums = new List<int>() { 30, 25, 100, 12, 45 };
                Console.WriteLine("Enter a number to divide by: ");
                int userNum = Convert.ToInt32(Console.ReadLine());

                foreach (int num in crazyNums)
                {
                    Console.WriteLine(num + " divided by " + userNum + " equals " + num / userNum);
                }

            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please type an actual number");
                

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("This is for any generic error messages");
            }
            finally
            {
                Console.WriteLine("This is the finally block- the program has emerged from any errors and reached the end of execution");

            }






            }

    }

}

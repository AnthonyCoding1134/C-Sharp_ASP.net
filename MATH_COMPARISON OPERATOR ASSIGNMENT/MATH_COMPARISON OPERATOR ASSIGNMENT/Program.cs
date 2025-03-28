using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATH_COMPARISON_OPERATOR_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please provide the hourly rate:"); 
            double personOneHourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please provide the hours worked per week:");
            int personOneHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Please provide the hourly rate:");
            double personTwoHourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please provide the hours worked per week:");
            int personTwoHours = Convert.ToInt32(Console.ReadLine());

            double personOneAnnualSalary = personOneHourlyRate * personOneHours * 52;
            Console.WriteLine("Annual Salary of Person1:\n" + personOneAnnualSalary);   

            double personTwoAnnualSalary = personTwoHourlyRate * personTwoHours * 52;
            Console.WriteLine("Annual Salary of Person2:\n" + personTwoAnnualSalary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            //Console.WriteLine(personOneAnnualSalary > personTwoAnnualSalary);    //different way to do the same thing 
            bool doesPerson1MakeMore = personOneAnnualSalary > personTwoAnnualSalary;   
            Console.WriteLine(doesPerson1MakeMore);


        }
    }
}

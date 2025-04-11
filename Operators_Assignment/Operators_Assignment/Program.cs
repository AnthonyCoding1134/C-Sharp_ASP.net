using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Id = 2323413;
            employee1.FirstName = "John";
            employee1.LastName = "Doe";

            Employee employee2 = new Employee();
            employee2.Id = 2323413;
            employee2.FirstName = "Jane";
            employee2.LastName = "Smith";

            Employee employee3;
            Employee employee4;
            employee3 = null;
            employee4 = null;   
            var employee5 = new Employee { Id = 4443447, FirstName = "Ant", LastName = "Doe" };

            var employees = new HashSet<Employee>();

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);   



            Console.WriteLine($" The example with two employees: {employee1 == employee2}"); // This will call the overloaded == operator
            Console.WriteLine($" The inverse of above is:  {employee1 != employee2}"); 
            Console.WriteLine($"The example with one null:  {employee3 == employee5}" );

            // This will call the overridden Equals method
            Console.WriteLine($"Here is using the Equals method with 2 employees: {employee1.Equals(employee2)}");

            Console.WriteLine($"And here we count how many unique employee id's: {employees.Count}");





        }
    }
}

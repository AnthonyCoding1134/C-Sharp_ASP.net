using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { Id = 1, FName = "John", LName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FName = "Joe", LName = "Smith" };
            Employee employee3 = new Employee { Id = 3, FName = "Joe", LName = "Dirt" };
            Employee employee4 = new Employee { Id = 4, FName = "Jane", LName = "Something" };
            Employee employee5 = new Employee { Id = 5, FName = "Tanya", LName = "Who" };
            Employee employee6 = new Employee { Id = 6, FName = "Sara", LName = "Smith" };
            Employee employee7 = new Employee { Id = 7, FName = "Lisa", LName = "Loeb" };
            Employee employee8 = new Employee { Id = 8, FName = "Paul", LName = "Levesque" };
            Employee employee9 = new Employee { Id = 9, FName = "John", LName = "Cena" };
            Employee employee10 = new Employee { Id = 10, FName = "Fred", LName = "Himself" };
            Employee employee11 = new Employee { Id = 11, FName = "Charlotte", LName = "Flair" };

            
            List<Employee> employees = new List<Employee> {
                employee1, employee2, employee3, employee4, employee5, 
                employee6, employee7, employee8, employee9, employee10, employee11 };

            /*  **Using foreach loop to make list of all employees with the first name Joe**
            List<Employee> guysNameJoe = new List<Employee>();

           
            foreach (var employee in employees)
            {
               if(employee.FName == "Joe")
                {
                    guysNameJoe.Add(employee);
                    Console.WriteLine($"Another Joe: {employee.FName} {employee.LName}");
                }
                
            }
            Console.WriteLine($"Total Joes: {guysNameJoe.Count}");
            */

            // Using Lambda  to make list of all employees with the first name Joe
            List<Employee> guyNameJoeLambdaStyle = employees.Where(x => x.FName == "Joe").ToList();
            Console.WriteLine($"Total Joes: {guyNameJoeLambdaStyle.Count}");

            // Using Lamba to create list of employees with id greater than 5
            List<Employee> idGreaterThanFive = employees.Where(y => y.Id > 5).ToList();
            foreach (Employee emp in idGreaterThanFive)
            {
                Console.WriteLine($"Another employee with id greater than 5: {emp.FName}- " +
                    $"who has an id of {emp.Id}");
            }

        }

    }
    
    class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
    }
}



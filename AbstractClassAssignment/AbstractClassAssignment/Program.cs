using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ***This causes an error****
            //  Person person = new Person();   

            Employee<String> employee = new Employee<String>();   
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.sayName();
            employee.Quit();
            employee.things.Add("work");
            employee.things.Add("personal");  
            //Console.WriteLine("The employee has {0} things", employee.things.Count);    
            //using polymprhism to create object of type iquittable
            // IQuittable disgruntledEmployee = new Employee();

            Employee<int> employee2 = new Employee<int>();
            employee2.firstName = "Bob";
            employee2.lastName = "Smith";
            employee2.sayName();
            employee2.things.Add(7);
            employee2.things.Add(28);
            employee2.things.Add(3);
            //  Console.WriteLine("The employee has {0} things", employee2.things.Count);


            //print all the things in the list with a loop
            for (int i = 0; i < employee.things.Count; i++)
            {
                Console.WriteLine("The firstemployee has {0} things", employee.things[i]);


            }

           for (int j = 0; j < employee2.things.Count; j++)
            {
                    Console.WriteLine("The second employee has {0} things", employee2.things[j]);
            }

           



        }
    }
}

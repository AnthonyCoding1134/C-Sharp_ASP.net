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

            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.sayName();
        }
    }
}

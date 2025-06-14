using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_OBJECTS_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Person smallPerson = new Person();    // instansiating the Person class
            smallPerson.FirstName = "Bob";
            smallPerson.LastName = "Smith"; 
            smallPerson.SayName(); 

            Employee employeeOne = new Employee();   
            employeeOne.FirstName = "Sample";
            employeeOne.LastName = "Student";
            employeeOne.Id = 24341; 
            employeeOne.SayName();      //calling the superclass method
        }
    }
}

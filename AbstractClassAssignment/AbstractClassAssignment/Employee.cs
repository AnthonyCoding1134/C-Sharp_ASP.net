using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Employee class inherits from Person- which is an abstract class.  It implements the IQuittable interface (meaning it must provide it's own version of it)
   public class Employee<T> : Person, IQuittable
    {
        public override void sayName()
        {
            Console.WriteLine("Hello {0} {1}, please report to your station", firstName, lastName);
        }



        public void Quit()
        {
            Console.WriteLine("I quitt!");
        }

        public List<T> things { get; set; } = new List<T>();

        List<Employee<T>> allEmployees = new List<Employee<T>>();

    }
  
  

       
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }


        //***Operator Overloading: == must have a corresponding != operator

        //***First we overload the == operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            //return employee1.Id == employee2.Id;

            // ***If both are null or both are same intance return true
            if(ReferenceEquals(employee1, employee2))
            {
                
                return true;
            }

            //***If one is null return false
            if (employee1 is null || employee2 is null)
            {
                  
                return false;
            }

            //***Compare based on Id
            return employee1.Id == employee2.Id;



        }

        // Overload the != operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }


        //Override Equals: if the incoming obj is an Employee, compare it using our overloaded ==.
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return this == other;
            }
            return false;
        }

        // Override GetHashCode
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }



    }


}
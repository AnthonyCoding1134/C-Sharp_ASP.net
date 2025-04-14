using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
   public abstract class Person
    {
      public string firstName { get; set; }
       public string lastName { get; set; }

        public virtual void sayName()
        {
            Console.WriteLine("Hello {0} {1}", firstName, lastName);    
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_OBJECTS_ASSIGNMENT
{
    class Person
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; } 

        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}" , FirstName, LastName);
        }

    }
}

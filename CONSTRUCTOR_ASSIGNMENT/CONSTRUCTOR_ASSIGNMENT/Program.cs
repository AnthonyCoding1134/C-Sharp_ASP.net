using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_ASSIGNMENT
{
    class Program
    {
         static void Main(string[] args)
        {
            
            string logFilePath = @"C:\Code_Logs\ConstructorChainingLog.txt";
            Person firstPerson = new Person();
            Person secondPerson = new Person("Antonio");
            Person thirdPerson = new Person("Alice", "Admin");
            File.WriteAllText(logFilePath, thirdPerson.username + " has been granted access as an " + thirdPerson.role);
           // Guid newIdentifier = Guid.NewGuid();

        }

       public class Person
        {
           const string species = "human";
           public string username { get; set; }   
           public string role { get; set; }
          // public string Id { get; set; }   



            // Creating default constructor that runs when no parameters are passed  
            public Person() : this("User123")
            {

            }

            // Creating constructor that runs when one parameter is passed  
            public Person(string name) : this(name, "standard user")
            {

            }

            // Creating constructor that runs when two parameters are passed  
            public Person(string name, string role)
            {
                this.username = name;
                this.role = role;
               
                Console.WriteLine("A new {2} has been granted access named {0} who is a(n) {1}", name, role, species);
               // Person.Id = Guid.NewGuid(); // Assigning a new unique identifier to the person
                //using Streamwriter to append to the log file
                using (StreamWriter file = new StreamWriter(@"C:\Code_Logs\ConstructorChainingLog2.txt", true))
                {
                    file.WriteLine("A new {2} has been granted access named {0} who has the role of: {1}", name, role, species);
                    file.WriteLine("Unique Identifier: {0}", Guid.NewGuid());
                }
                
            }


        }
    }

}


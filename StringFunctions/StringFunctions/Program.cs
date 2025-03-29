using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ant";
            string quote = "The man said, \"Hello\", Ant.  \n Hello on new line";
            string quote2 = "The man said, \\Hello\", Ant I am showing backslashes here";
            string fileName = @"C:\\Users\\Anthony";  

            bool trueORFalse = name.Contains("n");  
            bool trueORFalse2 = name.EndsWith("t");
            int length = name.Length;
            string bigName = name.ToUpper();    
            string littleName = name.ToLower(); 

            Console.WriteLine(quote);
            Console.WriteLine(quote2);
            Console.WriteLine(fileName);
            Console.WriteLine(trueORFalse);
            Console.WriteLine(trueORFalse2);
            Console.WriteLine(length);
            Console.WriteLine(bigName);
            Console.WriteLine(littleName);

            // string builder:  Can expand string without creating new string.  better performance
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Ant");
          
            Console.WriteLine(sb);  

            string myWeirdString = "This class is too easy so far"; 
           string beingBlunt =  myWeirdString.ToUpper(); 
            Console.WriteLine(beingBlunt);
          

            int numberofTries = 2;
            string name2 = "Wayne";
            string waynesDay = "not too bad";

            string cincatenatedSentence = name2 + "'s day was " + waynesDay + ", he tried " + numberofTries + " times to learn to code";    
            Console.WriteLine(cincatenatedSentence);

            StringBuilder sb2 = new StringBuilder();

            sb2.Append("My name is Ant");
            sb2.Append(" I came to learn to code and chew bubble gum");
            sb2.Append(" and I'm all out of bubble gum");    
            Console.WriteLine(sb2);



        }
    }
}

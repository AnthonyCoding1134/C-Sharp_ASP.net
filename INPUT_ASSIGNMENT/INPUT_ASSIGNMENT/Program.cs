using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Extensions.Logging;
using System.IO;


namespace INPUT_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter myLogFileWriter = new StreamWriter(@"C:\Code_Logs\log3.txt", append: true))   //appending the number to log file using StreamWriter
            {

                myLogFileWriter.Write(userNumber);
               

            }
            
            string numberToBeRead = File.ReadAllText(@"C:\Code_Logs\log3.txt");     //Reading the text using File class in System.IO namespace
            Console.WriteLine(numberToBeRead);

            Console.WriteLine("Now provide a word");
            string providedWord = Console.ReadLine();
            
            string path = @"C:\Code_Logs\log4.txt";
            File.WriteAllText(path, providedWord);
            


        }  
    }
}

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

            DateTime currentDate =  DateTime.Now;
            Console.WriteLine(currentDate);

            Console.WriteLine("Please provide a number that will be used for hours");

            //Converting input to a double for calculating future time
            double userInput = Convert.ToDouble(Console.ReadLine());

            // Using DateTime.Now.AddHours to calculate future time based on user input
            Console.WriteLine($"In {userInput} hours, the time will be:  {DateTime.Now.AddHours(userInput)}");

            Console.WriteLine("Please provide a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());


            //Appending the number to log file using StreamWriter
            using (StreamWriter myLogFileWriter = new StreamWriter(@"C:\Code_Logs\log3.txt", append: true))   //appending the number to log file using StreamWriter
            {

                myLogFileWriter.Write(userNumber);
               

            }

            //Reading the text from the log file then display in Console
            string numberToBeRead = File.ReadAllText(@"C:\Code_Logs\log3.txt");     //Reading the text using File class in System.IO namespace
            Console.WriteLine(numberToBeRead);


            //Getting console inout and assigning to variable
            Console.WriteLine("Now provide a word");
            string providedWord = Console.ReadLine();

            // Assigning path to variable & writing previous variable to log file
            string path = @"C:\Code_Logs\log4.txt";
            File.WriteAllText(path, providedWord);


            


        }  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IntroBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFaveHobby = "reading"; // Change this to your favorite hobby   

            if (myFaveHobby == "sports")
            {
                Console.WriteLine("That's a great way to stay active and have fun!");
            }
            else if (myFaveHobby == "video games")
            {
                Console.WriteLine("Video games can be a fun way to relax and unwind.");
            }
            else if (myFaveHobby == "reading")
            {
                Console.WriteLine("Reading is a wonderful way to explore new worlds and ideas.");
            }
            else
            {
                Console.WriteLine("So what do you do?");
            }

            int numOfShirts = 7;

            if (numOfShirts != 3)
            {
                Console.WriteLine("You have a different number of shirts than I do.");  
            }

            if (numOfShirts >= 7)
            {
                Console.WriteLine("That's enough shirts for each day of the week!");
            }


             int age = 17;

            if (age >= 18)
            {
                Console.WriteLine("YOu can join the armed forces if you want to serve your country.");  

            }
            else
            {
                Console.WriteLine("You can't join yet");
            }

            //Ternary Operator

            int daysTillMove = 58;

            string mustPayCharge = daysTillMove >= 60? "You must pay the charge." : "You do not have to pay the charge."; 
            Console.WriteLine(mustPayCharge);

            // Switch 
            // string dayOfTheWeek = "Tuesday"; // Change this to test different days
            /*  switch (dayOfTheWeek)
              {
                  case "Friday":
                      Console.WriteLine("It's Friday! The weekend is almost here.");
                      break;

                  case "Saturday":
                      Console.WriteLine("It's Saturday! Enjoy your weekend.");
                      break;

                  case "Sunday":
                      Console.WriteLine("It's Sunday! The weekend is almost over.");
                      break;

                  default:
                      Console.WriteLine("It's a weekday. Time to work!");
                      break;
              }
           

            Console.WriteLine("Guess a number");
            int chosenNumber = Convert.ToInt32(Console.ReadLine());

            // bool isGuessed = false;
            bool isGuessed = chosenNumber == 3;
            // while(isGuessed == false)

            do
            {
                switch (chosenNumber)
                {
                    case 1:
                        Console.WriteLine("You guessed one- try again!");
                        Console.WriteLine("Guess a number");
                        chosenNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed two-try again!!");
                        Console.WriteLine("Guess a number");
                        chosenNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed three- CORRECT!");
                        isGuessed = true; // Set the flag to true to exit the loop
                        break;
                    case 4:
                        Console.WriteLine("You guessed four try again!!");
                        Console.WriteLine("Guess a number");
                        chosenNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("That's not the number I was thinking of.");
                        Console.WriteLine("Guess a number");
                        chosenNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);
           */
            /*
             int numofCountries = 195;
             Console.WriteLine("How many countries have you visited?");
             int countriesVisited = Convert.ToInt32(Console.ReadLine());
             bool isGuessed = countriesVisited == 195;   

             do
             {

                 switch (countriesVisited)
                 {
                     case 0:
                         Console.WriteLine("You better get started- there's a whole world out there to explore!");
                         Console.WriteLine("How many countries have you visited?");
                         countriesVisited = Convert.ToInt32(Console.ReadLine());
                         break;

                     case 1:
                         Console.WriteLine("That's a start! You have visited 1 country.  You have another " + (numofCountries - countriesVisited) + " to go!");
                         Console.WriteLine("How many countries have you visited?");
                         countriesVisited = Convert.ToInt32(Console.ReadLine());
                         break;

                     case 2:
                         Console.WriteLine("That's good. You have visited 2 countries.  You have another " + (numofCountries - countriesVisited) + " to go!");
                         Console.WriteLine("How many countries have you visited?");
                         countriesVisited = Convert.ToInt32(Console.ReadLine());
                         break;

                     case 3:
                         Console.WriteLine("That's great! You have visited 3 countries.  You have another " + (numofCountries - countriesVisited) + " to go!");
                         Console.WriteLine("How many countries have you visited?");
                         countriesVisited = Convert.ToInt32(Console.ReadLine());
                         break;

                     case 195:
                         Console.WriteLine("Incredible! You have visited every country in the world- you win!");
                         isGuessed = true;   
                         break;

                     default:
                         Console.WriteLine("Whoa look at you world traveler!");
                         Console.WriteLine("How many countries have you visited?");
                         countriesVisited = Convert.ToInt32(Console.ReadLine());
                         break;
                 }
             }


             while (isGuessed == false);
             


            int numofComputersFixed = 0;
            while (numofComputersFixed < 5) 
            {

                Console.WriteLine("You have fixed " + numofComputersFixed + " computers.");
                numofComputersFixed++;

            }

        */
            Console.WriteLine("How much RAM do you have in your computer?");
            int amountOfRaminGB = Convert.ToInt32(Console.ReadLine());
            bool enoughMemory = amountOfRaminGB == 128;

            do
            {
                switch (amountOfRaminGB)
                {
                    case 0:
                        Console.WriteLine("You need to get more RAM!");
                        Console.WriteLine("How much RAM do you have in your computer?");
                        amountOfRaminGB = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("You can do very basic word processing");
                        Console.WriteLine("How much RAM do you have in your computer?");
                        amountOfRaminGB = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("You can do basic word processing and web browsing");
                        Console.WriteLine("How much RAM do you have in your computer?");
                        amountOfRaminGB = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 16:
                        Console.WriteLine("You can do basic word processing, web browsing, and some light gaming");
                        Console.WriteLine("How much RAM do you have in your computer?");
                        amountOfRaminGB = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 32:
                        Console.WriteLine("You can do basic word processing, web browsing, light gaming, and some video editing");
                        Console.WriteLine("How much RAM do you have in your computer?");
                        amountOfRaminGB = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 64:
                        Console.WriteLine("You can do basic word processing, web browsing, light gaming, video editing, and some 3D rendering");
                        Console.WriteLine("How much RAM do you have in your computer?");
                        amountOfRaminGB = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 128:
                        Console.WriteLine("You can do basic word processing, web browsing, light gaming, video editing, 3D rendering, and some machine learning");
                       // amountOfRaminGB = Convert.ToInt32(Console.ReadLine());
                        enoughMemory = true;   
                        break;

                    default:
                        Console.WriteLine("That is not a recognized configuration");
                        Console.WriteLine("How much RAM do you have in your computer?");
                        amountOfRaminGB = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!enoughMemory);
           
            
           


        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//enabling logging
using System.IO;
using Casino;   
using Casino.TwentyOne;


namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {



            // This illustrates how to use DateTime and TimeSpan in C#
            /*
            DateTime myDOB = new DateTime(1995, 5, 17, 7, 03, 17);
            DateTime gradDate = new DateTime(2017, 5, 17, 7, 03, 17);   
            
            TimeSpan numDaysSinceGraduation = gradDate - myDOB;

            //string textToBeWrote = "Here is some text";
            // File.WriteAllText(path: @"C:\Code_Logs\log.txt", textToBeWrote);
            // string textToBeRead = File.ReadAllText(path: @"C:\Code_Logs\log.txt");
            */

            //Using var to implicitly declare a variable- simpler but risky if data type is in question
           // var newPlayer = new Player("Anthony");
          

            const string casinoName = "Anthony's Casino";

           // Guid myIdentifier = Guid.NewGuid();


            Console.WriteLine("Welcome to {0}! Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();


            bool validAnswer = false;
            int bank = 0;


            while (!validAnswer)
            {
                Console.WriteLine("Hi {0}, much money did you bring today?", playerName);
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer)
                {
                    Console.WriteLine("Digits only!");
                }

            }

           
            Console.WriteLine("Well {0}, would you like to play some blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yup" || answer == "you damn right" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Code_Logs\log2.txt", true))
                {
                    file.WriteLine(player.Id);
                   
                }

                //polymorphism allows us to run TwentyOneGame's version of  Game's Play() bc it overrides it
                Game game = new TwentyOneGame();
               // game += player;
               game.Players.Add(player);
                player.isActivelyPlaying = true;
       
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();  //wrapping the main part of the game in a try-catch block to handle exceptions
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security!!! You have been caught cheating! You are banned from the casino.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact support.");
                        Console.ReadLine();
                        return;
                    }
                   
                }

                game.Players.Remove(player);
                Console.WriteLine("Thank you for playing!");

            }
            else
            {
                Console.WriteLine("You emit a foul and unpleasant odor");
                return;


            }

           


    }
    }

}

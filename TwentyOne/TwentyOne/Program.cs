using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//enabling logging
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDOB = new DateTime(1995, 5, 17, 7, 03, 17);
            DateTime gradDate = new DateTime(2017, 5, 17, 7, 03, 17);   
            
            TimeSpan numDaysSinceGraduation = gradDate - myDOB;

            //string textToBeWrote = "Here is some text";
            // File.WriteAllText(path: @"C:\Code_Logs\log.txt", textToBeWrote);
            // string textToBeRead = File.ReadAllText(path: @"C:\Code_Logs\log.txt");



            Console.WriteLine("Welcome to Anthony's Casino!  Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("Hi {0}, much money did you bring today?", playerName);   
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Well {0}, would you like to play some blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yup" || answer == "you damn right" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                //polymorphism allows us to run TwentyOneGame's version of  Game's Play() bc it overrides it
                Game game = new TwentyOneGame();
               // game += player;
               game.Players.Add(player);
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Anthony's Casino!  Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");   
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello {0}, would you like to play some blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes"|| answer == "yup" || answer == "you damn right" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();  //polymorphism allows us to use more operators (perhaps from both classes)
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }

                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("You emit a foul and unpleasant odor");
            Console.Read();






        }
    }

}

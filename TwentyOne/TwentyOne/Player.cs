using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //we can make Hand generic (Ex: it could be dice) by passing in <T> to the class
    public class Player
    {
        //constructor
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;

        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }

        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount) // Property to hold the bet amount    
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough money to make this bet.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }


// Operator overloading: allows us to use the + operator to add a player to a game
public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;

        }

      



    }
}

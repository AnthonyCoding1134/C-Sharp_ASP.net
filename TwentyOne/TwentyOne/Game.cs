using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // Abstract class: cannot be instantiated, but can be inherited (Base class)    
  public abstract class Game
    //public class Game
    {
        // Property thats common to all games
        //  public List<string> Players { get; set; }
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; } // Dictionary to hold player and bet amount


        // **** ABSTRACT METHOD - no implementation ****  TwentyOneGame must implement this method inherited from Game
        public abstract void Play();

        // Virtual: can be overridden in derived classes, but does not have to be.  This is a concrete method.
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

      
    }
}

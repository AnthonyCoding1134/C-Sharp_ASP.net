using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // Abstract class: cannot be instantiated, but can be inherited (Base class)    
    public abstract class Game
    {
        // Property thats common to all games
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        // **** ABSTRACT METHOD - no implementation ****
        public abstract void Play();
       
        // Virtual: can be overridden in derived classes, but does not have to be.  This is a concrete method.
        public virtual void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}

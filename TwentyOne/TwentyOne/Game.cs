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

        // Encapsulation: public properties provide controlled access to private fields
        private List<Player> _players = new List<Player>();

        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public Dictionary<Player, int> Bets
        {
            get { return _bets; }
            set { _bets = value; }
        }

        public string Name { get; set; }



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

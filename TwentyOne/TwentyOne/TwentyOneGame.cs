using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   
    // Inheritance:  "is a" relationship.  This is a specific type of game.  It is not a "has a" relationship.    
    public class TwentyOneGame : Game, IWalkAway
    {
      // override keyword- must use Play() because it is abstract method inherited from Game
      
       public override void Play()
        {
            // **** if method is called will throw an error
            throw new NotImplementedException();
        }

        // This is an example of method overriding.  We are overriding the ListPlayers method from the base class Game.
        public override void ListPlayers()
        {
            Console.WriteLine("21 players");
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }

}
   

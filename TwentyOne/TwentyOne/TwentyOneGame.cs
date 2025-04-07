using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //Here we are inheriting from the Game class.  This is a derived class.  The base (super) class is Game.
    public class TwentyOneGame : Game
    {
       // this will be specific to 21
       public void Play()
        {
            // if method is called will throw an error
            throw new NotImplementedException();
        }   
    }

}
   

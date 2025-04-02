using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card     //Public: Accessible to other parts of the program
    {
        // Constructor: method that gets called when an object is created & assigns default values- always the name of the class
        public Card()
        {
            Suit = "Whatevers";
            Face = "Two";
        }

        public string Suit { get; set; }   // Hearts, Diamonds, Clubs, etc.  
        public string Face { get; set; }   // 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack etc



    }
}

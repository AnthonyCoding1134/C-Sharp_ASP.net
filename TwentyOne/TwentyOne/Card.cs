using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card   
   // public struct Card

    {
       
        // These reference the enums
        public Suit Suit { get; set; }   // Hearts, Diamonds, Clubs, etc.  
        public Face Face { get; set; }   // 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack etc

        //Override the ToString method to return a string representation of the card
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0} of {1}", Face, Suit);
        }

    }
    public enum Suit
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }


}
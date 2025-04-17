using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //public class Card   
    public struct Card

    {
        // Constructor: method that gets called when an object is created & assigns default values- always the name of the class
        //public Card()
        //{
        //    //Suit = "Whatevers";
        //    Suit = "Clubs";
        //    Face = "ten";     
        //}

        // These reference the enums
        public Suit Suit { get; set; }   // Hearts, Diamonds, Clubs, etc.  
        public Face Face { get; set; }   // 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack etc
                                         
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
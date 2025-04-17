﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        // Constructor: method that gets called when an object is created & assigns default values- always the name of the class
        public Deck()
        {
           

            // Instantiates the property "Cards" as an empty list of class Card
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; // Casts the int to the enum type (Face)
                    card.Suit = (Suit)j; // Casts the int to the enum type (Suit)
                    Cards.Add(card);  //adds into our Cards list
                }

            }
           

            //*****Everything below got refactored after adding the enum

            //List<string> Faces = new List<string>()
           // { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
           // List<string> Suits = new List<string>() { "Spades", "Clubs", "Hearts", "Diamonds" };

          //  foreach (string Face in Faces)
          //  {
            //    foreach (string Suit in Suits)
            //    {
            //        Card card = new Card();
            //        card.Face = Face;
            //        card.Suit = Suit;
            //        Cards.Add(card);  //adds into our Cards list
            //    }
            //   }


        }
        // 1st thing we did after creating class - Cards is a property of the Deck class w/datatype List<Card>
        public List<Card> Cards { get; set; }

      
        public int Shuffle(int times = 1) 

        {
            

            for (int i = 0; i < times; i++)

            {
                
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);   // get random card between 0 & 52
                    TempList.Add(Cards[randomIndex]);   //add it to temp list
                    Cards.RemoveAt(randomIndex);    //removes  from the list of cards to prevent duplication
                }

              Cards = TempList;

            }
            return times;  // returns the number of times shuffled


        }
    }

    
}

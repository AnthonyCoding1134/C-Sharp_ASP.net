using System;
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
            /*Cards = new List<Card>();
            Card cardOne = new Card();
            cardOne.Face = "Two";
            cardOne.Suit = "Clubs";
            Cards.Add(cardOne);

            Card cardTwo = new Card();
            cardTwo.Face = "Ten";
            cardTwo.Suit = "Diamonds";
            Cards.Add(cardTwo);
            */

            // Instantiates the property "Cards" as an empty list of class Card
            Cards = new List<Card>();

            List<string> Faces = new List<string>()
            { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            List<string> Suites = new List<string>() { "Spades", "Clubs", "Hearts", "Diamonds" };

            foreach (string Face in Faces)
            {
                foreach (string Suite in Suites)
                {
                    Card card = new Card();
                    card.Face = Face;
                    card.Suit = Suite;
                    Cards.Add(card);  //adds into our Cards list
                }

            }

        }

        // 1st thing we did after creating class - Cards is a property of the Deck class w/datatype List<Card>
        public List<Card> Cards { get; set; }

        //public static Deck Shuffle(Deck deck)
        //Altering the method to add a default times param
        //public static Deck Shuffle(Deck deck1, out int timesShufffled, int times = 1)
        // When we remove static keyword we no longer need to specify the class name
        public void Shuffle(int times = 1) 

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

              // Cards = TempList;
              //***Another way to write it now that we removed static keyword***
              this.Cards = TempList;

            }
           // return deck1;
        }
    }

    
}

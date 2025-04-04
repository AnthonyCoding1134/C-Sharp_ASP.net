using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a new deck object based on "Deck" class- which has a property (list) "Cards".  This produces 52 "cards" 
            Deck deck1 = new Deck();
            //deck1 = Shuffle(deck1);
            //deck1 = Shuffle(deck1, 3);
            //named param
            //deck1 = Shuffle(deck1: deck1, 3);
            int timesShuffled = 0;  
            //Out keyword- returns new value to the variable above after it gets incremented by the method.  
            deck1 = Shuffle(deck1, out timesShuffled, 3);

          


            //Console.WriteLine(deck1.Cards[0].Face + " of " + deck1.Cards[0].Suit);
            //Console.WriteLine(deck1.Cards[1].Face + " of " + deck1.Cards[1].Suit);
            
            foreach (Card card in deck1.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck1.Cards.Count);
            Console.WriteLine("Times shuffled: {0} ", timesShuffled);

            // Instantiate the Cards property with a new list of cards
            //deck1.Cards = new List<Card>();

            ///create a new Card object & assigns it to variable cardOne. Props are set (these r unneeded after constructor)
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

            // deck1.Cards.Add(cardOne); // Add the card to the deck

            // deck1.Cards.Add(card53);
         }
        
        //public static Deck Shuffle(Deck deck)
        //here we alter the method to add a default times param
        public static Deck Shuffle(Deck deck1, out int timesShufffled, int times = 1)

        {
            timesShufffled = 0;

            for (int i = 0; i < times; i++)
                timesShufffled++;    
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck1.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck1.Cards.Count);   // get random card
                    TempList.Add(deck1.Cards[randomIndex]);   //add it to temp list
                    deck1.Cards.RemoveAt(randomIndex);    //removes  from the list of cards to prevent duplication
                }

                deck1.Cards = TempList;
            }
            return deck1;
            }

        // method overload: allows you to define multiple methods w/ same name but different params
        // Commented out after adding the optional param to the method above
        // public static Deck Shuffle(Deck deck, int times)  
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}


    }

}

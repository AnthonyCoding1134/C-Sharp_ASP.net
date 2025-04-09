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
            // This is polymorphism- we are using the base class to create an object of the derived class
            //Game game1 = new TwentyOneGame();

            TwentyOneGame game1 = new TwentyOneGame();
            Dealer dealer = new Dealer();   
          

            // Create a new deck object based on "Deck" class- which has a property (list) "Cards".  This produces 52 "cards" 
            Deck deck1 = new Deck();
            //deck1 = Shuffle(deck1);
            
            //****named param****
            //deck1 = Shuffle(deck1: deck1, 3);
            int timesShuffled = 0;  
            //Out keyword- returns new value to the variable above after it gets incremented by the method.  
            //deck1 = Shuffle(deck1, out timesShuffled, 3);

            deck1.Shuffle(3); // Call the method on the object itself now that static keyword is removed

           
            
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
            // **** OBJECT INITIALIZATION****
           // Card cardOne = new Card() { Face = "Queen", Suit = "Spades" }; 

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

            // deck1.Cards.Add(cardOne); // Add the card to the deck

            // deck1.Cards.Add(card53);
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

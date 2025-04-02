using System;
using System.Collections.Generic;
using System.Linq;
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
            deck1 = Shuffle(deck1);

            //Console.WriteLine(deck1.Cards[0].Face + " of " + deck1.Cards[0].Suit);
            //Console.WriteLine(deck1.Cards[1].Face + " of " + deck1.Cards[1].Suit);

            
            

            foreach (Card card in deck1.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck1.Cards.Count);

            // Instantiate the Cards property with a new list of cards
            //deck1.Cards = new List<Card>();

            ///create a new Card object & assigns it to variable cardOne. Props are set (these r unneeded after constructor)
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

            // deck1.Cards.Add(cardOne); // Add the card to the deck

            // //deck1.Cards.Add(card53);
         }
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>(); 
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);   // get random card
                TempList.Add(deck.Cards[randomIndex]);   //add it to temp list
                deck.Cards.RemoveAt(randomIndex);    //removes  from the list of cards to prevent duplication
            }

            deck.Cards = TempList;
            return deck;

        }

    }
}

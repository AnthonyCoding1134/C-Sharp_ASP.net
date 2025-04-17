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
            //Struct: a class with a value type that cannot inherit.  They are non-nullable
            
            Card card1 = new Card(); 
            Card card2 = card1; //This is a reference type.... card2 is a reference to the same object as card1.  Classes are reference types.
            card1.Face = Face.Ace;  

            card2.Face = Face.Two; //This will change the value of card1 as well, because they are both referencing the same object

            Console.WriteLine(card1.Face); // This will print "Two" when Card is class but Ace when Card is a struct



            // Polymorphism: Using the base class 'Game' to create a new object of the derived class 'TwentyOneGame'
            //Game game1 = new TwentyOneGame();

            // overloaded operator + to add a player to the game .  a game is retunred
            //game1 = game1 + player;    


            Deck deck1 = new Deck();
           int timesShuffled = deck1.Shuffle(3);
           

            //****named param****
            //deck1 = Shuffle(deck1: deck1, 3);
            //int timesShuffled = 0;  
            //Out keyword- returns new value to the variable above after it gets incremented by the method.  
            //deck1 = Shuffle(deck1, out timesShuffled, 3);


            foreach (Card card in deck1.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck1.Cards.Count);
            Console.WriteLine("Was shuffled {0} times", timesShuffled);

           
            // **** OBJECT INITIALIZATION****
            //Card cardOne = new Card() { Face = "Queen", Suit = "Spades" }; 

           
        }
    }

}

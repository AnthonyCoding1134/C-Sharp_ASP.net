﻿using System;
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



            // Polymorphism: Using the base class 'Game' to create a new object of the derived class 'TwentyOneGame'
            //Game game1 = new TwentyOneGame();
           // game1.Players = new List<Player>();
           // Player player = new Player();
           // player.Name = "Jordan";

            

            // overloaded operator + to add a player to the game .  a game is retunred
            //game1 = game1 + player;    

            // gives us 52 cards
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

            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            // **** OBJECT INITIALIZATION****
            //Card cardOne = new Card() { Face = "Queen", Suit = "Spades" }; 

            // Instantiate the Cards property with a new list of cards
            //deck1.Cards = new List<Card>();

        }





    }

}

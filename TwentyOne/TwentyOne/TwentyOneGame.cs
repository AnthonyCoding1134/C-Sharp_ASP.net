using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   
    // Inheritance:  "is a" relationship.  This is a specific type of game.  It is not a "has a" relationship.    
    public class TwentyOneGame : Game, IWalkAway
    {

        public TwentyOneDealer Dealer { get; set; } // Property of type Dealer

        // override keyword- must use Play() because it is abstract method inherited from Game
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;    
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfulBet = player.Bet(bet);   
                if(!successfulBet) return; // if the bet was not successful, exit the game
                Bets[player] = bet; // add the player and bet amount to the Bets dictionary
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{ 0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack) Console.WriteLine("Blackjack! {0} wins {1}!", player.Name, Bets[player]);
                        player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); // player wins 1.5 times the bet amount
                        return;
                    }
                }


                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand); // deal to dealer
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer wins with a blackjack!");
                        foreach (KeyValuePair<Player, int> entre in Bets )
                        {
                            Dealer.Balance += entre.Value; // dealer wins the bet amount
                        }
                    }
                }
            }
        }

        // This is an example of method overriding.  We are overriding the ListPlayers method from the base class Game.
        public override void ListPlayers()
        {
            Console.WriteLine("21 players");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }

}
   

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;    

namespace Casino.TwentyOne
{
   
    // Inheritance:  "is a" relationship.  This is a specific type of game (the base type).  It is not a "has a" relationship.    
    public class TwentyOneGame : Game, IWalkAway
    {

        public TwentyOneDealer Dealer { get; set; } // Property of type Dealer

        // override keyword- must use Play() because it is abstract method inherited from Game
        public override void Play()
        {
            Dealer = new TwentyOneDealer();

            //Creating an empty list of cards for players and dealer- sets up player statuses 
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(3); // Shuffle the deck


            //Console.WriteLine("Place your bet:");
            foreach (Player player in Players)
            {

                bool validAnswer = false;
                int bet = 0;

                
                while (!validAnswer)
                {
                    Console.WriteLine("Place bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Use numbers not letters. Please enter a numeric value for your bet:");
                }


                if(bet < 0)
                {
                    throw new FraudException("Security! Kick this wiseguy out!"); //this make it so the string is passed to the DB
                }

                bool successfulBet = player.Bet(bet);
                    if (!successfulBet)
                    {
                        Console.WriteLine("You're in over your head pal. Don't be such a degenerate");
                        return;
                    }

                    Bets[player] = bet; // add the player and bet amount to the Bets dictionary
            }




            //Deals first 2 cards to players- checks for blackjack & if so- pays out
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
      
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); // player wins 1.5 times the bet amount
                            Console.WriteLine("Blackjack! {0} wins {1}! Your new balance is {2} ", player.Name, Bets[player], player.Balance);
                            return;
                        }
                    }
                }

                //Deals to the dealer & checks for blackjack
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand); // deal to dealer
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer wins with a blackjack!");
                        foreach (KeyValuePair<Player, int> entre in Bets)
                        {
                            Dealer.Balance += entre.Value; // dealer wins the bet amount
                                                           //entre.Key.Balance -= entre.Value;
                            Console.WriteLine("{0}'s balance is {1}", entre.Key.Name, entre.Key.Balance);
                            
                        }
                       return;
                    }
                   
                }
            }


            // Player(s) take turns hitting or staying
            foreach (Player player in Players)
            
                while (!player.Stay)
                {
                    Console.WriteLine("Youre cards are:  ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "stay" || answer == "staying")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit" || answer == "hit me")
                    {
                        Dealer.Deal(player.Hand); // deal a card to the player
                    }

                    bool busted = TwentyOneRules.CheckForBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player]; // dealer wins the bet amount
                        Console.WriteLine("{0} busted!  Dealer wins {1}.  Your balance is {2}", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Wanna play again chump?");
                        string wannaPlayAgainAfterBusting = Console.ReadLine().ToLower();
                        if (wannaPlayAgainAfterBusting == "yes" || wannaPlayAgainAfterBusting == "y")
                        {
                            
                            player.isActivelyPlaying = true;
                            return;
                            // game.Play();
                        }

                        else
                        {
                            player.isActivelyPlaying = false; // player is not playing anymore
                           // WalkAway(player); // call the WalkAway method
                            return;
                                                             
                        }
                    
                    }

                        /*Console.WriteLine("Want to play again");
                        string answerTwo = Console.ReadLine().ToLower();
                        if (answerTwo == "yes" || answerTwo == "y")
                        {
                            player.isActivelyPlaying = true; 
                        }
                        else
                        {
                            player.isActivelyPlaying = false; 
                        }*/
                    
                }


                //Dealer.isBusted = TwentyOneRules.CheckForBusted(Dealer.Hand);
                //Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

                while (!Dealer.Stay && !Dealer.isBusted)
                {
                    Console.WriteLine("Dealer is hitting...");
                    Dealer.Deal(Dealer.Hand); // deal a card to the dealer
                    Dealer.isBusted = TwentyOneRules.CheckForBusted(Dealer.Hand);
                    Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
                }

                if (Dealer.Stay)
                {
                    Console.WriteLine("Dealer is staying...");
                }

                if (Dealer.isBusted)
                {
                    Console.WriteLine("The dealer busted!");
                    foreach (KeyValuePair<Player, int> entry in Bets)
                    {
                        Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); // player wins double the bet amount
                        Dealer.Balance -= entry.Value;
                        Console.WriteLine("{0} wins {1}", entry.Key.Name, entry.Value);
                        Console.WriteLine("{0}'s balance is {1}", entry.Key.Name, entry.Key.Balance);
                       
                    }
                    return;
                }
                //Compare the dealer's hand to each player's hand.
                foreach (Player player in Players)
                {
                    //The ? allows the bool to be null
                    bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                    if (playerWon == null)
                    {
                        Console.WriteLine("Push! No one wins.");
                        player.Balance += Bets[player]; // player gets their bet back
                    }
                    else if (playerWon == true)
                    {
                        Console.WriteLine("{0} wins {1}!", player.Name, Bets[player]);
                        player.Balance += (Bets[player] * 2); // player wins double the bet amount
                        Dealer.Balance -= Bets[player]; // dealer loses the bet amount
                    }
                    else
                    {
                        Console.WriteLine("Dealer wins {0}!", Bets[player]);
                        Dealer.Balance += Bets[player]; // dealer wins the bet amount


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
   

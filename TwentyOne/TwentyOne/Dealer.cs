using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   public class Dealer
    {
        public string Name { get; set; }

        public Deck Deck { get; set; }

        public int Balance { get; set; }    

        public void Deal(List<Card> Handy)  //List of type Card called Handy
        {
            Handy.Add(Deck.Cards.First());   
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); // Remove the first card from the deck

        }
    }
}

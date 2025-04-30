using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //streams: unmanaged code.  Making sur eeverything gets disposed of
            using (StreamWriter file = new StreamWriter(@"C:\Code_Logs\log2.txt", true))
            {
                file.WriteLine(card);
            }


            //Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); // Remove the first card from the deck

        }
    }
}

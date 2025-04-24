using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        /// <summary>
        //Private will not be accessible outside of this class
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
           
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1

        };
     
        private static int[] GetAllPossbileHandValues(List<Card> Hand)
        {
            // Lambda expression- find out how many aces there are
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            //possible values of the hand depending on whether Ace is 1 or 11.  declaring how many possible values there are in the array
            int[] possibleValues = new int[aceCount + 1];  
            int value = Hand.Sum(x => _cardValues[x.Face]); //  Sum of the cards' values (where each Ace is counted as 1)
            possibleValues[0] = value; // first value is the sum of the cards (where each Ace is counted as 1)
            if (possibleValues.Length == 1) return possibleValues; // if there are no aces, return the array

            for(int i = 1; i < possibleValues.Length; i++)
            {
                value += (i * 10); // Increase the hand value by (i * 10) to reflect i Aces being counted as 11 instead of 1
                possibleValues[i] = value; // store the value in the array
            }

            return possibleValues; // return the array of possible values

        }

        public static bool  CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossbileHandValues(Hand); // get all possible values of the hand
            int value = possibleValues.Max(); // get the maximum value of the hand
            if (value == 21) return true;
            else return false;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class IntegerReturn
    {
        public int AddFiveToInt(int value)
        {
             value += 5;
            return value;
        }

        public static int Times6ToInt(int value)
        {
            value *= 6;
            return value;
        }

        public static int SubtractTenFromInt(int value)
        {
            value -= 10;
            return value;
        }

         
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
   public class FraudException : Exception
    {
        //Inheriting from base Exception class
        public FraudException(): base()
        {

        }

        // overloading the constructor- also inherits from base Exception class
        public FraudException(string message) : base(message)
        {
        }
        
    }
}

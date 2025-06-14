using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
     class NegativeAge : Exception
    {
        public NegativeAge(): base()
        {

        }

        public NegativeAge(string message) : base(message)
        {
        }
    }
}

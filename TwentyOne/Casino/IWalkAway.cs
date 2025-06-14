using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    interface IWalkAway
    {
        // Gaming Commission Law : Player leaves with chips
         void WalkAway(Player player);

    }
}

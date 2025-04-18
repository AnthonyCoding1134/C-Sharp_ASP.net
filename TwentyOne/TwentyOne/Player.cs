﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //we can make Hand generic (Ex: it could be dice) by passing in <T> to the class
    public class Player
    {
        
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }

        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; } 

        //public static Game operator+ (Game game, Player player)
        //{
        //    game.Players.Add(player);
        //    return game;    
        //}

        //public static Game operator- (Game game, Player player)
        //{
        //    game.Players.Remove(player);
        //    return game;

        //}


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IntroBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFaveHobby = "reading"; // Change this to your favorite hobby   

            if (myFaveHobby == "sports")
            {
                Console.WriteLine("That's a great way to stay active and have fun!");
            }
            else if (myFaveHobby == "video games")
            {
                Console.WriteLine("Video games can be a fun way to relax and unwind.");
            }
            else if (myFaveHobby == "reading")
            {
                Console.WriteLine("Reading is a wonderful way to explore new worlds and ideas.");
            }
            else
            {
                Console.WriteLine("So what do you do?");
            }

            int numOfShirts = 7;

            if (numOfShirts != 3)
            {
                Console.WriteLine("You have a different number of shirts than I do.");  
            }

            if (numOfShirts >= 7)
            {
                Console.WriteLine("That's enough shirts for each day of the week!");
            }


             int age = 17;

            if (age >= 18)
            {
                Console.WriteLine("YOu can join the armed forces if you want to serve your country.");  

            }
            else
            {
                Console.WriteLine("You can't join yet");
            }

            //Ternary Operator

            int daysTillMove = 58;

            string mustPayCharge = daysTillMove >= 60? "You must pay the charge." : "You do not have to pay the charge."; 
            Console.WriteLine(mustPayCharge);


        }
    }
}

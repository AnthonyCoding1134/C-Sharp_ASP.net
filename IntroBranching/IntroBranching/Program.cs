using System;
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



        }
    }
}

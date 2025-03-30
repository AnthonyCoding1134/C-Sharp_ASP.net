using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 23, 65, 12, 99 };
            //Console.WriteLine(testScores.Length);

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    //Console.WriteLine(testScores[i]);
            //    if (testScores[i] >= 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failing test score: " + testScores[i]);

            //    }

            //}

            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            for (int j = 0; j < names.Length; j++)
            {
                //Console.WriteLine(names[j]);
                if (names[j] == "Erik")
                {
                    Console.WriteLine("I cant stand " + names[j] + "!");
                }
            }
            
            
            Console.ReadLine();


        }
    }
}

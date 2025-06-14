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

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    //Console.WriteLine(names[j]);
            //    if (names[j] == "Erik")
            //    {
            //        Console.WriteLine("I cant stand " + names[j] + "!");
            //    }
            //}


            //foreach loop w/ list
            //List<int> myTestScores = new List<int>();
            //myTestScores.Add(98);
            //myTestScores.Add(99);
            //myTestScores.Add(81);
            //myTestScores.Add(72);
            //myTestScores.Add(70);
            //myTestScores.Add(55);

            //foreach (int score in myTestScores)
            //{
            //    if (score >= 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failing test score: " + score);
            //    }
            //}

            //List<string> friends = new List<string>() { "Jesse", "Erik", "Daniel", "Adam", "Rocky" };
            //foreach (string friend in friends)
            //{
            //    if (friend == "Jesse")
            //    {
            //        Console.WriteLine(friend + " is my best friend!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(friend + " is my friend!");
            //    }
            //}

            //List<int> newTestScores = new List<int>() { 56, 49, 100, 87, 59, 12, 69 };
            //List<int> passingScores = new List<int>();  

            //foreach (int score in newTestScores)
            //{
            //    if (score >= 85)
            //    {
            //        passingScores.Add(score);
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failing test score: " + score);
            //    }

            //}
            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();

            //string[] meals = new string[4];
            //meals[0] = "breakfast";
            //meals[1] = "lunch";
            //meals[2] = "dinner";
            //meals[3] = "snack";


            //string[] foods = { "pizza", "tacos", "ice cream", "sushi", "burgers" };
            //string[] expressions = { };

            //Console.WriteLine("What is your favorite way to say something is great?");
            //string userInput = Console.ReadLine();

            //foreach (string food in foods)

            //{
            //    //Console.WriteLine(food);
            //    food  +=  userInput;  
            //}


            // Console App part 1 assignment

            //for (int i = 0; i < foods.Length; i++)
            //{
            //    foods[i] += ' ' + userInput;
            //    // Console.WriteLine(foods[i]);
            //}

            //for (int i = 0; i < foods.Length; i++)
            //// for (int i = 10; i > foods.Length; i++)
            //// for(; ;)
            //{
            //    // Console.WriteLine("Looping forever");
            //    Console.WriteLine(foods[i]);
            //}

            //int[] moreNumbers = { 121, 250, 34, 19, 65, 72};
            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.WriteLine(moreNumbers[i]);
            //}

            //List<string> animals = new List<string>() { "dog", "cat", "bird", "fish", "hamster" };  
            //Console.WriteLine("Please enter type of animal: ");
            //string userInput = Console.ReadLine();  


            //foreach (string animal in animals)


            //{
            //    //Console.WriteLine(animal);

            //    if (!animals.Contains(userInput))
            //    // if (animal != userInput)
            //    {
            //        Console.WriteLine("The " + userInput + " is not in the list");
            //        break;
            //    }
            //    if (animal == userInput)
            //    {
            //      Console.WriteLine(" The "  + animal + " is at index " + animals.IndexOf(animal));
            //        break;   //breaks loop


            //    }


            //}

            //if (!animals.Contains(userInput))
            //{
            //    Console.WriteLine("The animal is not in the list");
            //}

            //List<string> sports = new List<string>() { "soccer", "basketball", "football", "baseball", "hockey", "basketball" };
            //Console.WriteLine("Please enter a sport: ");
            //// string userInput = Console.ReadLine();
            //string userInput = Console.ReadLine();  

            //foreach (string sport in sports)
            //{
            //    if (sport == userInput)
            //    {
            //        Console.WriteLine(sport + " is at index " + sports.IndexOf(sport));
            //    }


            //    if (!sports.Contains(userInput))
            //    {
            //        Console.WriteLine("The sport is not in the list");
            //        break;
            //    }

            //    Console.ReadLine();
            //}


            List<string> yetAnotherStringList = new List<string>() { "Canada", "Mexico", "USA", "Brazil", "Germany", "China", "Canada" };
            List<string> newList = new List<string>();


          //  Console.WriteLine("Please enter a country: ");
            foreach (string country in yetAnotherStringList)
            {

                if (!newList.Contains(country))
                {
                    Console.WriteLine(country + " is unique");
                }
               
                else
                {
                    Console.WriteLine(country + " is a duplicate");
                }


                newList.Add(country);




            }

        }
    }

}

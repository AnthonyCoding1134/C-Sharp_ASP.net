using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {

        static void Main()
        {
        //arrays
        int[] numArray = new int[5];  //create array- must say how many elements
        numArray[0] = 5;  //assign values to array
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000; 

        Console.WriteLine(numArray[3]);  //200

        int[] numArray2 = new int[] { 5, 2, 10, 200, 5000 };  //create array and assign values in one line  
        Console.WriteLine(numArray2[1]);     //2

        // Assignment

        string[] carArray = new string[] { "Ford", "Chevy", "Dodge", "Toyota", "Honda" };
        Console.WriteLine("Select one of the cars: ");
        string userValue = Console.ReadLine();  //user input
        Console.WriteLine("You selected: " + carArray[Convert.ToInt32(userValue)]);
        if (Convert.ToInt32(userValue) > 4)
        {
            Console.WriteLine("That index does not exist.");
        }


        int[] numberArray = new int[] { 100, 200, 300, 400, 500 };
        Console.WriteLine("Select an index: ");
        int userValue2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You selected: " + numberArray[userValue2]);
        if (userValue2 > 4)
        {
            Console.WriteLine("That index does not exist.");
        }

        List<string> myCoolList = new List<string>();  //create list
        myCoolList.Add("Bon Jovi");
        myCoolList.Add("Journey");
        myCoolList.Add("Def Leppard");
        myCoolList.Add("Poison");
        myCoolList.Add("Motley Crue");
        myCoolList.Add("Guns N Roses");

        Console.WriteLine("Select an index of the list of cool bands: ");   
        int userValue3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You selected: " + myCoolList[userValue3] + " thats cool!");
        if (userValue3 > 5)
        {
            Console.WriteLine("That index does not exist.");
        }   

    }



    }


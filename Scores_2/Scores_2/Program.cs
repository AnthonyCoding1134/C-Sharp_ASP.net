namespace Scores_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string date = DateTime.Today.ToLongDateString();    
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}! Today's date is {date}"; 
            Console.WriteLine(msg);

            string path = @"C:\Users\Anthony\Desktop\Basic_C#_Programs\Scores_2\Scores_2\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double totalScore = 0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach(string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                totalScore += score;    
            }

            double avgScore = totalScore / lines.Length;
            Console.WriteLine("\n Total of " + lines.Length + " student scores. \tAverage score: " + avgScore);


            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

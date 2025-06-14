using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//enabling logging
using System.IO;
using Casino;   
using Casino.TwentyOne;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlClient;
using System.Data;


namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {



            // This illustrates how to use DateTime and TimeSpan in C#
            /*
            DateTime myDOB = new DateTime(1995, 5, 17, 7, 03, 17);
            DateTime gradDate = new DateTime(2017, 5, 17, 7, 03, 17);   
            
            TimeSpan numDaysSinceGraduation = gradDate - myDOB;

            //string textToBeWrote = "Here is some text";
            // File.WriteAllText(path: @"C:\Code_Logs\log.txt", textToBeWrote);
            // string textToBeRead = File.ReadAllText(path: @"C:\Code_Logs\log.txt");
            */

            //Using var to implicitly declare a variable- simpler but risky if data type is in question
            // var newPlayer = new Player("Anthony");


            const string casinoName = "Anthony's Casino";

            // Guid myIdentifier = Guid.NewGuid();


            Console.WriteLine("Welcome to {0}! The online casino that is so secure that it renders Jordan totally ineffective! \n" +
                "He might as well be back in the woods hugging trees! \n" +
                "Anyways, what's your name? ", casinoName);
            string playerName = Console.ReadLine();

            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.Timestamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;

            }

            bool validAnswer = false;
            int bank = 0;


            while (!validAnswer)
            {
                Console.WriteLine("Hi {0}, much money did you bring today?", playerName);
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer)
                {
                    Console.WriteLine("Digits only!");
                }

            }


            Console.WriteLine("Well {0}, would you like to play some blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yup" || answer == "you damn right" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Code_Logs\log2.txt", true))
                {
                    file.WriteLine(player.Id);

                }

                //polymorphism allows us to run TwentyOneGame's version of  Game's Play() bc it overrides it
                Game game = new TwentyOneGame();
                // game += player;
                game.Players.Add(player);
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();  //wrapping the main part of the game in a try-catch block to handle exceptions
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact support.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }

                }

                game.Players.Remove(player);
                Console.WriteLine("Thank you for playing!");

            }
            else
            {
                Console.WriteLine("You emit a foul and unpleasant odor");
                return;


            }




        }
        private static void UpdateDbWithException(Exception ex)
        {
            //connection string obtained from properties...
            //had to add the @, quotes & remove spaces between TrustServerCertificate ApplicationIntent & MultiSubnetFailover
            string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=TwentyOneGame;
                                       Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                       TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //sql query to insert the exception into the database...utilizing parameterized queries
            string queryString  = @"INSERT INTO Exceptions(ExceptionType, ExceptionMessage, TimeStamp) 
                                    VALUES(@ExceptionType, @ExceptionMessage, @TimeStamp)";


            //using statement will ensure the connection is closed after use
            // this allows us to control unmanaged code & control memory when dealing with external resources
            //when reading and updating DB, you typically have a class that only has properties that correspond to columns in the DB

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                //add parameters to the command obj & specify their data types | Protects against SQL injection
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                //now we must add the values to the parameters
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                //semd to the database, execute the command, and close the connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close(); 

            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=TwentyOneGame;
                                       Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                       TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"SELECT Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();    
                    exception.Timestamp = Convert.ToDateTime(reader["TimeStamp"]);  
                    exceptions.Add(exception);
                }

                connection.Close();

            }

            return exceptions;
        }
    }

}

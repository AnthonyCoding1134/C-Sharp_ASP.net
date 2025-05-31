using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        // Define the connection string to connect to the database
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        //these params need to match Name attribute of input form (model-binding)
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
           // return null;
           if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }

           else
            {
                //ADO.net allows us to save data to the database

                // 1. Define the connection string to connect to the database


                // 2. Define the SQL query with parameters (to prevent SQL injection)

                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                                        (@FirstName, @LastName, @EmailAddress)";

                // 3. Create a connection to the database using the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // 4. Create a SQL command using the query and connection
                    SqlCommand command = new SqlCommand(queryString, connection);

                    // 5. Define the parameters and their data types
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    // 6. Assign values to the parameters from the method inputs
                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    // 7. Open the connection, execute the command, and close the connection
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }


                return View("Success");


            }
                
           

        }

        public ActionResult Admin()
        {
            // Retrieve all newsletter signups from the database
            string queryString = "SELECT * FROM SignUps";

            // Initialize a list to store signup records
            List<NewsletterSignup> signups = new List<NewsletterSignup>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    // Create a new model instance and populate it with data from the current database row
                    var signup = new NewsletterSignup();


                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
                     // Add the model to the list
                    signups.Add(signup);
                    
                    

                   
                }
            }

            // Using ViewModel to retrieve list of SignUps with only the properties we need
            //List<SignUpVM> signUpVms = new List<SignUpVM>();
            var signUpVms = new List<SignUpVM>();

            foreach (var signup in signups)
            {
                var signupVM = new SignUpVM();
                signupVM.FirstName = signup.FirstName;
                signupVM.LastName = signup.LastName;
                signupVM.EmailAddress = signup.EmailAddress;
                signUpVms.Add(signupVM);    



            }
            
            // Pass the signup list to the regular view (this was used prior to using a ViewModel)
            //return View(signups);

            // Pass the signup list to the view using the ViewModel
            return View(signUpVms);
        }






    }
}
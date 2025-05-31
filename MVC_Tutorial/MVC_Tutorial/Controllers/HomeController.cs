using MVC_Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()  //default route

        {

            User user1 = new User();
            user1.Id = 1;
            user1.FirstName = "John";
            user1.LastName = "Doe";
            user1.Age = 30;


            /*
            List<string> names = new List<string>
            {
                "Ant",
                "Nicole",
                "Joe"
            };

            
            string text = "Hello";
            System.IO.File.WriteAllText(@"C:\Code_Logs\mvc\test_log.txt", text);
           

            Random rand = new Random(10);
            int num = rand.Next();

            ViewBag.MyRandomNumber = num;

            if (num > 20000)
            {
                return View("About");
            }

            */


            return View(user1);
           // return Content("Hi");
           // return RedirectToAction("Contact");   //diff from returning a diff view bc this action actually returns Contact URL
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Bad!");

            return View();
        }

        public ActionResult Contact(int id =0)
        {
            ViewBag.Message = "Your contact page.";
          //  ViewBag.Message = id;    // can print parameter through url: EX:  //localhost:44306/Home/Contact/25 prints 25

            return View();
        }
    }
}
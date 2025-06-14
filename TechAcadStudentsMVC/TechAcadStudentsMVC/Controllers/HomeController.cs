using System.Diagnostics;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechAcadStudentsMVC.Models;



namespace TechAcadStudentsMVC.Controllers;

// Controller class provides  HomeController class with View() method & pseudo-dictionary called ViewBag.
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
       // _logger.LogInformation("Index page was visited.");
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["School"] = "Tech Academy";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Instructor(int id)
    {
        //ViewBag - used to pass data from Controller to View (like ViewData)
        //except the data being passed is a property instead of a key-value pair
        ViewBag.Id = id;

        Instructor newInstructor = new Instructor()
        {
            Id = 1,
            FirstName = "Bob",
            LastName = "Smith",


        };

        return View(newInstructor);
    }

    public IActionResult Instructors()
    {
        List<Instructor> instructors = new List<Instructor>()
        {
            new Instructor
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Smith",
            },
            new Instructor
            {
                Id = 2,
                FirstName = "John",
                LastName = "Smith",
            },
            new Instructor
            {
                Id = 3,
                FirstName = "Jane",
                LastName = "Doe",
            }


         };

         return View(instructors);
    }

    
}

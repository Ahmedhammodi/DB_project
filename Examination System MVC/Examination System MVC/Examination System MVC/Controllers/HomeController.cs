using DAL.DatabaseManager;
using DAL.Entities;
using Examination_System_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Examination_System_MVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View("~/Views/Auth/login.cshtml");
		}
		[HttpPost]
		public IActionResult Login(string username, string password)
		{
			var person = ContextManager.MyContext.People.Where(p => p.Username == username && p.Password == password).FirstOrDefault();
			//bool exists = ContextManager.MyContext.People.Any(p=> p.Username == username && p.Password == password);
			if (person != null)
			{
				if (person.UserRole == "Student")
				{
					var student = ContextManager.MyContext.Students.Where(s => s.PersonID == person.ID).FirstOrDefault();
					return View("~/Views/Student/Main.cshtml", student);
				}
				else
				{
					var instructor = ContextManager.MyContext.Instructors.Where(s => s.PersonID == person.ID).FirstOrDefault();
                    return RedirectToAction("AddQuestion", "Instructor");
                }
            }
			else
			{
				return RedirectToAction("Index");
			}
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
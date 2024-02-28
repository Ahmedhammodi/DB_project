using Microsoft.AspNetCore.Mvc;

namespace Examination_System_MVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View("exam");
        }
        public IActionResult Main()
        {
            return View();
        }
        public IActionResult Instructions(int id)
        {
            return View();
        }

        public IActionResult Exam(int id)
        {
            return View();
        }

        public IActionResult SubmitMessage(int id)
        {
            return View();
        }

    }
}

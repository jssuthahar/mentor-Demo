using Microsoft.AspNetCore.Mvc;

namespace mentor.Controllers
{
    public class MentorController : Controller
    {
        
            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Details(int id)
            {
                return View();
            }

            public IActionResult BecomeMentor()
            {
                return View();
            }

            public IActionResult Availability()
            {
                return View();
            }
        
    }
}

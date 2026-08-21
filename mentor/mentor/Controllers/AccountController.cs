using Mentor.Models;
using Microsoft.AspNetCore.Mvc;

namespace mentor.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Login()
        //{
        //    return View();
        //}

			[HttpGet]
			public IActionResult Login()
			{
				return View();
			}


			
			[HttpPost]
			[ValidateAntiForgeryToken]
			public IActionResult Login(LoginViewModel model)
			{
				// Validate Email and Password
				if (!ModelState.IsValid)
				{
					return View(model);
				}

			

				if (model.Email == "mentor@gmail.com" &&
					model.Password == "Mentor@123")
				{
					// Store login information in Session
					HttpContext.Session.SetString(
						"UserEmail",
						model.Email
					);

					HttpContext.Session.SetString(
						"UserRole",
						"Mentor"
					);

					// Login successful
					return RedirectToAction(
						"Dashboard",
						"Mentor"
					);
				}

				// Login failed
				ModelState.AddModelError(
					string.Empty,
					"Invalid email or password."
				);

				return View(model);
			}

	[HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterPost()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
		//public IActionResult Logout()
		//{
		//    return View();
		//}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Logout()
		{
			HttpContext.Session.Clear();

			return RedirectToAction(
				"Login",
				"Account"
			);
		}

	}
}

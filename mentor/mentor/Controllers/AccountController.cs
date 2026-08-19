using mentor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace mentor.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPost(Register regModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Register", regModel);
            }
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source = NIRTHIK\SQLEXPRESS; Initial Catalog = MentorApplicationDB; Integrated Security = True; Persist Security Info = False; Encrypt = false; TrustServerCertificate = True;";
                conn.Open(); 
                string query = $"INSERT INTO Users (FirstName, LastName, Email,PhoneNumber ,PasswordHash) VALUES ('{regModel.FirstName}','{regModel.LastName}','{regModel.Email}','{regModel.Phone}','{regModel.Password}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return RedirectToAction("Login");
            }
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }

    }
}

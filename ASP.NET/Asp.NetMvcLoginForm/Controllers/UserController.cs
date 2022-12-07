using Microsoft.AspNetCore.Mvc;

namespace Asp.NetMvcLoginForm.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
        public IActionResult login() // For Login
          {
            return View();
        }
        public IActionResult Submit(Models.User user) 
        {
            ViewBag.User = user.Email;
            ViewBag.Password = user.Password;

            return View();
        }



    }
}

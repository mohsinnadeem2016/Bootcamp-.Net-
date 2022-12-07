using Microsoft.AspNetCore.Mvc;

namespace Asp.NetMvcLoginForm.Models
{
    public class login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

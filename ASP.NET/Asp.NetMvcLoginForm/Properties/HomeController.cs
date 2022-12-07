using Microsoft.AspNetCore.Mvc;

namespace Asp.NetMvcLoginForm.Properties
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

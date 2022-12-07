using Microsoft.AspNetCore.Mvc;

namespace MiddlewareAttributeRouting.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("{controller=Home}/{action=Index}/{id?}/{num01}/{num02}/{num03}")]
        public IActionResult AttributeRouting(int id, int num01, int num02, int num03)
        {
            return View();
        }





    }
}

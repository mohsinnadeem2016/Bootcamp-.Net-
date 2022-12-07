using Microsoft.AspNetCore.Mvc;

namespace AttritubeRouting.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AttributeRouting( int id, int num01, int num02, int num03)
        {
            return View();
        }
    }
}

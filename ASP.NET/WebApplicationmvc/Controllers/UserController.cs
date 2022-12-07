using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationmvc.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult mohsin()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        
        public ActionResult submit(string Email,string Password)
        {
            // ViewBag.Message = "Your application description page.";
            //ViewData[]
            //ViewBag
            ViewData["Email"] = Email;

            
            ViewData["Password"] = Password;
            if (Email == "admin" && Password == "admin")
            {
                return View("welcomepage");
            }
            else {
                return View();

            }
           
            
        }

    }
}
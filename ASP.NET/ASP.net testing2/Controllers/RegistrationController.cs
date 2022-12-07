using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.net_testing2.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()

        {
            return View();
        }
        public ActionResult Registration()

        {
            return View();
        }
        public ActionResult Submit(Models.Registration mohsin)
        {

            ViewBag.Name = mohsin.Name;
            ViewBag.Email = mohsin.Email;
            ViewBag.Password = mohsin.Password;
            ViewBag.Descipline = mohsin.Descipline;
            ViewBag.Age = mohsin.Age;
            ViewBag.Gender = mohsin.Gender;


            return View();
        }

    }
}
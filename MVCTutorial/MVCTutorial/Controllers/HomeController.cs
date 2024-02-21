using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Users user = new Users();
            user.Id = 1;
            user.firstName = "Lily";
            user.lastName = "Heym";
            user.Age = 21;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
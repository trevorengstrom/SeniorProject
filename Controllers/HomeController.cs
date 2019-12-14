using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaMotors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Todd Allan Motors.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Todd Allan Motors.";

            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.Message = "Your Dashboard.";

            return View();
        }

        public ActionResult Finance()
        {
            ViewBag.Message = "Todd Allan Financing.";

            return View();
        }
    }
}
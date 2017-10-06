using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Me";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Services Offered";

            return View();
        }

        public ActionResult Technologies()
        {
            ViewBag.Message = "Technologies want to work in";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Portfolio";

            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Message = "My Resume is below";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Details";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Please enter the Details";

            return View();
        }
    }
}
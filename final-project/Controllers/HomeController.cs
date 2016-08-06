using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final_project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Electronics Store.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact US.";

            return View();
        }
    }
}
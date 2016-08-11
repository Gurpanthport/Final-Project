using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using final_project.Models;

namespace final_project.Controllers
{
    public class StoreController : Controller
    {
        //AromaModel menuDB = new AromaModel();
        private StoreContex db = new StoreContex();

        public ActionResult Index()
        {
            //var MenuItem = db.MenuItems.Include(a => a.MenuType);
            return View(/*MenuItem.ToList()*/);
        }
    }
}
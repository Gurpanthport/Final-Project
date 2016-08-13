using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using final_project.Models;
using System.Diagnostics;

namespace final_project.Controllers
{
    public class StoreController : Controller
    {
        private StoreContext storeDB = new StoreContext();

        // GET: Restaurant
        public ActionResult Index()
        {
            List<StoreType> StoreTypes = storeDB.StoreTypes.ToList();
            return View(StoreTypes);
        }

        public ActionResult Browse(string StoreType)
        {
            //Debug.WriteLine(type);
            StoreType StoreTypes = storeDB.StoreTypes.Include("StoreItems").Single(g => g.Name == StoreType);
            return View(StoreTypes);
        }
        public ActionResult Details(int id = 1)
        {
            StoreItem StoreItem = storeDB.StoreItems.Find(id);
            return View(StoreItem);
        }
    }
}
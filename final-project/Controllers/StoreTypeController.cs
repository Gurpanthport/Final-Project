using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using final_project.Models;


namespace final_project.Controllers
{

    public class StoreTypeController : Controller
    {

        private StoreContext storeDB = new StoreContext();
        // GET: AromaRestaurant
        public ActionResult Index()
        {
            List<StoreType> types = storeDB.StoreTypes.ToList();
            return View(types);
        }

        public ActionResult Browse(string StoreType)
        {
            StoreType StoreTypeModel = storeDB.StoreTypes.Include("StoreItems").Single(g => g.Name == StoreType);
            return View(StoreTypeModel);
        }
        public ActionResult Details(int id = 1)
        {
            StoreItem StoreItem = storeDB.StoreItems.Find(id);
            return View(StoreItem);
        }
    }
}
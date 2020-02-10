using StoreRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreRater.Controllers
{
    public class StoreController : Controller
    {
        private StoreDbContext _db = new StoreDbContext();
        // GET: Store
        public ActionResult Index()
        {
            return View(_db.Stores.ToList());
        }
    }
}
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

        //GET: Store/Create

        public ActionResult Create()
        {
            return View();
        }
        //POST: store/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Store store)
        {
            if (ModelState.IsValid)
            {
                _db.Stores.Add(store);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(store);

        }
    }
}
using StoreRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
        //GET: Store/Delete/(id)

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Store store = _db.Stores.Find(id);
            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(int id)
        {
            Store store = _db.Stores.Find(id);
            _db.Stores.Remove(store);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        //GET: Store/Edit?(id)
        //Get an id form the user
        // find a store by the id
        //exceptions of the id is null
        //exception if store does not exist
        //of it does exist the return the store and the view

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Store store = _db.Stores.Find(id);
            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);

        }

        //POST: Store/Edit/(id)

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Store store)
        {
            
            if (ModelState.IsValid)
            {
                _db.Entry(store).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(store);
        }

        //GET: Store/Details/(id)
        //This could possibly be refactored as we have used the same code three times in this controller.

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Store store = _db.Stores.Find(id);
            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);

        }
    }
}
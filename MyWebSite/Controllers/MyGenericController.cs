using MyWebSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    public abstract class MyGenericController<T> : Controller where T :class
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        /// <summary>
        /// Calls the default method of the controller
        /// </summary>
        /// <remarks>
        /// Advized to overwrite this in each derived controller, as all other ActionMethods return to the Index View.
        /// </remarks>
        /// <returns>Returns a View of <para>T</para></returns>
        // GET: MyGeneric
        public virtual ActionResult Index()
        {
            var set = db.Set<T>();

            return View(set.ToList());
        }

        //GET: T/Details/5
        public virtual ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            DbSet set = db.Set<T>();
            var entity = set.Find(id);

            if (entity == null)
            {
                return HttpNotFound();
            }
            return View(entity);
        }

        // GET: T/Create
        public virtual ActionResult Create()
        {
            return View();
        }

        // POST: T/Create       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create(T entity)
        {
            if (ModelState.IsValid)
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entity);
        }

        // GET: T/Edit/5
        public virtual ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            DbSet set = db.Set<T>();
            var entity = set.Find(id);

            if (entity == null)
            {
                return HttpNotFound();
            }
            return View(entity);
        }

        // POST: T/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(T entity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entity);
        }

        //POST: T/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            DbSet set = db.Set<T>();
            var entity = set.Find(id);
            set.Remove(entity);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
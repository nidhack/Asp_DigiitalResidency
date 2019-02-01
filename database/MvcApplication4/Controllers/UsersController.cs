using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;

namespace MvcApplication4.Controllers
{
    public class UsersController : Controller
    {
        private AyanaContext db = new AyanaContext();

        //
        // GET: /Users/

        public ActionResult Index()
        {
            return View(db.UserDemos.ToList());
        }

        //
        // GET: /Users/Details/5

        public ActionResult Details(int id = 0)
        {
            UserDemo userdemo = db.UserDemos.Find(id);
            if (userdemo == null)
            {
                return HttpNotFound();
            }
            return View(userdemo);
        }

        //
        // GET: /Users/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Users/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserDemo userdemo)
        {
            if (ModelState.IsValid)
            {
                db.UserDemos.Add(userdemo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userdemo);
        }

        //
        // GET: /Users/Edit/5

        public ActionResult Edit(int id = 0)
        {
            UserDemo userdemo = db.UserDemos.Find(id);
            if (userdemo == null)
            {
                return HttpNotFound();
            }
            return View(userdemo);
        }

        //
        // POST: /Users/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserDemo userdemo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userdemo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userdemo);
        }

        //
        // GET: /Users/Delete/5

        public ActionResult Delete(int id = 0)
        {
            UserDemo userdemo = db.UserDemos.Find(id);
            if (userdemo == null)
            {
                return HttpNotFound();
            }
            return View(userdemo);
        }

        //
        // POST: /Users/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserDemo userdemo = db.UserDemos.Find(id);
            db.UserDemos.Remove(userdemo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
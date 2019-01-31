using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using New.Models;

namespace New.Controllers
{
    public class UsController : Controller
    {
        private UserContext db = new UserContext();

        //
        // GET: /Us/

        public ActionResult Index()
        {
            return View(db.users.ToList());
        }

        //
        // GET: /Us/Details/5

        public ActionResult Details(int id = 0)
        {
            New1 new1 = db.users.Find(id);
            if (new1 == null)
            {
                return HttpNotFound();
            }
            return View(new1);
        }

        //
        // GET: /Us/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Us/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(New1 new1)
        {
            if (ModelState.IsValid)
            {
                db.users.Add(new1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(new1);
        }

        //
        // GET: /Us/Edit/5

        public ActionResult Edit(int id = 0)
        {
            New1 new1 = db.users.Find(id);
            if (new1 == null)
            {
                return HttpNotFound();
            }
            return View(new1);
        }

        //
        // POST: /Us/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(New1 new1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(new1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(new1);
        }

        //
        // GET: /Us/Delete/5

        public ActionResult Delete(int id = 0)
        {
            New1 new1 = db.users.Find(id);
            if (new1 == null)
            {
                return HttpNotFound();
            }
            return View(new1);
        }

        //
        // POST: /Us/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            New1 new1 = db.users.Find(id);
            db.users.Remove(new1);
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
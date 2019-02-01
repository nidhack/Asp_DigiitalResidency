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
    public class StudController : Controller
    {
        private UsersContext db = new UsersContext();

        //
        // GET: /Stud/

        public ActionResult Index()
        {
            
            return View(db.Studs.ToList());
        }

        //
        // GET: /Stud/Details/5

        public ActionResult Details(int id = 0)
        {
            Stud stud = db.Studs.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        //
        // GET: /Stud/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Stud/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stud stud)
        {
            if (ModelState.IsValid)
            {
                db.Studs.Add(stud);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stud);
        }

        //
        // GET: /Stud/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Stud stud = db.Studs.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        //
        // POST: /Stud/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Stud stud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stud);
        }

        //
        // GET: /Stud/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Stud stud = db.Studs.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        //
        // POST: /Stud/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stud stud = db.Studs.Find(id);
            db.Studs.Remove(stud);
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
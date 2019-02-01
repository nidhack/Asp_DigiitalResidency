using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Models
{
    public class AnsaController : Controller
    {
        private AyanaContext db = new AyanaContext();

        //
        // GET: /Ansa/

        public ActionResult Index()
        {
            var studs = db.Studs.Include(s => s.UserDemo);
            return View(studs.ToList());
        }

        //
        // GET: /Ansa/Details/5

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
        // GET: /Ansa/Create

        public ActionResult Create()
        {
            ViewBag.UserDemoid = new SelectList(db.UserDemos, "UserDemoid", "username");
            return View();
        }

        //
        // POST: /Ansa/Create

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

            ViewBag.UserDemoid = new SelectList(db.UserDemos, "UserDemoid", "username", stud.UserDemoid);
            return View(stud);
        }

        //
        // GET: /Ansa/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Stud stud = db.Studs.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserDemoid = new SelectList(db.UserDemos, "UserDemoid", "username", stud.UserDemoid);
            return View(stud);
        }

        //
        // POST: /Ansa/Edit/5

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
            ViewBag.UserDemoid = new SelectList(db.UserDemos, "UserDemoid", "username", stud.UserDemoid);
            return View(stud);
        }

        //
        // GET: /Ansa/Delete/5

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
        // POST: /Ansa/Delete/5

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
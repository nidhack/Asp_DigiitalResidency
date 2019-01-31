using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvcp.Models;

namespace Mvcp.Controllers
{
    public class userController : Controller
    {
        private Pk db = new Pk();

        //
        // GET: /user/

        public ActionResult Index()
        {
            return View(db.UserDemos.ToList());
        }

        //
        // GET: /user/Details/5

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
        // GET: /user/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /user/Create

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
        // GET: /user/Edit/5

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
        // POST: /user/Edit/5

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
        // GET: /user/Delete/5

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
        // POST: /user/Delete/5

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
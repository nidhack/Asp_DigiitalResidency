using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;


namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getString()
        {
            return View();
        }
        public ActionResult pk()
        {
            Pk p = new Pk();
            p.name = "Prakashan";
            p.email = "prakashan@gmail.com";
            return View(p);
        }
        public ActionResult cpk()
        {
            Cpk cp = new Cpk();
            cp.cname
        }
    }
}

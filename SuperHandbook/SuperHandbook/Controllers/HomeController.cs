using SuperHandbook.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHandbook.Controllers
{
    public class HomeController : Controller
    {
        private SuperDBEntities db = new SuperDBEntities();
        public ActionResult Index()
        {
            var superheroes = db.Superheroes;
            return View(superheroes.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
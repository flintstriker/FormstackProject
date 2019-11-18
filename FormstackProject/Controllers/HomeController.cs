using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FormstackProject.Models;

namespace FormstackProject.Controllers
{
    public class HomeController : Controller
    {
        private FormDBContext db = new FormDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutMe()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult FormList()
        {
            ViewBag.Message = "Your contact page.";

            return View(db.Forms.ToList());
        }
    }
}
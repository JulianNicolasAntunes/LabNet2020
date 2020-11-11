using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioMVC.Entity;

namespace EjercicioMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Employees()
        {
            return View();
        }
        public ActionResult departments ()
        {
            return View();
        }
        public ActionResult Locations()
        {
            return View();
        }

    }
}
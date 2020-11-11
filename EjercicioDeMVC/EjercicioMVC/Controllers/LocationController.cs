using EjercicioMVC.Entity;
using EjercicioMVC.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EjercicioMVC.Controllers
{
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {
            var logic = new LocationsLogic();
            var locations = logic.GetAll();

            return View(locations);

        }
        public ActionResult Insertar()
        {
            return View();
        }
        public ActionResult Actualizar()
        {
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insertar(LOCATIONS loca)
        {
            var logic = new LocationsLogic();
            var locationEntity = new LOCATIONS();
            locationEntity.CITY = loca.CITY;
            logic.Insert(locationEntity);
            return Redirect("Index");

        }
    }
}
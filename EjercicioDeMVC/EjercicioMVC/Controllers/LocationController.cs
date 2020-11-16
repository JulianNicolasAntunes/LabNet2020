using EjercicioMVC.Entity;
using EjercicioMVC.Logic;
using Rotativa;
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
        //public ActionResult Buscador(String Nombre)
        //{
        //    var busqueda = from s in context.LOCATIONS select s;
        //    if (!String.IsNullOrEmpty(Nombre))
        //    {
        //        busqueda = busqueda.Where(j => j. Nombre);
        //    }
        //    return View(busqueda);
        //}

        public ActionResult Insertar()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(LOCATIONS location)
        {
            var logic = new LocationsLogic();
            var locaEntity = logic.GetOne(location.ID);
            if (location.CITY != null)
                locaEntity.CITY = location.CITY;
            logic.Update(locaEntity);
            return RedirectToAction("index");
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
        public ActionResult Delete(int id)
        {
            var logic = new LocationsLogic();
            logic.Delete(id);
            return RedirectToAction("index");
        }

        public ActionResult Print()
        {
            return new ActionAsPdf("Report", new { nombre = "prueba" })
            { FileName = "ReportLocations_.pdf" };
        }
        public ActionResult Report()
        {
            var logic = new LocationsLogic();
            var locations = logic.GetAll();

            return View(locations);
        }
    }
}
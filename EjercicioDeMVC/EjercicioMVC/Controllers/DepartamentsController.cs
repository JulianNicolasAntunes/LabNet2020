using EjercicioMVC.Entity;
using EjercicioMVC.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace EjercicioMVC.Controllers
{
    public class DepartamentsController : Controller
    {
        // GET: Departaments
        public ActionResult Index()
        {
            var logic = new DepartmentsLogic();
            var deptos = logic.GetAll();
            return View(deptos);

        }


        public ActionResult Insertar(DEPARTMENTS loca)
        {
            var logic = new DepartmentsLogic();
            var deptoEntity = new DEPARTMENTS();
            deptoEntity.DEPARTMENT_NAME = loca.DEPARTMENT_NAME;
            deptoEntity.LOCATION_ID = loca.LOCATION_ID;
            deptoEntity.DEPARTMENT_DESCRIPTION = loca.DEPARTMENT_DESCRIPTION;
            logic.Insert(deptoEntity);
            return Redirect("Index");

        }
        public ActionResult Actualizar()
        {
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }
    }
}
   
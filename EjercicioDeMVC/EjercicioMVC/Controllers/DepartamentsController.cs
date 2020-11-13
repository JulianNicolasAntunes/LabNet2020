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
        //public ActionResult Buscador(String Nombre)
        //{
        //    var busqueda = from s in context.DEPARTMENTS select s;
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

        [HttpPost]
        public ActionResult Update(DEPARTMENTS department)
        {
            var logic = new DepartmentsLogic();
            var deptoEntity = logic.GetOne(department.ID);
            if (department.DEPARTMENT_NAME != null)
            {
                deptoEntity.DEPARTMENT_NAME = department.DEPARTMENT_NAME;
            }
            if (department.DEPARTMENT_DESCRIPTION != null)
            {
                deptoEntity.DEPARTMENT_DESCRIPTION = department.DEPARTMENT_DESCRIPTION;
            }
            logic.Update(deptoEntity);
            return RedirectToAction("index");
        }

        public ActionResult Delete(int id)
        {
            var logic = new DepartmentsLogic();
            logic.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Insertar(DEPARTMENTS depto)
        {
            var logic = new DepartmentsLogic();
            var deptoEntity = new DEPARTMENTS();
            deptoEntity.DEPARTMENT_NAME = depto.DEPARTMENT_NAME;
            deptoEntity.LOCATION_ID = depto.LOCATION_ID;
            deptoEntity.DEPARTMENT_DESCRIPTION = depto.DEPARTMENT_DESCRIPTION;
            logic.Insert(deptoEntity);
            return Redirect("Index");

        }
  
    }
}
   
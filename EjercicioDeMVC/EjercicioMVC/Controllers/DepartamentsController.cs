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
        public ActionResult Insertar()
        {

            return View();
        }
        public ActionResult Update()
        {
            return View();
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
   
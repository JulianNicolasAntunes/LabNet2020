using EjercicioMVC.Entity;
using EjercicioMVC.Logic;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioMVC.ResourceAccess;


namespace EjercicioMVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            var logic = new EmployeesLogic();
            var employees = logic.GetAll();
            if (TempData["Mensaje"] != null)
                ViewData["Mensaje"] = TempData["Mensaje"].ToString();
            return View(employees);
        }
        
      
        private PracticaSQLContext  database = new PracticaSQLContext();
        // Buscador no funciona todavia
        public ActionResult Search(string search)
        {
            var emplo = from a in database.EMPLOYEES
                           select a;
            if (!String.IsNullOrEmpty(search))
            {
                emplo = emplo.Where(s => s.LAST_NAME.Contains(search));
            }
            return View(emplo.ToList());
        }
   
        public ActionResult Insertar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(EMPLOYEES employee)
        {
            var logic = new EmployeesLogic();
            var emploEntity = logic.GetOne(employee.ID);
            if (employee.FIRST_NAME != null) 
            {
                emploEntity.FIRST_NAME = employee.FIRST_NAME; 
            }
            if (employee.LAST_NAME != null) 
            {
                emploEntity.LAST_NAME = employee.LAST_NAME; 
            }
            if (employee.SALARY != null) 
            {
                emploEntity.SALARY = employee.SALARY; 
            }
            if (employee.DEPARTMENT_ID != null)
            {
                emploEntity.DEPARTMENT_ID = employee.DEPARTMENT_ID;
            }
            if (employee.MANAGER_ID != null)
            {
                emploEntity.MANAGER_ID = employee.MANAGER_ID;
            }

            try { logic.Update(emploEntity); }
            catch (Exception exception)
            {
                TempData["Mensaje"] = "Error al actualizar un empleado." + exception.Message;
            }
            return RedirectToAction("index");
        }
        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insertar (EMPLOYEES emplo)
        {
            var logic = new EmployeesLogic();
            var employeesEntity = new EMPLOYEES();
            employeesEntity.FIRST_NAME = emplo.FIRST_NAME;
            employeesEntity.LAST_NAME = emplo.LAST_NAME;
            employeesEntity.SALARY = emplo.SALARY;
            employeesEntity.DEPARTMENT_ID = emplo.DEPARTMENT_ID;
            employeesEntity.JOB_ID = emplo.JOB_ID;
            employeesEntity.HIRE_DATE = emplo.HIRE_DATE;
            employeesEntity.MANAGER_ID = emplo.MANAGER_ID;

            try { logic.Insert(employeesEntity); }
            catch (Exception exception)
            {
                TempData["Mensaje"] = "Error al insertar un empleado." + exception.Message;
            }
            return Redirect("Index");

        }
        public ActionResult Delete(int id)
        {

            var logic = new EmployeesLogic();
            try { logic.Delete(id); }
            catch (Exception exception)
            {
                TempData["Mensaje"] = "Error al eliminar un empleado." + exception.Message;
            }
            return RedirectToAction("index");

        }

        public ActionResult Print ()
        {
            return new ActionAsPdf("Report", new { nombre = "prueba" })
            { FileName = "ReportEmployees_.pdf" };
        }
        public ActionResult Report()
        {
            var logic = new EmployeesLogic();
            var employees = logic.GetAll();
            return View(employees);
        }
    }
}
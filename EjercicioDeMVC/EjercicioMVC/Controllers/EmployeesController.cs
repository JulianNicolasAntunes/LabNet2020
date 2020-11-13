using EjercicioMVC.Entity;
using EjercicioMVC.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EjercicioMVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            var logic = new EmployeesLogic();
            var employees = logic.GetAll();
           
            return View(employees);
        }
        //public ActionResult Buscador(String Nombre)
        //{
        //    var busqueda = from s in context.EMPLOYEES select s;
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
            
            logic.Update(emploEntity);
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

            logic.Insert(employeesEntity);

            return Redirect("Index");

        }
        public ActionResult Delete(int id)
        {

            var logic = new EmployeesLogic();
            logic.Delete(id);
            return RedirectToAction("index");

        }
    }
}
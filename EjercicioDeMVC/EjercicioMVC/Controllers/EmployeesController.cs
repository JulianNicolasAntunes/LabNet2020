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
        public ActionResult Insertar()
        {
        
            return View();
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
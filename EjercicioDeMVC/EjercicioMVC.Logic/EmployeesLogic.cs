using EjercicioMVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.Logic
{
    public class EmployeesLogic : Logic, ILogic<EMPLOYEES>
    {
        public void Delete(int entity)
        {
            try
            {
                EMPLOYEES employeesDelete = GetOne(entity);
                context.EMPLOYEES.Remove(employeesDelete);
                context.SaveChanges();
            }
            catch
            { throw new Exception("Error DELEMP"); }
            
        }

        public List<EMPLOYEES> GetAll()
        {
            return context.EMPLOYEES.ToList();
        }

        public EMPLOYEES GetOne(int id)
        {
            return context.EMPLOYEES.First(r => r.ID.Equals(id));
        }
         
        public EMPLOYEES Insert(EMPLOYEES entity)
        {
            try
            {
                entity.ID = GetNextID();
                EMPLOYEES emplo = context.EMPLOYEES.Add(entity);
                context.SaveChanges();
                return emplo;
            }
            catch
            {
                throw new Exception("Error INSEMP");
            }
          
        }

        public void Update(EMPLOYEES entity)
        {
            try
            {
                EMPLOYEES editEmployee = GetOne(entity.ID);
                editEmployee.FIRST_NAME = entity.FIRST_NAME;
                editEmployee.LAST_NAME = entity.LAST_NAME;
                editEmployee.SALARY = entity.SALARY;
                editEmployee.DEPARTMENT_ID = entity.DEPARTMENT_ID;
                editEmployee.JOB_ID = entity.JOB_ID;
                editEmployee.MANAGER_ID = entity.MANAGER_ID;
                context.SaveChanges();
            }
            catch
            {
                throw new Exception("Error UPDEMP");
            }
        }     
        public int GetNextID()
        {
            int lastId = (from t in context.EMPLOYEES
                          orderby t.ID descending
                          select t.ID).FirstOrDefault();
            lastId++;
            return lastId;
        }

    }
}

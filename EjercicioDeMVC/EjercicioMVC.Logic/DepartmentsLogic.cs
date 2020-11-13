using EjercicioMVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.Logic
{
    public class DepartmentsLogic : Logic, ILogic<DEPARTMENTS>
    {
        public void Delete(int entity)
        {
            DEPARTMENTS deleteDepto = GetOne(entity);
            context.DEPARTMENTS.Remove(deleteDepto);
            context.SaveChanges();

        }

        public List<DEPARTMENTS> GetAll()
        {
            return context.DEPARTMENTS.ToList();
        }


        public DEPARTMENTS GetOne(int id)
        {
            return context.DEPARTMENTS.First(r => r.ID.Equals(id));
        }

        public DEPARTMENTS Insert(DEPARTMENTS entity)
        {
            try
            {
                entity.ID = GetNextID();
                DEPARTMENTS depto = context.DEPARTMENTS.Add(entity);
                context.SaveChanges();
                return depto; 
         
            }
            catch
            {
                throw new Exception("error");
            }

        }
        public int GetNextID()
        {
            int lastId = (from t in context.DEPARTMENTS
                          orderby t.ID descending
                          select t.ID).FirstOrDefault();
            lastId++;
            return lastId;
        }
        public void Update(DEPARTMENTS entity)
        {
            DEPARTMENTS editDeparment = GetOne(entity.ID);
            editDeparment.DEPARTMENT_NAME = entity.DEPARTMENT_NAME;
            editDeparment.DEPARTMENT_DESCRIPTION = entity.DEPARTMENT_DESCRIPTION;
            editDeparment.LOCATION_ID = entity.LOCATION_ID;
            context.SaveChanges();
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioMVC.Entity;

namespace EjercicioMVC.Logic
{
    public class LocationsLogic : Logic, ILogic<LOCATIONS>
    {
        public void Delete(int entity)
        {
            LOCATIONS deleteLocation = GetOne(entity);
            context.LOCATIONS.Remove(deleteLocation);
            context.SaveChanges();
        }

        public List<LOCATIONS> GetAll()
        {
            return context.LOCATIONS.ToList();
        }

        public LOCATIONS GetOne(int id)
        {
            return context.LOCATIONS.First(r => r.ID.Equals(id));
        }

        public LOCATIONS Insert(LOCATIONS entity)
        {

            entity.ID = GetNextID();
            LOCATIONS newLocation = context.LOCATIONS.Add(entity);
            context.SaveChanges();
            return newLocation;
        }

        public void Update(LOCATIONS entity)
        {
            LOCATIONS editLocation = GetOne((entity.ID));
            editLocation.CITY = entity.CITY;
            context.SaveChanges();
        }
        public int GetNextID()
        {
            int lastId = (from t in context.LOCATIONS
                          orderby t.ID descending
                          select t.ID).FirstOrDefault();
            lastId++;
            return lastId;
        }
    }
}

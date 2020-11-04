using Lab.Entities;
using Lab.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Lab.Logic
{
    public class TerritoriesLogic : Logic ,ILogic<Territories>
    {
       

        public List<Territories> GetAll()
        {
            Console.WriteLine("Buscando todos los territorios disponibles");
            return context.Territories.ToList();
        }

        public Territories GetOne(int id)
        {
            Console.WriteLine($".............Buscando el territorio {id} ");
            return context.Territories.Find(id);
        }

        public Territories Insert(Territories entity)
        {
            int ultimoId = new Random().Next(0, 100)+1000;
            string ut = ultimoId.ToString();
            entity.TerritoryID = ut;
            Territories Territory = context.Territories.Add(entity);
            context.SaveChanges();
            return Territory;
        }

        public void Update(Territories entity)
        {
            try
            {
                
                Territories terri = GetOne(int.Parse(entity.TerritoryID));
                terri.TerritoryDescription = entity.TerritoryDescription;
               

                context.Entry(terri).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void Delete(int id)
        {
            try
            {
                Territories territorydelete = GetOne(id);
                context.Territories.Remove(territorydelete);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }

}

using Lab.Entities;
using Lab.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class CategoriesLogic :Logic ,ILogic<Categories>
    {
        public void Delete(int id)
        {
            try
            {
                Categories categorydelete = GetOne(id);
                context.Categories.Remove(categorydelete);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<Categories> GetAll()
        {
            Console.WriteLine("Buscando todos las categorias disponibles");
            return context.Categories.ToList();
        }

        public Categories GetOne(int id)
        {
            Console.WriteLine($"............Buscando la categoria {id} ");
            return context.Categories.FirstOrDefault(c => c.CategoryID.Equals(id));
        }

        public Categories Insert(Categories entity)
        {
            
                int ultimoId = new Random().Next(0, 100);
                entity.CategoryID = ultimoId;
                Categories category = context.Categories.Add(entity);
                context.SaveChanges();
                return category;
            
        }

        public void Update(Categories entity)
        {

            Categories terri = GetOne(entity.CategoryID);
            terri.CategoryName = entity.CategoryName;
            terri.Description = entity.Description;

            context.Entry(terri).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
}
  

    }
}

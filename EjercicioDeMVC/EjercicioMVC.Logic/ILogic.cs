using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.Logic
{
    interface ILogic <T>
    {
       List<T> GetAll();
      // T GetOne(T id);
        T GetOne(int id);
        T Insert(T entity);
       void Update(T entity);
       void Delete(int entity);
    }
}

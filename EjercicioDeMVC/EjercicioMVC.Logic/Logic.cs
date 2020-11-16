using EjercicioMVC.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioMVC.Logic
{
   public abstract class Logic
    {
        protected readonly PracticaSQLContext context;
        public Logic()
        {
            this.context = new PracticaSQLContext();
        }
    }
}
 
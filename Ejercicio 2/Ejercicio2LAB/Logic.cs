using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2LAB
{
    class Logic : Exception
    {
        public void Excep()
        {
                throw new Exception();       
        }

       public  void ExcepPerso()
        {
            try
            {
                throw new ExcepcionPersonalizada();

            }
            catch (ExcepcionPersonalizada e)
            {
                Console.WriteLine(e.Message);
            }
        }




    }
}

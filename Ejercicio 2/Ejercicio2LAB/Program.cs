using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Console.WriteLine("ACT 1) Ingrese un numero:");
                int a = Convert.ToInt32(Console.ReadLine());
                Division dividi = new Division(a);
                dividi.Operacion();
                Console.WriteLine("Desea intentar de nuevo:(y/n)");
                opcion = Console.ReadLine();
                opcion.Siguiente();
         

            } while (opcion == "n" );

            do
            {
                Console.Clear();
                Console.WriteLine("ACT 2) Ingrese un numero:");

                Division dividi2 = new Division();
                dividi2.OperacionChuck();
                Console.WriteLine("Desea intentar de nuevo:(y/n)");
                opcion =(Console.ReadLine()) ;
                opcion.Siguiente();


            }
            while (opcion != "n");

            Logic log = new Logic();
            Console.WriteLine("ACT 3)");
            try
            {
                log.Excep();
            }
            catch(Exception e){
                Console.WriteLine(e.Message);

            }
          
            Console.WriteLine("ACT 4)");
            try { log.ExcepPerso(); }
            catch (ExcepcionPersonalizada e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

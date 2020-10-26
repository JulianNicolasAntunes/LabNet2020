using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2LAB
{
    class Division : IOperacion
    {
        private int numeroUno { set; get; }
        private int numeroDos { set; get; }
        private int resultado;

        public Division (int a)
        {
            this.numeroUno = a;
            this.numeroDos = 0;
        }

        public Division()
        {
        }
 

        public void Operacion()
        {
            try
            {
                Console.WriteLine($"Dividiendo {numeroUno} con {numeroDos}");
                resultado = numeroUno / numeroDos;
             
            }
            catch (DivideByZeroException excepCero)
            {
                Console.WriteLine("No se puede dividir por cero");
                Console.WriteLine(excepCero.Message);
            }
        
            finally
            {
                Console.WriteLine("----Operacion finalizada----");
            }


        }

        public void OperacionChuck()
        {
            try
            {
                Console.WriteLine("Ingrese un numero:");
                numeroUno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero:");
                numeroDos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Dividiendo {numeroUno} con {numeroDos}");
                resultado = numeroUno / numeroDos;
                if (numeroDos != 0)
                {
                    Console.WriteLine($"El resultado es: {resultado}");
                }
            }
            catch (DivideByZeroException excepCero)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero!");
                Console.WriteLine(excepCero.Message);
            }
            catch (Exception excep)
            {

                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
                Console.WriteLine(excep.Message);
            }

            finally
            {
                Console.WriteLine("----Operacion finalizada----");
            }
        }
    }
}

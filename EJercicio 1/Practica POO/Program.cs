using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instanciacion de Transportes 
           
            List<Transporte> coleccionTransporte = new List<Transporte>();
            coleccionTransporte.Add(new Avion(1,100));
            coleccionTransporte.Add(new Avion(2,30));
            coleccionTransporte.Add(new Avion(3,10));
            coleccionTransporte.Add(new Avion(4,40));
            coleccionTransporte.Add(new Avion(5,50));

            coleccionTransporte.Add(new Automovil(1,4));
            coleccionTransporte.Add(new Automovil(2,2));
            coleccionTransporte.Add(new Automovil(3,5));
            coleccionTransporte.Add(new Automovil(4,3));
            coleccionTransporte.Add(new Automovil(5,1));

            #endregion
            

            for (int i = 0; i < 10 ; i++)
            {
                Console.WriteLine(coleccionTransporte[i].InformarCantPasajeros()) ;
            }
            Console.ReadKey();
        }


    }
}

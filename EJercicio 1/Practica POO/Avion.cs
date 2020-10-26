using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO
{
    class Avion : Transporte
    {
        

        public Avion(int id, int cantPasajeros) : base(id, cantPasajeros)
        {
        }
        public override void Avanzar()
        {
            Console.WriteLine("Avion - Avanza");
        }
        public override void Retroceder()
        {
            Console.WriteLine("Avion - Retrocede");
        }
        public override String InformarCantPasajeros()
        {
            return "Avion "+id+": " + pasajeros + " Pasajeros";
        }
    }

}

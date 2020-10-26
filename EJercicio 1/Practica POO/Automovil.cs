using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO
{
    class Automovil : Transporte
    {
        public Automovil(int id, int cantPasajeros) : base(id, cantPasajeros)
        {
        }
        public override void Avanzar()
        {
            Console.WriteLine("Auto - Avanza");
        }
        public override void Retroceder()
        {
            Console.WriteLine("Auto - Retrocede");
        }
        public override String InformarCantPasajeros()
        {
            return "Auto "+id+": " + pasajeros + " Pasajeros";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO
{
   abstract class Transporte
    {
       
        protected int pasajeros { get; set; }
        protected int id { get; set; }

        public Transporte(int id,int cantPasajeros)
        {
            this.pasajeros = cantPasajeros;
            this.id = id;
        }
        public virtual void Avanzar()
        {
            Console.WriteLine("Avanzar");
        }
        public virtual void Retroceder()
        {
            Console.WriteLine("Retroceder");
        }
        public virtual String InformarCantPasajeros() {
            return "Cantidad de pasajeros: "+pasajeros;
        }
          
        }
    }

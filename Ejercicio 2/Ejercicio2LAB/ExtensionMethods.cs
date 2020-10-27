using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2LAB
{
    public static class ExtensionMethods
    {
        public static string Siguiente(this string fraseInicial)
        {
            fraseInicial.ToLower();
            if (fraseInicial != "y") 
            {
                fraseInicial = "n";
                return fraseInicial;
            }
           else return fraseInicial;
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.tp2.lab2
{
   public class Transporte :Automotor
    {
        public int CantidadPuertas { get; set; }
        public string Arrancar()
        {
            return "arranco el motor";
        }

        public string Detenerse()
        {
            return "parar";
        }
    }
}

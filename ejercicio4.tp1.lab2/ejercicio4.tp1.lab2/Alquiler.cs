using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4.tp1.lab2
{
    public  class Alquiler
    {
        public Casa Casaalquiler { get; set; }
        public Cliente ClienteAlquiler { get; set; }    
        public int CantidaddePersonas { get; set; }
        public double MontoaPagar { get; set; }
        public int CantidadDedias { get; set; }
        
        public double PagarAlquiler()
        {
            MontoaPagar = CantidadDedias * Casaalquiler.precioXdia;
            return MontoaPagar;
        }
    }
}

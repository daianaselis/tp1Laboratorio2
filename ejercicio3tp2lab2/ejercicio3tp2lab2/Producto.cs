using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3tp2lab2
{
    public class Producto
    {
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public  string DescripcionProducto { get; set; }
        public string tipo { get; set; }
        public DateTime FechayHora { get; set; }
        public double total() {
            return Precio * Cantidad;
        }
      
    }
}

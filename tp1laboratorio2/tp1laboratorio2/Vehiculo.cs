using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1laboratorio2
{
    public class Vehiculo
    {
        public string modelo { get; set; } 
        public string patente { get; set; }
        public string marca { get; set; }
     

        public int Kilometraje { get; set; }
        public virtual string ArrancarMotor() {
            return "El motor arranco";
        }
        public virtual string PararMotor() {
            return "El motor se detuvo";
        }
        public virtual string Conducir() {
            return "brum brum estoy conduciendo";
        }

    }
}

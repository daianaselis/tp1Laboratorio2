using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4.tp1.lab2
{
    public partial class Formulario3 : Form
    {
        Alquiler alquilerActual;
        public Formulario3(Alquiler alquiler)
        {
            InitializeComponent();
            alquilerActual = alquiler;

        }

        private void Formulario3_Load(object sender, EventArgs e)
        {

        }
    }
}

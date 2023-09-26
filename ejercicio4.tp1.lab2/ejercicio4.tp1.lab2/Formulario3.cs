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

            lbl_casarecibo2.Text = alquilerActual.Casaalquiler.Direccion;
            LBLdormitorios.Text = alquilerActual.Casaalquiler.CantidadDormitorios.ToString();
            lbl_F3_CantidadPisos2.Text = alquilerActual.Casaalquiler.CantidadPisos + " Pisos";
            lblcantidadBanios_2.Text = alquilerActual.Casaalquiler.cantidadBanios.ToString() + " Baños";
            CostoxDia_2.Text = "$" + alquilerActual.Casaalquiler.precioXdia.ToString();
            CantidadDias2.Text = alquilerActual.CantidadDedias.ToString();
            lbl_alquilerpagado.Text = "$" + alquilerActual.MontoaPagar.ToString();
        }
    }
}

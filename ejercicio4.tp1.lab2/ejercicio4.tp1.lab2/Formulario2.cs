using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ejercicio4.tp1.lab2
{
    public partial class Formulario2 : Form
    {
        private Casa casaSeleccionada;
        private List<Casa> lista;
        private Cliente clienteActual;
        public Formulario2(Cliente cliente)
        {
            InitializeComponent();
            //aca habria un metodo para traer la lista de casas y ponerla en el combobox
            //para hacer esto como un ejemplo, las voy a poner aca

            lista = new List<Casa>()
            {
                new Casa() {
                   CantidadDormitorios=3,
                   cantidadBanios=2,
                   CantidadPisos=1,
                   Direccion="P.Shermann Calle Wallaby 42 ,Sidney",
                   MetrosCuadrados=75,
                   precioXdia=6000,

                },
                new Casa()
                {
                    CantidadDormitorios=2,
                   cantidadBanios=1,
                   CantidadPisos=2,
                   Direccion="Avenida Siempreviva 742",
                   MetrosCuadrados=60,
                   precioXdia=5000
                },
                new Casa()
                {
                    CantidadDormitorios=3,
                   cantidadBanios=2,
                   CantidadPisos=2,
                   Direccion="Calle falsa 123",
                   MetrosCuadrados=80,
                   precioXdia=7800

                },
                new Casa()
                {
                    CantidadDormitorios=4,
                   cantidadBanios=3,
                   CantidadPisos=2,
                   Direccion="Calle de mentira 66",
                   MetrosCuadrados=90,
                   precioXdia=8500
                }
            };
            clienteActual = cliente;
        }

        private void btn_alquiler_Click(object sender, EventArgs e)
        {
            //crear el alquiler


            Alquiler alquiler = new Alquiler()
            {
                Casaalquiler = casaSeleccionada,
                CantidadDedias = int.Parse(txtBoxCantidaddias.Text),
                CantidaddePersonas = comboBoxPersonas.SelectedIndex + 1,
                ClienteAlquiler = clienteActual,
            };
            alquiler.PagarAlquiler();

            Formulario3 formulario3 = new Formulario3(alquiler);
            formulario3.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            casaSeleccionada = lista[comboBox_Casa.SelectedIndex];
            label_direccion.Text = casaSeleccionada.Direccion;
            lbl_cantidadormitorios.Text = casaSeleccionada.CantidadDormitorios.ToString();
            label3_pisos.Text = casaSeleccionada.CantidadPisos.ToString();
            lblbanios.Text = casaSeleccionada.cantidadBanios.ToString();
      
        }

        private void txtBoxCantidaddias_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtBoxCantidaddias.Text) > 21)
            {
                MessageBox.Show("Solo puede alquilar 21 dias la propiedad...");
                txtBoxCantidaddias.Text = "0";
            }

        }

        private void txtBoxCantidaddias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

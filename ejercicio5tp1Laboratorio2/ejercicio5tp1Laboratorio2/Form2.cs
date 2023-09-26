using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5tp1Laboratorio2
{
    public partial class Form2 : Form
    {
        ClienteVet clienteVet;
        public Form2(ClienteVet clienteVet)
        {
            InitializeComponent();
            this.clienteVet = clienteVet;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            PersonaAnimal mascota = new PersonaAnimal();
            mascota.Nombre = txtBox_NombreMASCOTA.Text;
            mascota.Apellido = txtBox_Apellidomascota.Text;
            mascota.Dni = txt_Box_DniMascota.Text;
            mascota.Raza = textBox_Raza.Text;
            mascota.Edad = int.Parse(textBox_EdadMascota.Text);
            Form3 formulario3 = new Form3(mascota, clienteVet);
            formulario3.ShowDialog();
        }

        private void txt_Box_DniMascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Box_DniMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_EdadMascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_EdadMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBox_NombreMASCOTA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

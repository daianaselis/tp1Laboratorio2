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
    public partial class Form3 : Form
    {
        PersonaAnimal pacienteMascota;
        ClienteVet respPaciente;
        public Form3(PersonaAnimal pacienteMascota, ClienteVet respPaciente)
        {
            InitializeComponent();
            this.pacienteMascota = pacienteMascota;
            this.respPaciente = respPaciente;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lamascota_2.Text = pacienteMascota.Nombre;
            lbl_2_ApellidoMasc.Text = pacienteMascota.Apellido;
            lbl_2_EdadMASc.Text = pacienteMascota.Edad.ToString();
            lblb_eespecie2.Text = pacienteMascota.Especie;
            lbl_Raza2.Text = pacienteMascota.Raza;
            lbl_Nombre_Persona.Text = respPaciente.Nombre;
            lbl_apellidoPersona.Text = respPaciente.Nombre;
            lbl_dni.Text = respPaciente.Dni;
            lbl_direccion.Text = respPaciente.Direccion;
            lbl_telefono1.Text = respPaciente.Celular;
            lbl_email1.Text = respPaciente.email;
            lblb_eespecie2.Text = pacienteMascota.Especie;
        }

        private void lbl_2_ApellidoMasc_Click(object sender, EventArgs e)
        {

        }

        private void lbl_1_ApMasc_Click(object sender, EventArgs e)
        {

        }

        private void lbl_2_EdadMASc_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

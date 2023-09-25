namespace ejercicio4.tp1.lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnConformar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona()
            {
                Nombre = textBoxNombre.Text,
                Apellido = textBoxApellido.Text,
                FechaNac = dateTimePicker1.Value,
                Celular = textBoxCelular.Text,
                Documento = textBoxdni.Text,
                Cuil = textBoxCuil.Text,
            };
            Cliente cliente = new Cliente()
            {
                numeroDecliente = textBoxNroCliente.Text,
            };
            Formulario2 formulario2 = new Formulario2(cliente);
            formulario2.ShowDialog();
        }

        private void textBoxCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
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
namespace ejercicio5tp1Laboratorio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            ClienteVet due�o = new ClienteVet();
            due�o.Nombre = textBoxNombreCliente.Text;
            due�o.Apellido = textBox_Apellidos.Text;
            due�o.Celular = textBox_Celular.Text;
            due�o.Dni = textBox_Dni.Text;
            due�o.Edad = int.Parse(textBox_Edad.Text);
            Form2 formulario2 = new Form2(due�o);
            formulario2.ShowDialog();
        }

        private void textBox_Edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbox_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
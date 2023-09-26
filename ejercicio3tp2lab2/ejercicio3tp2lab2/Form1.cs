namespace ejercicio3tp2lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void brnaceptarf1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.DescripcionProducto = txtbox1.Text;
            producto.Precio = double.Parse(txtBox2.Text);
            producto.Cantidad = (int)numericUpDown1.Value;
            producto.tipo = txtBox3.Text;
            producto.FechayHora = DateTime.Now;
            Form2 formulario2 = new Form2(producto);
            formulario2.Show();
            formulario2.FormClosed += ShowThis;
            this.Hide();
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox2_TextChanged(object sender, EventArgs )
        {
          
        }

        private void ShowThis(object? sender, EventArgs e)
        {
            this.Show();
        }
    }
}
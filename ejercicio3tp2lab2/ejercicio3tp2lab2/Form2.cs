using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3tp2lab2
{
    public partial class Form2 : Form
    {
        Producto producto;
        public Form2(Producto producto)
        {
            InitializeComponent();
            lbl1form2.Text = producto.DescripcionProducto;
            lbl2form2.Text = $"{producto.Precio}";
            lbl3form2.Text = producto.tipo;
            lbl4form2.Text = $"{producto.Cantidad}";
            this.producto = producto;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lbl1form2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(producto);
            form3.ShowDialog();

        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3(Producto producto)
        {
            InitializeComponent();
            labeltotalf3.Text = producto.total().ToString();
            labelfechayhora.Text = $"{producto.FechayHora}";

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

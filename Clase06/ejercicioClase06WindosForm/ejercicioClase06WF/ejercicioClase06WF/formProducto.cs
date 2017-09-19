using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioClase06WF
{
    public partial class formProducto : Form
    {
        static string marca;
        static string barras;
        static string precio;

        public formProducto(Producto prod)
        {
            InitializeComponent();
            
        }

        private void btnAceptarProd_Click(object sender, EventArgs e)
        {
            float precAux;
            marca = txtProductoMarca.Text;
            barras = txtProductoBarras.Text;
            precio = txtProductoPrecio.Text;
            precAux = float.Parse(precio);
            
            
            

        }
    }
}

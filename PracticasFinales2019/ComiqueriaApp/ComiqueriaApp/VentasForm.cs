using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto productoSeleccionado;
        private Comiqueria comiqueria;
        public VentasForm(Comiqueria comiqueria, Producto producto)
        {
            InitializeComponent();
            this.comiqueria = comiqueria;
            this.productoSeleccionado = producto;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionada = Convert.ToInt32(this.numericUpDownCantidad.Value);
            if (productoSeleccionado.Stock >= cantidadSeleccionada)
            {
                this.comiqueria.Vender(this.productoSeleccionado, cantidadSeleccionada);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("La cantidad indicada supera el stock disponible.", "stock superado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = this.productoSeleccionado.Descripcion;
            ActualizarPrecio();
        }

        private void ActualizarPrecio() {
            int cantidadSelccionada = Convert.ToInt32(this.numericUpDownCantidad.Value);
            double nuevoPrecioFinal = Venta.CalcularPrecioFinal(this.productoSeleccionado.Precio, cantidadSelccionada);
            this.lblPrecioFinal.Text = String.Format("Precio Final: $(0:0.00)", nuevoPrecioFinal);
        }

        private void NumericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OnCantidadChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        private void LblPrecioFinal_Click(object sender, EventArgs e)
        {

        }
    }
}

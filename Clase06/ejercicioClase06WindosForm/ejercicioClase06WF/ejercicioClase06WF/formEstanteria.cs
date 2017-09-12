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
    public partial class formEstanteria : Form
    {
        static string cantidad;
        static string ubicacion;

        public formEstanteria()
        {
            InitializeComponent();
        }

        private void btnCrearEstanteria_Click(object sender, EventArgs e)
        {
            int cant, ubi;
            cantidad = txtCapacidadEstanteria.Text;
            ubicacion = txtUbicacionEstanteria.Text;
            cant = int.Parse(cantidad);
            ubi = int.Parse(ubicacion);

            Estante est = new Estante(cant,ubi);

        }
    }
}

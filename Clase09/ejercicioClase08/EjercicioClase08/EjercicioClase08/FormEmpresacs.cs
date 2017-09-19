using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaClases;

namespace EjercicioClase08
{
    public partial class FormEmpresacs : Form
    {
        Empresa _empresa;
        
        public Empresa Empresa
        {
            get
            {
                return this._empresa;
            }
        }
        
        public FormEmpresacs(Empresa empresa)
        {
            InitializeComponent();
            this._empresa = empresa;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}

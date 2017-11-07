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
            float ganancias = float.Parse(this.mtxtGanacias.Text.Replace(".", ",").Substring(1, mtxtGanacias.Text.Length - 1));
            if (this._empresa == null)
            {
                this._empresa = new Empresa(this.txtRazonSocial.Text, this.txtDireccion.Text, ganancias);
            }
            else 
            {
                this._empresa.RazonSocial = this.txtRazonSocial.Text;
                this._empresa.Direccion = this.txtDireccion.Text;
                this._empresa.Ganancias = ganancias;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
            
        }
    }
}

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
    public partial class FormClase08 : Form
    {
        Empresa _empresa;

        
       
        
        public FormClase08()
        {
            InitializeComponent();
        }

        private void FormClase08_Load(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
            btnEmpresa_Click(sender, e);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FormEmpresacs formEmp = new FormEmpresacs(this._empresa);
            formEmp.ShowDialog();
            if (formEmp.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._empresa = formEmp.Empresa;
            }
            else 
            {
                this.Close();
            }
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            cmbPuesto.SelectedIndex = -1;
            mtxtLegajo.Text = "";
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {

        }




    }
}

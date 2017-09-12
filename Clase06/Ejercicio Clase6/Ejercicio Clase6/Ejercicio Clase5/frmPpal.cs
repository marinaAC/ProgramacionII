using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Clase5
{
    public partial class frmPpal : Form
    {
        public frmPpal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProducto frmProd = new frmProducto();
            if (frmProd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show(frmProd.marca);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEstanteria frmEst = new frmEstanteria();

            frmEst.ShowDialog();
        }
    }
}

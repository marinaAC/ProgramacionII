﻿using System;
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
    public partial class formPpal : Form
    {
        public formPpal()
        {
            InitializeComponent();
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            formEstanteria est = new formEstanteria();

            est.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            formProducto prod = new formProducto(producto);
            if(prod.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                listProd.Text = producto.GetMarca();
            }
            this.Hide();
        }

        private void listProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

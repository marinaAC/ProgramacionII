using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ejercicio55
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openfile.FilterIndex = 1;


            openfile.Multiselect = true;

           
            if(openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
            }
        }
    }
}

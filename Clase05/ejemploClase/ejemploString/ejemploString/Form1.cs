using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Tenemos dos tipos, tipo String, que es el metodo estatico y
            // el tipo string que nos permite crear la clase e instanciarla;
            string a = "hola";

            //String.compare(a,"hola").ToString();

            String.Concat("ho","la");

            MessageBox.Show(a.CompareTo("hola").ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

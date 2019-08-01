using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesHechas;

namespace _20171123_SP_Cartas
{
    public partial class FrmPpal : Form
    {
        Correo correo;

        public FrmPpal()
        {
            InitializeComponent();

            correo = new Correo();
        }

        /// <summary>
        /// Si se produce un cambio de estado, actualizo todos los estados de los paquetes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                //vinculacion
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
                ActualizarEstados();
        }

        /// <summary>
        /// Muestro la información de todos los paquetes del correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        /// <summary>
        /// Muestro la información de un paquete en particular de la lista de Entregados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

        /// <summary>
        /// Al cerrarse el formulario, termino todos los hilos en ejecución.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }

        /// <summary>
        /// Comprueba y actualiza los estados de envio de los paquetes,
        /// colocando cada paquete en el ListBox correspondiente.
        /// </summary>
        private void ActualizarEstados()
        {
            // Limpio las listas
            lstEstadoIngresado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoEntregado.Items.Clear();

            foreach (Paquete item in correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        lstEstadoIngresado.Items.Add(item);
                        break;
                    case Paquete.EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(item);
                        break;
                    case Paquete.EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(item);
                        break;
                }
            }
        }

        #region Alumno

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                Paquete p = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
                p.InformarEstado += paq_InformaEstado;
                p.InformarDAO += InformarError;
                correo +=p;
                this.ActualizarEstados();
            }
            catch (TrackingRepetidoException exception)
            {
                MessageBox.Show(exception.Message,"Se encuentra repetido el tracking ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            
        }

        private void InformarError(Paquete paquete,Exception e)
        {
            string mensaje = String.Format("Ocurrio un error al intentar cargar en la base de datos el paquete {0}. ERROR: {1}",paquete.ToString(),e.Message);
            MessageBox.Show(mensaje,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);       
        }

        /// <summary>
        /// Mostrará la información del elemento en RichTextBox rtbMostrar
        /// y utilizará el método de extensión para guardar el texto en this.rtbMostrar.Text
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (!object.ReferenceEquals(elemento, null))
            {
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento);
                // Agregar línea para guardar el archivo con el nombre "salida.txt"
                GuardaString.Guardar(this.rtbMostrar.Text,"salida.txt");

            }
        }

        #endregion
    }
}

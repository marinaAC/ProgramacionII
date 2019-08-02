using BusinessLogic;
using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Pantalla principal.
    /// </summary>
    public partial class PrincipalForm : Form
    {
        /// <summary>
        /// Empresa.
        /// </summary>
        private Empresa empresa;

        /// <summary>
        /// Constructor.
        /// </summary>
        public PrincipalForm()
        {
            InitializeComponent();
            this.empresa = new Empresa();
        }

        /// <summary>
        /// Manejador del evento OnLoad del formulario. 
        /// Inicializará el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            this.Inicializar();
            this.ActualizarLista();
            this.empresa.OnChange += ActualizarLista;
            // M1. ACÁ ASOCIAR EVENTO ONCHANGE DE EMPRESA.
        }

        /// <summary>
        /// Inicializa los controles.
        /// </summary>
        private void Inicializar()
        {
            this.comboArea.Items.Add("RRHH");
            this.comboArea.Items.Add("Sistemas");
            this.comboArea.Items.Add("Gerencia");
            this.comboArea.Items.Add("Finanzas");
            this.comboArea.SelectedIndex = 0;
            this.radioEmpleado.Select();
        }

        /// <summary>
        /// Actualiza la lista de usuarios.
        /// </summary>
        private void ActualizarLista()
        {
            this.txtListaUsuarios.Invoke(new MethodInvoker(delegate
            {
                this.txtListaUsuarios.Text = this.empresa.ToString();
            }));
        }

        /// <summary>
        /// Registra un nuevo usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validar())
                {
                    string nombre = this.txtNombre.Text;
                    string cuenta = this.txtCuenta.Text;
                    string clave = this.txtClave.Text;
                    Usuario usuario = null;

                    if (this.radioEmpleado.Checked)
                    {
                        Empleado.Area area;
                        Enum.TryParse(this.comboArea.SelectedItem.ToString(), out area);
                        usuario = new Empleado(nombre, cuenta, clave, area);
                    }
                    else
                    {
                        usuario = new Externo(nombre, cuenta);
                    }

                    this.empresa.Registrar(usuario);
                }     
            }
            catch (Exception ex)
            {
                this.txtSalida.Text += "*" + DateTime.Now.ToShortTimeString() + " - " +  ex.Message + "\n";
            }
        }

        /// <summary>
        /// Valida el formulario.
        /// </summary>
        /// <returns>Retornará true si todos los campos son válidos.</returns>
        private bool Validar()
        {
            string nombre = this.txtNombre.Text;
            string cuenta = this.txtCuenta.Text;
            string clave = this.txtClave.Text;

            if(String.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("Debe ingresar un nombre");
            }

            if (String.IsNullOrWhiteSpace(cuenta))
            {
                throw new Exception("Debe ingresar una cuenta");
            }

            if (String.IsNullOrWhiteSpace(clave))
            {
                throw new Exception("Debe ingresar una clave");
            }

            return true;
        }

        /// <summary>
        /// Manejador del evento OnChange de los radio buttons.
        /// Habilitará/deshabilitará el combo de áreas de trabajo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioEmpleado.Checked)
            {
                this.comboArea.Enabled = true;
            }
            else
            {
                this.comboArea.Enabled = false;
            }
        }
    }
}

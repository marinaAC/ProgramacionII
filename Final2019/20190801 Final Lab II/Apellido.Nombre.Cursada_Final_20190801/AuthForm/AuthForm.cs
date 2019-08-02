using BusinessLogic;
using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Pantalla de autenticación.
    /// </summary>
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAO.Autenticar(txtUser.Text, txtPassword.Text);
                this.Visible = false;
                PrincipalForm pform = new PrincipalForm();
                pform.Visible = true;
            }
            catch (BusinessException error)
            {
                
                string path = String.Format("{0}Log.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                Impresora imp = new Impresora(path, true);
                imp.GenerarArchivo(error);
                throw error;

            }
            catch (Exception error) {
                MessageBox.Show(error.Message,"Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Visible = true;
            }
            

        }
    }
}

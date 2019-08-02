using System;
using System.Collections.Generic;
using System.Threading;

namespace BusinessLogic
{
    /// <summary>
    /// Representa a la empresa.
    /// </summary>
    public class Empresa
    {
        public delegate void Accion();
        public event Accion OnChange;
        /// <summary>
        /// Lista de usuarios de la empresa.
        /// </summary>
        private List<Usuario> usuarios;
        /// <summary>
        /// Objeto serializador.
        /// </summary>
        private static Serializador<List<Usuario>> serializador;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Empresa()
        { 
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Usuarios.xml";
            Empresa.serializador = new Serializador<List<Usuario>>(ruta);
            this.usuarios = new List<Usuario>();
            this.ActualizarEnParalelo();
        }

        /// <summary>
        /// Actualiza la lista de usuarios deserializando el XML.
        /// </summary>
        private void Actualizar()
        {
            this.usuarios = Empresa.serializador.Deserializar();
            this.OnChange();
            //L5a. Lanzar el evento OnChange.
        }

        /// <summary>
        /// Inicia un hilo para actualizar la lista de usuarios en paralelo.
        /// </summary>
        private void ActualizarEnParalelo()
        {
            Thread hilo = new Thread(this.Actualizar);
            hilo.Start();
        }

        /// <summary>
        /// Registra un nuevo usuario en el sistema.
        /// </summary>
        /// <param name="usuario"></param>
        public void Registrar(Usuario usuario)
        {
            if (this != usuario)
            {
                try
                {
                    this.usuarios.Add(usuario);
                    Empresa.serializador.Serializar(this.usuarios);
                    UsuarioDAO.Registrar(usuario);
                    this.OnChange();
                    //L5a. Lanzar el evento OnChange.
                }
                catch (Exception ex)
                {
                    this.usuarios.Remove(usuario);
                    throw ex;
                }
            }
            else
            {
                throw new BusinessException("El usuario ya se encuentra registrado.");
            }
        }

        public override string ToString()
        {
            string listaConcatenada=Extension.ListarUsuarios(String.Empty, this.usuarios);
            return listaConcatenada;
        }

        public static bool operator ==(Empresa e, Usuario u)
        {
            bool existe = false;
            foreach (Usuario us in e.usuarios)
            {
                if (us.Cuenta==u.Cuenta)
                {
                    existe = true;
                }
            }
            return existe;
        }

        public static bool operator !=(Empresa e, Usuario u) {
            bool existe = true;
            if (e==u) {
                existe = false;
            }
            return existe;
        }

         

    }
}

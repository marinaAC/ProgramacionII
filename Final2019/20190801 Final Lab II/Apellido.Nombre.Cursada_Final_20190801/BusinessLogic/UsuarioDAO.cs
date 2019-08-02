using System;
using System.Data.SqlClient;

namespace BusinessLogic
{
    /// <summary>
    /// Data Access Object para la tabla Usuarios de la base de datos Final.
    /// </summary>
    public static class UsuarioDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static UsuarioDAO()
        {
            conexion = new SqlConnection(@"Server=LAB3PC11\SQLEXPRESS;Database=Final;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }
        /// <summary>
        /// Registra un usuario en la base de datos.
        /// </summary>
        /// <param name="usuario">Objeto usuario con nombre de cuenta y clave.</param>
        public static void Registrar(Usuario usuario)
        {
            try
            {
                comando.CommandText = "INSERT INTO dbo.Usuarios (cuenta, clave) VALUES (@cuenta, @clave);";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@cuenta", usuario.Cuenta);
                comando.Parameters.AddWithValue("@clave", usuario.Clave);             
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //lanzar excepcion
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public static bool Autenticar(string cuenta,string clave)
        {
            bool existe = false;
            try
            {
                comando.CommandText = "SELECT * FROM dbo.Usuarios";
                conexion.Open();
                SqlDataReader sqlReader = comando.ExecuteReader();
                while (sqlReader.Read())
                {
                    string cuentaAux = sqlReader["cuenta"].ToString();
                    string claveAux = sqlReader["clave"].ToString();
                    if (cuenta==cuentaAux && claveAux==clave)
                    {
                        existe = true;
                    }
                }
            }
            catch (Exception e)
            {
                throw new BusinessException("Nombre de la cuenta o clave incorrectos. Por favor, reintentar");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            if (!existe) {
                throw new BusinessException("Nombre de la cuenta o clave incorrectos. Por favor, reintentar");
            }

            return existe;
        }
        
    }
}

using ComiqueriaLogic.Execpciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.BaseDatos
{
    public abstract class ConexionDb
    {
        #region Atributos
        private static SqlConnection conexion;
        private static SqlCommand comando;
        protected static AccionesDB ultimaAccion;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor statico que crea la conexion a la base de datos
        /// </summary>
        static ConexionDb() {
            ConexionDb.conexion = new SqlConnection(@"Server=LAPTOP-NDLG9NDT\SQLEXPRESS;Database=Comiqueria;Trusted_Connection=True;");
            ConexionDb.comando = new SqlCommand();
            ConexionDb.comando.Connection = ConexionDb.conexion;
        }
        #endregion

        #region Propiedades
        protected static SqlConnection Conexion {
            get {
                return ConexionDb.conexion;
            }
        }

        protected static SqlCommand Comando{
            get {
                return ConexionDb.comando;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Ejecuta la conexion chequeando que no haya un error, si lo hay arroja una excepcion y cierra la conexion luego de verificar su estado
        /// </summary>
        protected static void Ejecutar() {
            try
            {
                ConexionDb.Conexion.Open();
                ConexionDb.Comando.ExecuteNonQuery();
            }catch(Exception e)
            {
                throw new ComiqueriaException("Ocurrio un error en la base de datos", e);
            }
            finally
            {
                if (ConexionDb.Conexion.State == System.Data.ConnectionState.Open) {
                    ConexionDb.Conexion.Close();
                }
            }
        }
        #endregion

    }
}

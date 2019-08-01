using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesHechas
{
    public static class PaqueteDao
    {
        private static  SqlCommand comando;
        private static  SqlConnection conexion;

        static PaqueteDao() {
            conexion = new SqlConnection(@"Server=LAPTOP-NDLG9NDT\SQLEXPRESS;Database=correo-sp-2017;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public static bool Insertar(Paquete p) {

            bool insertado = true;
            string entrega = p.DireccionEntrega;
            string trackingId = p.TrackingID;
            string alumno = "Marina Cardozo";
            try
            {
                conexion.Open();
                comando.CommandText = "INSERT INTO dbo.paquetes (direccionEntrega,trackingID,alumno) VALUES (@entrega,@trackingID,@alumno);";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@entrega", entrega);
                comando.Parameters.AddWithValue("@trackingID", trackingId);
                comando.Parameters.AddWithValue("@alumno", alumno);
                comando.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                insertado = false;
                throw new Exception("Ocurrio un error al intentar agregarlo a la base de datos",e);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return insertado;
        }
    }
}

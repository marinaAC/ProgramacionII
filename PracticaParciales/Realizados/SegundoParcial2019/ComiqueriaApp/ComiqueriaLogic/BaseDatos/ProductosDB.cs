using ComiqueriaLogic.Execpciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.BaseDatos
{
    public class ProductosDB: ConexionDb
    {
        public delegate void ProductoDBDelegate(AccionesDB accion);
        public static event ProductoDBDelegate ProductosDBChanged;

        public static void Insert(string descripcion, double precio, int stock) {
            Comando.CommandText = "INSERT INTO dbo.Productos (descripcion, precio, stock) VALUES (@descripcion, @precio, @stock);";
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@descripcion", descripcion);
            Comando.Parameters.AddWithValue("@precio",precio);
            Comando.Parameters.AddWithValue("@stock",stock);
            Ejecutar();
            ProductosDBChanged.Invoke(AccionesDB.Insert);
        }

        public static void Update(int codigo, double nuevoPrecio) {
            Comando.CommandText = "UPDATE dbo.Productos SET precio = @nuevoPrecio WHERE codigo = @codigo ;";
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@codigo",codigo);
            Comando.Parameters.AddWithValue("@nuevoPrecio",nuevoPrecio);
            Ejecutar();
            ProductosDBChanged.Invoke(AccionesDB.Update);
        }

        public static void Delete(int codigo) {
            Comando.CommandText = "DELETE FROM dbo.Productos WHERE codigo = @codigo";
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@codigo", codigo);
            Ejecutar();
            ProductosDBChanged.Invoke(AccionesDB.Delete);
        }

        public static List<Producto> SelecctAll(){
            List<Producto> productos = new List<Producto>();
            try
            {
                Comando.CommandText = "SELECT * FROM dbo.Productos";
                Conexion.Open();
                SqlDataReader sqlReader = Comando.ExecuteReader();
                while (sqlReader.Read()) {
                    int codigo = Convert.ToInt32(sqlReader["codigo"]);
                    string descripcion = sqlReader["descripcion"].ToString();
                    double precio = Convert.ToDouble(sqlReader["precio"]);
                    int stock = Convert.ToInt32(sqlReader["stock"]);
                    Producto producto = new Producto(codigo, descripcion, stock, precio);
                    productos.Add(producto);
                }
            }
            catch (Exception e)
            {
                throw new ComiqueriaException("Ocurrio un problema al tratar de leer todos los elementos ", e);
            }
            finally
            {
                if (Conexion.State == System.Data.ConnectionState.Open) {
                    Conexion.Close();
                }
            }

            return productos;

        }
    }
}

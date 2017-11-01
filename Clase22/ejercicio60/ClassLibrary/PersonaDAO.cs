using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class PersonaDAO
    {

        public static bool Guardar(SqlConnection conexion, Persona p) 
        {
            bool returnAux = false;
            string scriptInsert = string.Format("INSERT INTO Persona (Nombre,Apellido) values ('{0}','{1}')", p.Nombre,p.Apellido);
            SqlCommand insertPersona = new SqlCommand(scriptInsert);
            try
            {
                conexion.Open();
                insertPersona.ExecuteNonQuery();
                returnAux = true;
            }
            catch (Exception e)
            {

            }
            finally 
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return returnAux;
        }

        
        public static bool Leer(SqlConnection conexion, List<Persona> personas) 
        {
            bool returnAux = false;
            string s = string.Format("select * from Persona");
            SqlCommand cargarList = new SqlCommand(s);
            if(personas.Count<0)
            {
                conexion.Open();
                SqlDataReader basePersona = cargarList.ExecuteReader();
                while (basePersona.Read())
                {
                    string id = basePersona["Id"].ToString();
                    string nombre = basePersona["Nombre"].ToString();
                    string apellido = basePersona["Apellido"].ToString();
                    Persona p = new Persona(id,nombre,apellido);
                    personas.Add(p);
                    
                }
                returnAux = true;
            }


            try
            {
                conexion.Open();


            }
            catch (Exception)
            {
                
                throw;
            }
             
        }
        public static bool LeerPorId(SqlConnection conexion, Persona p) 
        {
            bool returnAux = false;
            string s = string.Format("select * from Persona p where p.id = {0}", p.Id);
            SqlCommand selectId = new SqlCommand(s);
            try
            {
                conexion.Open();
                SqlDataReader basePersona = selectId.ExecuteReader();
                while (basePersona.Read())
                {
                        p.Nombre = basePersona["Nombre"].ToString();
                        p.Apellido = basePersona["Apellido"].ToString();
                        returnAux = true;
                }
          
            }
            catch (Exception)
            {

                throw new Exception();
            }

            return returnAux;
        }
        /*
        public static bool Modificar() { }
        public static bool Borrar() { }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Empresa
    {
        #region Atributos
        private List<Empleado> _nominaEmpleados;
        private string  _razonSocial;
        private string _direccion;
        private float _ganancias;
        #endregion

        #region Constructores
        private Empresa() 
        {
            this._nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razonSocial, string direccion, float ganancias) : this() 
        {
            this._razonSocial = razonSocial;
            this._ganancias = ganancias;
            this._direccion = direccion;
        }
        #endregion

        #region Propertys
        public float Ganancias
        {
            get { return _ganancias; }
            set { _ganancias = value; }
        }
        
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        
        public string  RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }
        #endregion

        #region Metodos
        public static bool operator +(Empresa e, Empleado emp)
        {
            bool returnAux = true;
            foreach(Empleado element in e._nominaEmpleados)
            {
                if(element == emp)
                {
                    returnAux = false;
                }
            }
            if(returnAux == true)
            {
                e._nominaEmpleados.Add(emp);
            }

            return returnAux;
        }

        public string MostrarEmpresa() 
        {
            string resultAux;

            resultAux = string.Format("La empresa {0} sita en la calle {1} cuenta con ganancias por {2} y con {3} empleados: {4}",
                        this._razonSocial,this._direccion,this._ganancias);
            foreach (Empleado element in this._nominaEmpleados) 
            {
                resultAux += element.MostrarEmpleado();
            }

            return resultAux;
        }
        #endregion
    }
}

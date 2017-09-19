using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    class Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _legajo;
        private EPuestoJerarquico _puesto;
        private int _salario;

        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario) 
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;
            this._puesto = puesto;
            this._salario = salario;
        }

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            bool returnAux = false;
            if(e1._legajo == e2._legajo)
            {
                returnAux = true;
            }

            return returnAux;
        }

        public string MostrarEmpleado() 
        {
            string returnAux = string.Format("Nombre: {0} Apellido {1} Legajo {2}", this._nombre, this._apellido, this._legajo);
            return returnAux;
        }

    }
}

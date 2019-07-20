using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;
        

        private Lavadero() 
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        
        
	    public string Lavadero
	    {
		    get 
            {   string returnAux = String.Format("Precios Auto{0} Camion{1} Moto{2}",this._precioAuto,this._precioCamion,this._precioMoto);
                foreach(Vehiculo element in this._vehiculos)
                {
                    if(element is Auto)
                    {
                       returnAux += ((Auto)element).MostrarAuto();
                    }
                    if(element is Camion)
                    {
                        returnAux += ((Camion)element).MostrarCamion();
                    }
                    if(element is Moto)
                    {
                        returnAux += ((Moto)element).MostrarMoto();
                    }
                }
                return returnAux;
            }
		   
	    }

        public double MostrarTotalFacturado(EVehiculo v) 
        {
            double resultAux = 0; ;
            foreach (Vehiculo element in this._vehiculos) 
            {

                if(element is Auto && v == EVehiculo.Auto)
                {
                    resultAux += this._precioAuto;
                }
                if(element is Camion && v == EVehiculo.Camion)
                {
                    resultAux += this._precioCamion;
                }
                if (element is Moto && v == EVehiculo.Moto) 
                {
                    resultAux += this._precioMoto;
                }
            }
            return resultAux;
        }

        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            bool resultAux = false;
            foreach(Vehiculo element in l._vehiculos)
            {
                if(element == v)
                {
                    resultAux = true;
                }
            }
            return resultAux;
        }

        public static bool operator +(Lavadero l, Vehiculo v)
        {
            bool resultAux = false;
            if(!(l==v))
            {
                l._vehiculos.Add(v);
                resultAux = true;
            }
            return resultAux;
        }

        public static bool operator -(Lavadero l, Vehiculo v)
        {
            bool resultAux = false;
            if(l==v)
            {
                l._vehiculos.Remove(v);
                resultAux = true;
            }
            return resultAux;
        }


        /// Preguntar como puedo acceder a los atributos protegidos de los vehiculos
        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2) 
        {
            int returnAux;

            if (v1.Patente == v2.Patente) 
            {
                returnAux = 0;
            }
            else if (string.Compare(v1.Patente,v2.Patente)==1)
            {
                returnAux = 1;
            }
            else 
            {
                returnAux = -1;
            }

            return returnAux;
           // Lavadero._vehiculos.sort();
        }
        
	
    }
}

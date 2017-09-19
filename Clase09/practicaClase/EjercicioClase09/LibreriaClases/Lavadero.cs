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
            foreach (Vehiculo element in this._vehiculos) 
            {
                if(element is Auto && v == EVehiculo.Auto)
                {}
            }
        }
	
    }
}

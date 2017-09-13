using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public Cliente Clientes
        {
            get { return this.clientes.Dequeue(); }
            set 
            { 
               // this.clientes.Enqueue(value); 
               if(this!=value)
               {
                   bool returnAux = this + value;
               }
            }
        }
        

        public PuestoAtencion Caja
        {
            get { return caja; }
            set { caja = value; }
        }

        private Negocio() 
        {
            this.caja = new PuestoAtencion(Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre):this() 
        {
            this.nombre = nombre;
        }


        public static bool operator +(Negocio n, Cliente c)
        {
            bool returnAux = false;
            long lenght = n.clientes.LongCount();
            n.Clientes = c;
            if(lenght!=n.clientes.LongCount())
            {
                returnAux = true;
            }

            return returnAux;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            bool returnAux = true;
            if(n==c)
            {
                returnAux = false;
            }

            return returnAux;
        }

        public static bool operator ==(Negocio n, Cliente c) 
        {
            bool returnAux = false;
            foreach (Cliente element in n.clientes)
            {
                if (c.Numero == element.Numero)
                {
                    returnAux = true;
                    break;
                }
            }

            return returnAux;
        }
        
      
    }
}

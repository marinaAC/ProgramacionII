using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Contabilidad<T,U> 
        where T : Documento
        where U : new()
    {
        private List<T> egresos = new List<T>();
        private List<U> ingresos = new List<U>();

        public int CantidadT 
        {
            get 
            {
                return egresos.Count();
            }
        }

        public int CantidadU
        {
            get 
            {
                return ingresos.Count();
            }
        }



        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            int flag = 0;
            foreach (T element in c.egresos) 
            {
               if(element == egreso)
               {
                   flag = 1;
               } 
            }
            if(flag == 0)
            {
                c.egresos.Add(egreso);
            }

            return c;
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, U ingreso)
        {
            int flag = 0;
            foreach(U element in c.ingresos)
            {
                if(element.Equals(ingreso))
                {
                    flag = 1;
                }
            }
            if(flag==0)
            {
                c.ingresos.Add(ingreso);
            }
            return c;
        }
    }
}

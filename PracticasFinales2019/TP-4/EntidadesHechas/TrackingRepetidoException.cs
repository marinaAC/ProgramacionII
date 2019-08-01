using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesHechas
{
    public class TrackingRepetidoException:Exception
    {
        public TrackingRepetidoException(string mensaje):base(mensaje) { }

        public TrackingRepetidoException(string mensaje, Exception e) : base(mensaje,e) { }
    }
}

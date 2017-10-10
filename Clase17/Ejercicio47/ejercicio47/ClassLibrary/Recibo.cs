using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Recibo: Documento
    {
        
        public Recibo(int num) : base(num) { }

        public Recibo() : base(0) { }
       
    }
}

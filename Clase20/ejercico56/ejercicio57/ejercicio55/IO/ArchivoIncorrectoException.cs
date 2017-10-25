using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class ArchivoIncorrectoException :Exception
    {
        public ArchivoIncorrectoException(string men): base(men) 
        {
            
        }

        public ArchivoIncorrectoException(string men, Exception innerExecption) : this(men) { }
    }
}

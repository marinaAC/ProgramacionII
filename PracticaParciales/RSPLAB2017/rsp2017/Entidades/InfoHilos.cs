using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Interfaces;


namespace Entidades
{
    class InfoHilos
    {
        protected int id;
        protected Random randomizer;
        protected Thread hilo;
        protected IRespuesta<int> callback;
         
        

        
    }
}

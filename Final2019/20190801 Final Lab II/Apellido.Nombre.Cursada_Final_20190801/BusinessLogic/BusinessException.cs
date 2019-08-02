using System;

namespace BusinessLogic
{
    /// <summary>
    /// Excepción relacionada a la lógica de negocio.
    /// </summary>
    public class BusinessException:Exception,IImpresora
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="mensaje">Mensaje de la excepción.</param>
        public BusinessException(string mensaje):base(mensaje)
        {

        }

        public string Imprimir()
        {
            string texto = String.Format("{0}-{1}",DateTime.Now,this.Message);
            return texto;
        }
    }
}

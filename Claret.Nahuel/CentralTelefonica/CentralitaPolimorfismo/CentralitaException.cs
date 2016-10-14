using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class CentralitaException:Exception
    {
        protected Exception _ExcepcionInterna;
        protected string _nombreClase;
        protected string _nombreMetodo;

        public Exception ExcecpionInterna { get { return this._ExcepcionInterna; } }
        public string NombreClase { get { return this._nombreClase; } }
        public string NombreMetodo { get { return this._nombreMetodo; } }

        public CentralitaException(string mensaje, string clase, string metodo):this(mensaje,clase,metodo,null)
            
        {
            
            
        }
        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje,innerException)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
             
        }
    }
}

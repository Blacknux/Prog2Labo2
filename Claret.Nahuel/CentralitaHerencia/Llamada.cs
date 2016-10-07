using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
   public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion { get {return this._duracion ;} }
        public string NroDestino { get { return this._nroDestino; } }
        public string NroOrigen{ get { return this._nroOrigen; } }


        public Llamada(float duracion, string nroDest, string nroOri)
        {
            this._duracion = duracion;
            this._nroDestino = nroDest;
            this._nroOrigen = nroOri;
        }

        public void Mostrar()
        {
            StringBuilder retorno;
            retorno = new StringBuilder();
            retorno.AppendLine("Duracion: " + this.Duracion);
            retorno.AppendLine("Destino: " + this.NroDestino);
            retorno.AppendLine("Origen: " + this.NroDestino);
            Console.WriteLine(retorno);
        }

        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            int retorno;

            retorno = llamada1.Duracion.CompareTo(llamada2.Duracion);
            return retorno;
        
        }

    }
}

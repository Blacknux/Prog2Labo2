using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float _costo;

        public float CostoLLamada { get {return this.ClacularCosto() ;} }

        public Local(Llamada llama1, float costo)
            : base(llama1.Duracion, llama1.NroDestino, llama1.NroOrigen)
        {
            this._costo = costo;
        
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, origen, destino)
        {
            this._costo = costo;
        }

        private float ClacularCosto()
        {
            return this._costo * this.Duracion;
        }

        public void Mostrar()
        {
            StringBuilder string1=new StringBuilder();
            base.Mostrar();
            string1.AppendLine(" Costo : " + this.CostoLLamada);
            Console.WriteLine(string1);
            
        }

    }
}

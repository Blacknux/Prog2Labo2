using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        Franja _franjaHoraria;

        public float CostoLLamada { get {return this.CalcularCosto() ;} }

        public Provincial(Franja miFranja, Llamada unallamada)
            : base(unallamada.Duracion, unallamada.NroDestino, unallamada.NroOrigen)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja franja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this._franjaHoraria = franja;
        }

        private float CalcularCosto()
        { 
            float costo;
            if (this._franjaHoraria == Franja.Franja_1)
            {
                costo = (float)0.99*this.Duracion;
            }
            else if (this._franjaHoraria == Franja.Franja_2)
            { 
                costo=((float)1.25 * this.Duracion);

            }
            else
            {
                costo = (float)0.66 * this.Duracion;
            }

            return costo;
         }

        public void Mostrar()
        {
            StringBuilder string1 = new StringBuilder();
            base.Mostrar();
            string1.AppendLine(" Costo : " + this.CostoLLamada);
            Console.WriteLine(string1);
        
        }
    }
}

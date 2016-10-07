using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal { get { return CalcularGanancias(TipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return CalcularGanancias(TipoLlamada.Provincial); } }
        public float GananciaTotal { get { return CalcularGanancias(TipoLlamada.Todas); } }
        public List<Llamada> LLamadas { get {return this._listaDeLlamadas ;} }

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string rSocial)
            : this()
        {
            this._razonSocial = rSocial;
        }

        private float CalcularGanancias(TipoLlamada tipo)
        {
            float ganancia=0;

            foreach (Llamada item in this.LLamadas)
            { 
                if(item is Local && tipo == TipoLlamada.Local)
                {
                    ganancia += ((Local)item).CostoLLamada;
                }
                else if (item is Provincial && tipo == TipoLlamada.Provincial)
                {
                    ganancia += ((Provincial)item).CostoLLamada;
                    
                }
                else 
                    {
                        if (item is Local)
                        {
                            ganancia += ((Local)item).CostoLLamada;
                        }
                        else
                        {
                            ganancia += ((Provincial)item).CostoLLamada;
                        }
                    }
            }
            return ganancia;
        }

        public void Mostrar()
        {
            Console.WriteLine(this._razonSocial);
            Console.WriteLine("La ganancia total es: " + this.GananciaTotal);
            Console.WriteLine("La ganancia por Local es: " + this.GananciaPorLocal);
            Console.WriteLine("La ganancia por provincial es: " + this.GananciaPorProvincial);
            Console.WriteLine("Las llamadas que se realizaron son: ");
            foreach (Llamada item in this.LLamadas)
            {
                if (item is Local)
                {
                    ((Local)item).Mostrar();
                }
                else
                {
                    ((Provincial)item).Mostrar();
                }


            }


        
        }

    //    public static OrdenarPorDuracion(Llamada ll1, Llamada ll2);
    //{
        
    //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Moneda
    {
        ELado _lado;

        public Moneda()
        {

                  
        }

        public ELado Lado { get { return this._lado; }}

        public void Tirar(ELado lado)
        {
            Random r = new Random();
            int num = r.Next(2);
            this._lado = (ELado)num;
            if(this.Lado == lado)
            {
                this.Ganar(); 
            }
            else
            {
                this.Perder(this._lado); 
            }
        
        }

        public event MonedaWins Ganar;
        public event MonedaLoose Perder; 
    }
}

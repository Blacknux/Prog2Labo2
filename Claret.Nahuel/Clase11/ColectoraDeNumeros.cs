using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11
{
    public class ColectoraDeNumeros
    {
        protected List<Numero> _numeros;
        public ETipoNumero TipoNumero { get; set; }
        


        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }
        public ColectoraDeNumeros(ETipoNumero tipo)
            : this()
        {
            this.TipoNumero = tipo;
        }

        public int SumaDeNumeros {
            
            get{
                return (int)ColectoraDeNumeros.ObtenerResultado(this, ETipoResultado.Suma);


                }
            //set;
        }
        public int RestaDeNumeros
        {

            get
            {

                return (int)ColectoraDeNumeros.ObtenerResultado(this, ETipoResultado.Resta);



            }
           // set;
        }
        public int MultiplicacionDeNumeros
        {

            get
            {

                return (int)ColectoraDeNumeros.ObtenerResultado(this, ETipoResultado.Multiplicacion);
            }
        }
        public double DivisionDeNumeros
        {

            get
            {
                
               
                return ColectoraDeNumeros.ObtenerResultado(this,ETipoResultado.Division);


            }
           // set;
        }
        public enum ETipoResultado{Suma, Resta, Multiplicacion, Division};
        protected static double ObtenerResultado(ColectoraDeNumeros colectora, ETipoResultado tipoRes)
        {
            double retorno=0;
            switch (tipoRes)
            { 
                case ETipoResultado.Division:
                    
                    for (int i = 1; i < colectora._numeros.Count; i++)
                    {
                        retorno /= colectora._numeros[0] / colectora._numeros[i];

                    }
                    
                    break;
                case ETipoResultado.Multiplicacion:

                        for (int i = 1; i < colectora._numeros.Count; i++)
                    {
                        retorno *= colectora._numeros[0] * colectora._numeros[i];

                    }   
                    break;
                case ETipoResultado.Resta:


                    for (int i = 1; i < colectora._numeros.Count; i++)
                    {
                        retorno -= colectora._numeros[0] - colectora._numeros[i];

                    }
                    break;
                case ETipoResultado.Suma:
                    for (int i = 1; i < colectora._numeros.Count; i++)
                    {
                        retorno += colectora._numeros[0] + colectora._numeros[i];

                    }
                    break;
                  
            }
            return retorno;
        }



        public static ColectoraDeNumeros operator +(ColectoraDeNumeros colectora, Numero numero)
        {
            //bool flag = false;
            //foreach (Numero item in colectora._numeros)
            //{
            //    if (item == numero)
            //    {
            //        flag = true;
            //        break;
            //    }
                
            //}
            //if (!flag)
            //{
                colectora._numeros.Add(numero);
            //}

            return colectora;
            
            
        }

       

        public static ColectoraDeNumeros operator -(ColectoraDeNumeros colectora, Numero numero)
        {
            
            //foreach (Numero item in colectora._numeros)
            //{
            //    if (item == numero)
            //    {
                    colectora._numeros.Remove(numero);
            //        break;
            //    }

            //}
            
            return colectora;
           }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("El tipo es: " + this.TipoNumero);
            for (int i = 0; i < this._numeros.Count; i++)
            {
                retorno.AppendLine(this._numeros[i].Lectura.ToString());
                

            }

            return retorno.ToString();
            
        }


    }
}

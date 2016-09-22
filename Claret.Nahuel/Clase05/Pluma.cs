using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        #region Costructores

        public Pluma()
        {
            this._marca = "Sin Marca";
            this._tinta = null;
            this._cantidad = 1;
        
        }

        public Pluma(string marca)
            : this()
        {
            this._marca = marca;
        }
        public Pluma(string marca, Tinta tinta)
            : this(marca)
        {
            this._tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this._marca = marca;
            this._tinta = tinta;
            this._cantidad = cantidad;
        }


        #endregion

        #region METODOS

        private string Mostrar()
        {
            return "Marca: " + this._marca + "\n\nDatos tinta\n"+(string) this._tinta + "\n\nCantidad: " +  this._cantidad.ToString()+"\n"; 
        }

        public static implicit operator string(Pluma P1)
        {
            
                return P1.Mostrar();
            

        }
        
        public static bool operator == (Pluma pluma1,Tinta tinta1)
        {
            bool retorno = false;

            if (pluma1._tinta == tinta1)
            {
                retorno = true;
            }
            return retorno;

        }

         public static bool operator!=(Pluma pluma1,Tinta tinta1)
        {
             return ! (pluma1 == tinta1);
        }


        public static Pluma operator +(Pluma p1, Tinta t2)
        {
            if (object.Equals( p1._tinta, null))
            {
                p1._tinta = t2;
            }
            else
            {
                if (p1._tinta == t2)
                {
                    p1._cantidad++;
                }
                else
                {
                    Console.WriteLine("Las tintas son de distinto tipo");
                }
            }
           return p1;
            
        }

        public static Pluma operator -(Pluma p1, Tinta t2)
        {
            if (object.Equals(p1._tinta, null))
            {
                Console.WriteLine(" No hay tinta ");
            }
            else
            {
                if (p1._tinta == t2)
                {
                    p1._cantidad--;
                    if(p1._cantidad==0)
                    {
                        p1._tinta=null;
                    }
                }
                else
                {
                    Console.WriteLine("Las tintas son de distinto tipo no se van a poder restar");
                }
            }
            return p1;

        }



        #endregion

    }
}

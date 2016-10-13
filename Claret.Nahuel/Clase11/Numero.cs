using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11
{
    public class Numero
    {
        protected int _numero;

        public int Lectura { get { return this._numero;} }

        public Numero(int numero)
        {
            if (numero < 0)
            {
                throw new Exception("negativos");
            }
            else
            {
                this._numero = numero;
            }
        }

        public static int operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;
        }
        public static int operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return n1._numero /  n2._numero;
        }
        public static int operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2._numero;
        }


    }
}

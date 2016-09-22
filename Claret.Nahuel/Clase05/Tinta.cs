using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Tinta
    {
        ETipoTinta _tipo;
        ConsoleColor _color;

        #region Constructores

        public Tinta()
        {
            _tipo = ETipoTinta.Comun;
            _color = ConsoleColor.Black;
        }

        public Tinta(ETipoTinta tipo)
            : this()
        {
            _tipo = tipo;
        }

        public Tinta(ETipoTinta tipo,ConsoleColor color)
        {
            _tipo = tipo;
            _color = color;
            
        }

        #endregion

        #region Metodos

        private string Mostrar()
        { 
           return "Tipo: " + this._color.ToString() + "\nColor: " + this._tipo.ToString();
            
        }

        public static string Mostrar(Tinta tintaa)
         {
            // return tintaa.Mostrar();
             return (string)(tintaa);
         }

        

  
        #endregion

        #region Overload

        public static bool operator ==(Tinta Tinta1, Tinta Tinta2)
        {
            bool retorno = false;
            if (Tinta1._color == Tinta2._color && Tinta1._tipo == Tinta2._tipo)
            {
                retorno = true;
            }
            return retorno;

        }

        public static bool operator !=(Tinta Tinta1, Tinta Tinta2)
        {
            return !(Tinta1 == Tinta2);
        }


        public static explicit operator string(Tinta Tinta1)
        {
            return Tinta1.Mostrar();

        }

        public string ToString(Tinta t1)
        {
            return (string)(t1);
        }
        #endregion
    }
}

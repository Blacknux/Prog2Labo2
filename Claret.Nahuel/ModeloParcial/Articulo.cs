using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialArticulo
{
    public class Articulo
    {
        int _codigo;
        string _nombre;
        float _precioCosto;
        float _precioVenta;
        int _stock;
        #region propertys
        public string NombreYCodigo
        {
            get{return this._nombre + " -- " +this._codigo.ToString();}
        }
        public float PrecioCosto
        { 
            
            set{
                this._precioCosto=value;
            this._precioVenta = this._precioCosto *=(float)1.3;
            }
        }

        public float PrecioVenta
        { 
            get{return this._precioVenta;}
        }

        public int Stock
        { 
            set{this._stock=value;}
        
        }
#endregion
        #region constructor
        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            //this._precioCosto = precioCosto;
            this._codigo = codigo;
            this._nombre = nombre;
            this._stock = cantidad;
            this.PrecioCosto = precioCosto;
            

        }


        #endregion
        #region Methods
        public bool HayStock(int cantidad)
        {
            bool retorno = false;
            if (this._stock > cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region Overloads

        public static  bool  operator ==(Articulo a1, Articulo a2)
        {
            bool retorno = false;
            if (a1.NombreYCodigo == a2.NombreYCodigo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Articulo a1, Articulo a2)
        {
            return !(a1 == a2);
        }

        public static int operator -(Articulo articulo, int cantidad)
        {
            return articulo._stock -= cantidad;

        }

        public static int operator +(Articulo a1, Articulo a2)
        {
            return a1._stock + a2._stock;
        }



        #endregion

    }
}

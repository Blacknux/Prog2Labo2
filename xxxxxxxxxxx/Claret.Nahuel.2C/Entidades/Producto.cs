using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
    
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        #region Propertys
        public EMarcaProducto Marca
        {
            get{return this._marca;}
        }

        public float Precio
        {
            get{return this._precio;}
        }
        #endregion

#region constructor

        public Producto(int codigo,EMarcaProducto marca,float precio)
        {
            this._codigoBarra=codigo;
            this._marca=marca;
            this._precio=precio;
        }

#endregion


#region Methods
        protected static string MostrarProducto(Producto Prod1)
        {
            string retorno;
            retorno= "Codigo: "+Prod1._codigoBarra.ToString()+"Marca: "+Prod1.Marca+"Precio: "+ Prod1.Precio.ToString();
               return retorno;
        }
#endregion

#region overloads
        public static explicit operator int(Producto Prod1)
        {
            return Prod1._codigoBarra;
        }

        public static bool operator ==(Producto Prod1, Producto Prod2)
        {
            bool retorno=false;
            if(Prod1.Marca == Prod2.Marca && Prod1._codigoBarra == Prod2._codigoBarra)
            {
                retorno = true;
            }
            return retorno;
        }

         public static bool operator !=(Producto Prod1, Producto Prod2)
        {
             return !(Prod1==Prod2);
         }

         public static bool operator ==(Producto Prod1, EMarcaProducto marca)
         {
             bool retorno = false;
             if (Prod1._marca == marca)
             {
                 retorno = true;
             }
             return retorno;
         }

         public static bool operator !=(Producto Prod1, EMarcaProducto marca)
         {
             return !(Prod1 == marca);
         }



#endregion
    }
}

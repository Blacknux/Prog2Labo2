using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Estante
    {
        sbyte _capacidad;
        List<Producto> _productos;

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante Est1)

    {
            string retorno = "";

            foreach (Producto item in Est1._productos)
            {
                if (item is Galletita)
                {
                    retorno += Galletita.MostrarGalletita((Galletita)item);
                }
                else if (item is Gaseosa)
                {
                    retorno += ((Gaseosa)(item)).MostrarGaseosa();
                }
                else
                {
                    retorno += ((Jugo)(item)).MostrarJugo();
                }
            }

            return retorno;
      }
        




        public static bool operator ==(Estante est, Producto prod)
        {
            bool retorno = false;
            foreach (Producto item in est._productos)
            {
                if (item == prod)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;

        }


        public static bool operator !=(Estante est, Producto prod)
        {
            return !(est == prod);

        }

        public static bool operator +(Estante est, Producto prod1)
        {
            bool retorno = false;
            if (est._capacidad > est._productos.Count && est != prod1)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Estante operator -(Estante est, ETipoProducto tipo)
         {
             Estante retorno = new Estante(est._capacidad);

             foreach (Producto item in est._productos)
             {
                 if (tipo == ETipoProducto.Todo)
                 {
                     retorno._productos.Clear();
                 }
                 else
                 {
                     if (item is Galletita && tipo == ETipoProducto.Galletita)
                     {
                         retorno= retorno - item;
                     }
                     if (item is Gaseosa && tipo == ETipoProducto.Gaseosa)
                     {
                         retorno= retorno - item;
                     }
                     if (item is Jugo && tipo == ETipoProducto.Jugo)
                     {
                         retorno= retorno - item;
                     }
                 }
             }

             return retorno;

        }

        public static Estante operator -(Estante est, Producto prod)
        {
            for (int i = 0; i < est._productos.Count; i++)
            {
                if (est._productos[i] == prod)
                {
                    est._productos.Remove(est._productos[i]);
                }
                
            }
            return est;
        }

        public float GetValorEstante(ETipoProducto tipo)
        {
            float retorno=0;
            foreach (Producto item in this._productos)
            {
                if (tipo == ETipoProducto.Todo)
                {
                    retorno += item.Precio;
                }
                else
                {
                    if (item is Galletita && tipo == ETipoProducto.Galletita)
                    {
                        retorno += item.Precio;
                    }
                    else if (item is Gaseosa && tipo == ETipoProducto.Gaseosa)
                    {
                        retorno += item.Precio;
                    }
                    else
                    {
                        retorno += item.Precio;
                    }
                }
                
            }

            return retorno;
        }

        private float ValorEstanteTotal()
        {
            float retorno = this.GetValorEstante(ETipoProducto.Todo);

            return retorno;
        }

    }
}

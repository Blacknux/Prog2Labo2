using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa:Producto
    {
        float litros;

        public Gaseosa(int codigo, float precio, EMarcaProducto marca, float litros)
            : base(codigo, marca, precio)
        {
            this.litros = litros;
        }

        public Gaseosa(Producto prod1, float litros)
            : this((int)prod1, prod1.Precio, prod1.Marca, litros)
        { }

        public string MostrarGaseosa()
        {
            return Producto.MostrarProducto(this) + " Litros: "+ this.litros;
        }
    }
}

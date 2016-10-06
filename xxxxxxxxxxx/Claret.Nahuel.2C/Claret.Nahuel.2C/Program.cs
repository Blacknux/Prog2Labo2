using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claret.Nahuel._2C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Primer Parcial Laboratorio II - 2016 -";

            Estante est1 = new Estante(3);
            Estante est2 = new Estante(2);

            Producto p = new Producto(222, EMarcaProducto.Manaos, 50.25f);
            Galletita g1 = new Galletita(113, 33.65f, EMarcaProducto.Pitusas, 250f);
            Galletita g2 = new Galletita(111, 56f, EMarcaProducto.Diversión, 500f);
            Jugo j1 = new Jugo(112, 25f, EMarcaProducto.Naranjú, ESaborJugo.Pasable);
            Jugo j2 = new Jugo(333, 33f, EMarcaProducto.Swift, ESaborJugo.Asqueroso);
            Gaseosa g = new Gaseosa(p, 2250f);

            if (!(est1 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + j1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + j2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + g))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }

            Console.WriteLine("Valor total Estante1: {0}", est1.ValorEstanteTotal);
            Console.WriteLine("Valor Estante1 sólo de Galletitas: {0}", est1.GetValorEstante(ETipoProducto.Galletita));
            Console.WriteLine("Contenido Estante1:\n{0}", Estante.MostrarEstante(est1));

            Console.WriteLine("Estante ordenado por Código de Barra....");
            est1.GetProductos().Sort(Program.OrdenarProductos);
            Console.WriteLine(Estante.MostrarEstante(est1));

            est1 = est1 - ETipoProducto.Galletita;
            Console.WriteLine("Estante1 sin Galletitas: {0}", Estante.MostrarEstante(est1));

            Console.WriteLine("Contenido Estante2:\n{0}", Estante.MostrarEstante(est2));
            est2 -= ETipoProducto.Todos;
        }
    }
}

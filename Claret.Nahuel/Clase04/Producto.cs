using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Producto
    {
        private string codBarra;
        private double precio;
        private string nombre;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructro por default (Sin nombre,sin codigo de barras,sin precio)
        /// </summary>
        public Producto()
        {
            this.codBarra = "Sin codigo";
            this.nombre = "Sin nombre";
            this.precio = 0.0;
        }

        /// <summary>
        /// Constructor solo con el precio del producto
        /// </summary>
        /// <param name="precio"></param>
        public Producto(double precio):this( )
        {
            
            //this.codBarra = "Sin codigo";
            //this.nombre="Sin nombre";
            
            this.precio=precio;
        }

        /// <summary>
        /// Inicializa con precio y codigo de barras
        /// </summary>
        /// <param name="codB"> Establece el codigo de barras del producto</param>
        /// <param name="prec">Establece el precio de venta</param>
        public Producto(string codB,double prec):this(prec)
        {
            this.codBarra = codB;
            //this.precio = prec;
            //this.nombre="Sin nombre";
        }

        /// <summary>
        /// Inicializa el producto
        /// </summary>
        /// <param name="codB">Codigo de barras del producto</param>
        /// <param name="prec">Precio de venta del producto</param>
        /// <param name="name">Nombre del producto</param>
        public Producto(string codB, double prec, string name)
        {
            this.codBarra = codB;
            this.precio = prec;
            this.nombre = name;
        }

        public Producto(double prec, string name): this(name)
        {
            this.precio = prec;
        }

        public Producto(string name)
            : this()
        {
            this.nombre = name;
        }

        public Producto(double prec, string name, string codB)
        {
            this.codBarra = codB;
            this.precio = prec;
            this.nombre = name;
        }

        #endregion
        /// <summary>
        /// Muestra los valores que tiene cargado el producto.
        /// </summary>
        public void mostrar()
        {
            Console.WriteLine("El nombre es:{0}\nEl codigo de barras es:{1}\nEl precio es:{2}\n\n",this.nombre,this.codBarra,this.precio);
        }
    }
}

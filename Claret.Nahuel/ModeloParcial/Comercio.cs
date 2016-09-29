using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloParcialArticulo;
using ModeloParcialVenta;

namespace ModeloParcialComercio
{
    public class Comercio
    {
        #region atributes
        string _dueño;
        List<Articulo> _misArticulos;
        List<Venta> _misVentas;
        #endregion 

        #region Costructor
        public Comercio(string dueño)
        {
            this._dueño = dueño;
            this._misArticulos = new List<Articulo>();
            this._misVentas = new List<Venta>();
        }
        #endregion
        #region Methods
       

        public static void MostarArticulos(Comercio comercioAMostrar)
        {
            foreach (Articulo item in comercioAMostrar._misArticulos)
            {
                Console.WriteLine(item.NombreYCodigo);
            }
        }

        public static void MostrarGanacia(Comercio comercioParaResumen)
        {
            float acumulador = 0;
            foreach (Venta item in comercioParaResumen._misVentas)
            {
                acumulador = acumulador + item.RetornarGanancia();
            }
            Console.WriteLine("La ganancia obtenida es: {0}", acumulador);

        }

        public void ComprarArticulo(Articulo articuloComprado)
        {
            bool existe = false;
            
                for (int i = 0; i < this._misArticulos.Count; i++)
                {
                    if (this._misArticulos[i] == articuloComprado)
                    {
                        this._misArticulos[i].Stock = this._misArticulos[i] + articuloComprado;
                        existe = true;
                        break;
                    }
                }
            
            if (!existe)
            {
                this._misArticulos.Add(articuloComprado);
            }


        }
        public void VenderArticulo(Articulo articuloSolicitado, int cantidad)
        {
            for (int i = 0; i < this._misArticulos.Count; i++)
            {
                if (this._misArticulos[i] == articuloSolicitado && this._misArticulos[i].HayStock(cantidad))
                {
                    this._misArticulos[i].Stock = this._misArticulos[i] - cantidad;
                    this._misVentas.Add(new Venta(this._misArticulos[i], cantidad));
                    break;
                }
            }
             

        }
        #endregion

    }
}

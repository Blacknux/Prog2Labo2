using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloParcialArticulo;

namespace ModeloParcialVenta
{
    public class Venta
    {
        #region Atrubutes
        Articulo _articuloVendido;
        int _cantidad;
        #endregion
        #region Costructor
        public Venta(Articulo articuloVendido, int cantidad)
        {
            this._articuloVendido = articuloVendido;
            this._cantidad = cantidad;
        }
        #endregion
        #region Methods
        public float RetornarGanancia()
        { 
            
            return this._cantidad * this._articuloVendido.PrecioVenta;
        }

        
        #endregion
    }
}

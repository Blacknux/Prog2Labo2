using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLavadero
{
    public class Auto : Vehiculo
    {
        int _cantidadDeAsientos;

        /// Constructor de instancia Pasa al constructor base los valores patente, ruedas, marca
        /// inicializa el atributo _cantidadDeAsientos de un Auto.
        /// </summary>
        /// <param name="patente">Parametro para instanciar Vehiculo string patente</param>
        /// <param name="ruedas">Parametro para instanciar Vehiculo Cantidad de ruedas</param>
        /// <param name="marca">Parametro para instanciar Vehiculo Marca del vehiculo</param>
        /// <param name="cantAsientos">Cantidad de asientos de un auto</param>
        public Auto(string patente, byte ruedas, Emarcas marca, int cantAsientos)
            : base(patente, ruedas, marca)
        {
            this._cantidadDeAsientos = cantAsientos;
            
        }
        /// <summary>
        /// Concatena el resultado del metodo mostrar d ela clase vehiculo con el valor del atributo _cantidadDeAsientos.
        /// </summary>
        /// <returns>Devuelve un string concatenando el metodo mostrar de la clase vehiculo + la cantida de asientos del Auto</returns>
        public string MostrarAuto()
        {
            return base.Mostrar() + "\nCant. Asientos: " + this._cantidadDeAsientos;
        }
    }
}

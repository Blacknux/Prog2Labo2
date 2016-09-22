using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLavadero
{
    public class Camion:Vehiculo
    {
        float tara;
        /// Constructor de instancia Pasa al constructor base los valores patente, ruedas, marca
        /// inicializa el atributo tara de un camion.
        /// </summary>
        /// <param name="patente">Parametro para instanciar Vehiculo string patente</param>
        /// <param name="ruedas">Parametro para instanciar Vehiculo Cantidad de ruedas</param>
        /// <param name="marca">Parametro para instanciar Vehiculo Marca del vehiculo</param>
        /// <param name="tara">Parametro para inicializar el atributo tara de un camion</param>
        public Camion(string patente, byte ruedas, Emarcas marca, float tara)
            : base(patente, ruedas, marca)
        {
            this.tara = tara;
        }

        /// <summary>
        /// Concatena el resultado del metodo mostrar d ela clase vehiculo con el valor del atributo tara
        /// </summary>
        /// <returns>String con cocatenacion de metodo Vehiculo.Mostrar + this.tara</returns>
        public string MostrarCamion()
        {
            return base.Mostrar() + "\nTara: " + this.tara;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLavadero
{
    public class Moto:Vehiculo
    {
        float cilindrada;
        /// <summary>
        /// Constructor de instancia Pasa al constructor base los valores patente, ruedas, marca
        /// inicializa el atributo cilindrada
        /// </summary>
        /// <param name="patente">Parametro para instanciar Vehiculo string patente</param>
        /// <param name="ruedas">Parametro para instanciar Vehiculo Cantidad de ruedas</param>
        /// <param name="marca">Parametro para instanciar Vehiculo Marca del vehiculo</param>
        /// <param name="cilindrada">Cilindrada de la moto Atributo puro</param>
        public Moto(string patente, byte ruedas, Emarcas marca, float cilindrada)
            : base(patente, ruedas, marca)
        {
            this.cilindrada = cilindrada;
        }
        /// <summary>
        /// oncatena el resultado del metodo mostrar d ela clase vehiculo con el valor del atributo _cilindrada.
        /// </summary>
        /// <returns>String con cocatenacion de metodo Vehiculo.Mostrar + this._cilindrada</returns>
        public string MostrarMoto()
        {
            return base.Mostrar() + "\nCilindrada: " + this.cilindrada;
        }
    }
}

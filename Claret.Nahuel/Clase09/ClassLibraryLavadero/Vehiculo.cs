using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLavadero
{
    public class Vehiculo
    {
        #region atributos y Prop
        protected string _patente;
        /// <summary>
        /// propiedad que retorna la patente de un vehiculo.
        /// </summary>
        public string Patente
        {
        get{return this._patente;}
        
        }
        Byte _cantRuedas;
        Emarcas _marca;
        /// <summary>
        /// propiedad que retorna la marca de un vehiculo
        /// </summary>
        public Emarcas Marca
        {
            get { return this._marca; }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// OInicializa los valores de un objeto tio Vehiculo
        /// </summary>
        /// <param name="patente">String Patente</param>
        /// <param name="ruedas">Cantidad de ruedas</param>
        /// <param name="marca">EMarcas Marca del Vehiculo</param>
        public Vehiculo(string patente, byte ruedas, Emarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = ruedas;
            this._marca = marca;
        }
        #endregion
        #region Metodos

        /// <summary>
        /// Crea un string concatenando los valores delos atributos de un Vehiculo
        /// </summary>
        /// <returns>String para mstrar datos del vehiculo</returns>
        protected string Mostrar()
        {

            return "Patente: " + this._patente + "\nRuedas: " + this._cantRuedas + "\nMarca: " + this._marca;
        
        }

        /// <summary>
        /// Muestra hasta cuanto puede acelerar un vehiculo
        /// </summary>
        /// <param name="cuanto">velocidad maxima</param>
        public void AcelerarHasta(Byte cuanto)
        {
            Console.WriteLine("Hacelero hasta {0} Km/h",cuanto);
        }

        #endregion
        #region Sobrecargas
        /// <summary>
        /// Sobrecarga en la cual se comparan dos vehiculos por su marca y patente.
        /// </summary>
        /// <param name="V1">Vehiculo a comparar</param>
        /// <param name="V2">Vehiculo a comparar</param>
        /// <returns>true si patente y marca son iguales, si no false</returns>
        public static bool operator ==(Vehiculo V1, Vehiculo V2)
        {
            
            return (V1.Marca == V2.Marca && V1.Patente == V2.Patente);
        }

        /// <summary>
        /// Se compara si un vehiculo es difrente a otro validando patente y marca
        /// </summary>
        //// <param name="V1">Vehiculo a comparar</param>
        /// <param name="V2">Vehiculo a comparar</param>
        /// <returns>true si patente y marca son disintos, si no false</returns>
         public static bool operator !=(Vehiculo V1, Vehiculo V2)
        {
             return !(V1==V2);
         }
        #endregion



    }
}

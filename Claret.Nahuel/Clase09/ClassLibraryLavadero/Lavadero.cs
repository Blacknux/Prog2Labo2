using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLavadero
{
    public class Lavadero
    {
        List<Vehiculo> _vehiculos;

        //public List<Vehiculo> Vehiculos { get { return this._vehiculos;} }
        float _precioAuto;
        float _precioCamion;
        float _precioMoto;

        #region Constructor
        private Lavadero()
        { 
            _vehiculos=new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
            
        }


        #endregion

        #region metodos
        public Double MostrarFacturado() 
        {
            double total=0;

            total = MostrarFacturado(EVehiculos.Auto) + MostrarFacturado(EVehiculos.Moto) + MostrarFacturado(EVehiculos.Camion);
            return total;
        }

        public Double MostrarFacturado(EVehiculos tipoVehiculo)
        {

            //double acumMoto = 0;
            //double acumAuto = 0;
            //double acumCamion = 0;
            double retorno=0;


            foreach (Vehiculo item in this._vehiculos)
            {
                if (item is Auto && tipoVehiculo ==EVehiculos.Auto)
                {
                    retorno += this._precioAuto;
                }
                else if (item is Moto && tipoVehiculo == EVehiculos.Moto)
                {
                    retorno += this._precioMoto;
                }
                else
                {
                    retorno += this._precioCamion;
                }
            }

            
       
            //foreach (Vehiculo item in this._vehiculos)
            //{
            //    if (item is Auto)
            //    { 
            //        acumAuto+=this._precioAuto;
            //    }
            //    else if(item is Moto)
            //    {
            //        acumMoto+=this._precioMoto;
            //    }
            //    else
            //    {
            //        acumCamion += this._precioCamion;
            //    }
            //}
            
            //switch (tipoVehiculo)
            //{ 
            //    case EVehiculos.Auto:
            //        retorno = acumAuto;
            //        break;
            //    case EVehiculos.Moto:
            //        retorno = acumMoto;
            //        break;
            //    case EVehiculos.Camion:
            //        retorno = acumCamion;
            //        break;

            
            return retorno;
            
        }

        public static bool operator ==(Lavadero L1, Vehiculo V1)
        {
            bool retorno = false;
           if(!(L1.Equals(null) )&& !(V1.Equals(null)))
           {
            
            foreach (Vehiculo item in L1._vehiculos)
            {
                if (item == V1)
                {
                    retorno = true;
                    break;
                }
            }
           }
            return retorno;

        }

        public static bool operator !=(Lavadero L1, Vehiculo V1)
        {
            return !(L1 == V1);
        }


        public static Lavadero operator +(Lavadero L1, Vehiculo V1)
        {
            if (L1 != V1)
            {
                L1._vehiculos.Add(V1);
            }
            
            return L1;
        }

        public static Lavadero operator -(Lavadero L1, Vehiculo V1)
        {
            if (L1 == V1)
            {
                L1._vehiculos.Remove(V1);
            }

            return L1;
        }

        public static Lavadero sacarVehiculo(Lavadero L1, Vehiculo V1)
        {

            for (int i = 0; i < L1._vehiculos.Count; i++)
            {
                if (L1._vehiculos[i] == V1)
                {
                    L1._vehiculos.RemoveAt(i);
                    break;
                }
            }
            return L1;
        }


        public static int ordenarPorPatente(Vehiculo V1, Vehiculo V2)
        {
            return string.Compare(V1.Patente, V2.Patente,false);
        }

        public static int ordenarMarca(Vehiculo V1, Vehiculo V2)
        {
            return string.Compare(V1.Marca.ToString(), V2.Marca.ToString(),false);
        }

        public static void Mostrar(Lavadero Lav1)
        { 
            foreach (Vehiculo item in Lav1._vehiculos)
            {
                Console.WriteLine(item.Marca);
            }
        }

        public void Acomodar()
        {
            
            this._vehiculos.Sort(Lavadero.ordenarMarca);
        }



        #endregion
    }
}
///Modo estatico en lavadero --> pubic Ordenar por  patente(vehiculo,vehiculo):int
///{0 ==
///1 1ª mayor 
///-1 1ª menor}
///
///lomismo para marca pero de instancia 
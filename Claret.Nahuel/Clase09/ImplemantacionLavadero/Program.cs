using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLavadero;

namespace ImplementacionLavadero
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero lavadero = new Lavadero(50, 120, 45);
            Auto auto1 = new Auto("CXR386", 4, Emarcas.Ford, 5);
            Auto auto2 = new Auto("LPO009", 5, Emarcas.Fiat, 4);
            Camion camion1 = new Camion("POO666", 8, Emarcas.Iveco, 2);
            Moto moto1 = new Moto("LKP119", 2, Emarcas.Rowser, 200);
            Moto moto2 = new Moto("LKP919", 2, Emarcas.Rowser, 200);
            Moto moto3 = new Moto("LKP919", 5, Emarcas.Rowser, 200);
            Moto moto4 = new Moto("LKP119", 2, Emarcas.Rowser, 200);
            //Console.WriteLine("\nMostramos la moto");
            // Console.WriteLine(moto1.MostrarMoto());
            //Console.WriteLine("\nMostramos el auto1");
            // Console.WriteLine(auto1.MostrarAuto());
            //Console.WriteLine("\nMostramos el camion");
            // Console.WriteLine(camion1.MostrarCamion());
            //Console.WriteLine("\nMostramos el auto2");
            //Console.WriteLine( auto2.MostrarAuto());

            lavadero += auto1;
            lavadero += moto1;
            lavadero += auto2;
            lavadero += camion1;
            lavadero += moto2;
            Console.WriteLine("########### Mostramos Todos los Vehiculos #########"); 
            Lavadero.Mostrar(lavadero);
            lavadero.Acomodar();
            Console.WriteLine("########### Mostramos Todos los Vehiculos Ordpor  marca #########"); 
            Lavadero.Mostrar(lavadero);

           
            Console.WriteLine("\n El total facturado por motos es: "+lavadero.MostrarFacturado(EVehiculos.Moto));
            Console.WriteLine("\n El total facturado por Camiones es: " + lavadero.MostrarFacturado(EVehiculos.Camion));
            Console.WriteLine("\n El total facturado por Autos es: " + lavadero.MostrarFacturado(EVehiculos.Auto));
            Console.WriteLine("\n El total facturado es: " + lavadero.MostrarFacturado());
            lavadero = Lavadero.sacarVehiculo(lavadero, moto3);
            Console.WriteLine("\n######Elimine una moto 90 - 45######\n");
            Console.WriteLine("\n El total facturado por motos es: " + lavadero.MostrarFacturado(EVehiculos.Moto));
            Console.WriteLine("\n El total facturado por Camiones es: " + lavadero.MostrarFacturado(EVehiculos.Camion));
            Console.WriteLine("\n El total facturado por Autos es: " + lavadero.MostrarFacturado(EVehiculos.Auto));
            Console.WriteLine("\n El total facturado es: " + lavadero.MostrarFacturado());

            Console.WriteLine("\n###### POC ? : ######\n");

            Console.WriteLine(lavadero == moto2 ? "Esta" : "No esta");

            


                Console.ReadKey();
        }
    }
}

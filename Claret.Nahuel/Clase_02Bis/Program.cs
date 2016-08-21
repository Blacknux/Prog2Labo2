using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02Bis
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 option;
            bool validacion;
            Console.WriteLine("1-Imprimir standard\n2-Imprimir en color\n3-Imprimir con formato\n4-Salir");
            validacion = int.TryParse(Console.ReadLine(), out option);
            if (validacion)
            {
                switch (option)
                {
                    case 1:
                        if (!Sello.IsEmptyorNull(Sello.DefinirCadena()))
                        {
                            Console.WriteLine(Sello.Imprimir());
                        }
                            break;
                    case 2:
                        if (!Sello.IsEmptyorNull(Sello.DefinirCadena()))
                        {
                            Sello.ImprimirEnColor(Sello.Imprimir());
                        }
                        break;
                    case 3:
                        if (!Sello.IsEmptyorNull(Sello.DefinirCadena()))
                        {
                            Sello.ImprimirConFormato();
                        }
                        break;
                    case 4:
                        //Console.WriteLine("Hasta luego!\nPresione una tecla para continuar....");
                        //Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("Opcion no valida!");
                        break;
                }
                //    Sello.ImprimirEnColor(Sello.DefinirCadena());
                //Sello.ImprimirConFormato();

                Console.WriteLine("Presiones una tecla para continuar...");
                Console.ReadKey();
            }    
        }
    }
}

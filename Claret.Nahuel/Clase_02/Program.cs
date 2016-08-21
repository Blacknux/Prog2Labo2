using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    using Manualidades;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un sello");
            Sello.mensaje=Console.ReadLine();
            Console.WriteLine(Sello.Imprimir());
           // Sello.Borrar();
            //Console.WriteLine("se borro OK "+Sello.Imprimir());
            Sello.color = ConsoleColor.Green;
            Sello.ImprimirEnColor();
            Console.WriteLine("Pulse una tecla para finalizar");

            Console.ReadLine();
        }
    }
}

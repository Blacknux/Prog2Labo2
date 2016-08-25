using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo T1 = new Triangulo();
            Rectangulo R1 = new Rectangulo();
            
            
            Console.WriteLine(T1.Mostrar());
            Console.WriteLine(R1.Mostrar());

            Triangulo.Dibujar(T1);

            Console.ReadKey();
        }
    }
}

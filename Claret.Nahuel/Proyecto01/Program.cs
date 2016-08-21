using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
             Int32 numero1;
             Int32 numero2;
             Int32 numero3;
             Int32 numero4;
             Int32 numero5;
             Int32 minimo;
             Int32 maximo;
            bool tryparse;

            Console.WriteLine("Ingrese 5 numeros");
           
            while (!int.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("ERROR");
            }
            while (!int.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("ERROR");
            }
            while (!int.TryParse(Console.ReadLine(), out numero3))
            {
                Console.WriteLine("ERROR");
            }
            while (!int.TryParse(Console.ReadLine(), out numero4))
            {
                Console.WriteLine("ERROR");
            }
            while (!int.TryParse(Console.ReadLine(), out numero5))
            {
                Console.WriteLine("ERROR");
            }

            if (numero1<numero2&& numero1<numero3 && numero1<numero4 && numero1<numero5)
            {
                minimo=numero2;
            }
            else if (numero2<numero1&& numero2<numero3 && numero2<numero4 && numero2<numero5)
	{
        minimo = numero1;
	}
            else if (numero3 < numero1 && numero3 < numero2 && numero3 < numero4 && numero3 < numero5)
            {
                minimo = numero3;
            }
            

        }
    }
}

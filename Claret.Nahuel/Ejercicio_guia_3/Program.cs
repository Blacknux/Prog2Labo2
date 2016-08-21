using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_guia_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 Numero_Ingresado;
            bool tryParse;

            Console.Write(" Ingresar un numero: ");

            while (!int.TryParse(Console.ReadLine(), out Numero_Ingresado))
            {
                Console.Write("Error Ingresar un numero\nNumero:");
            }

            for (int i = Numero_Ingresado; i > 0; i--)
            {
                for (int j = i-1; j > 1; j--)
                {
                    if (i % j == 0 )
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(i);
                    }
                    
                }
                
            }

        }
    }
}

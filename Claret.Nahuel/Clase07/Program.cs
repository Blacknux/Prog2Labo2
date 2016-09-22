using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera[] arrayTemperas;
            ConsoleColor[] colores={ConsoleColor.Red,ConsoleColor.Cyan,ConsoleColor.Blue,ConsoleColor.Red,ConsoleColor.Cyan};
            string[] marcas = { "Marca1", "Marca2", "Marca3", "Marca4", "Marca5" };
            sbyte[] cantidades = { 1, 4, 3, 1, 4 };
            arrayTemperas = new Tempera[5];

           

            for (int i = 0; i < arrayTemperas.Length ; i++)
			{
                
                arrayTemperas[i]=new Tempera(colores[i],marcas[i],cantidades[i]);			 
			}

            //foreach (Tempera unaTemp in arrayTemperas)
            //{
            //    Console.WriteLine(unaTemp);
            //}

            //arrayTemperas[2]+=arrayTemperas[4];

            //foreach (Tempera unaTemp in arrayTemperas)
            //{
            //    Console.WriteLine(unaTemp);
            //}

            //Paletas

            Paleta p = 4;
            Paleta p2 = 5;

            
            p +=arrayTemperas[0];
            p += arrayTemperas[1];
            p += arrayTemperas[2];
            //p2 += arrayTemperas[1];
            for (int i = 0; i < 5; i++)
            {
                p2 += arrayTemperas[i];
                
            }
            
            Console.WriteLine("P");
            Console.WriteLine((string)p);
            //Console.WriteLine("###################################################");
            //Console.WriteLine("P2");
            //Console.WriteLine((string)p2);
            //Console.WriteLine("###################################################");
            Paleta p3 = 2;
            p3 = (p + p2);
            Console.WriteLine("P3");
            Console.WriteLine((string)p3);
            Console.WriteLine("###################################################");
            Console.WriteLine("P3+p");
            Paleta p4 = 2;
            p4 = p3 + p;
            Console.WriteLine((string)(p4));



            Console.ReadKey();

            
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tinta T1 = new Tinta(ETipoTinta.ConBrillitos);
            //Tinta T2 = new Tinta(ETipoTinta.China, ConsoleColor.Red);
            //Tinta T3 = new Tinta(ETipoTinta.China, ConsoleColor.Red);
            //Pluma P1 = new Pluma();
            //Pluma P2 = new Pluma("Bic", T3, 2);
            

            //Console.WriteLine(Tinta.Mostrar(T3) + "\n");
            //Console.WriteLine(Tinta.Mostrar(T2));
            //if (T3 == T2)
            //{
            //    Console.WriteLine("\nIguales");
            //}
            //else
            //{ Console.Write("\nDistintos\n"); }

            //Console.WriteLine(Tinta.Mostrar(T1) + "\n");
            //Console.WriteLine(Tinta.Mostrar(T2));
            
            //if (T1 == T2)
            //{
            //    Console.WriteLine("\nIguales");
            //}
            //else
            //{ Console.Write("\nDistintos\n"); }

            //Console.WriteLine((string)T1);
            //Console.WriteLine(T1.ToString(T1));
            //Console.WriteLine(T2);

            //P1 = P1 + T3;
            //Console.WriteLine(P1);
            //Console.WriteLine((string)P2);
            //if (P2 == T2)
            //{
            //    Console.WriteLine("Son Iguales\n");
            //}
            //else
            //{
            //    Console.WriteLine("NO son Iguales\n");
            //}
            Tinta t1 = new Tinta(ETipoTinta.Comun,ConsoleColor.Red);
            Tinta t2 = new Tinta(ETipoTinta.China,ConsoleColor.Red);
            Pluma p1 = new Pluma("Acme",t2,1);
            Pluma p2 = new Pluma("Acme", t1, 1);

            //p1 = p1 - t1;
            p2 = p2 - t1;

            Console.WriteLine(p1+"\n\nP2");
            Console.WriteLine(p2);


           
            
            Console.ReadKey();
        }
    }
}

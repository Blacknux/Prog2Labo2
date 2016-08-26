using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto P1 = new Producto();
            Producto P2 = new Producto(10.56);
            Producto P3 = new Producto( "Codigo1",0.65);
            Producto P4 = new Producto("Codigo2", 5.23, "Producto 1");
            //Producto P5 = new Producto(name:"reioerio", prec:25.65, codB:"Producto 6");
            Producto P6 = new Producto("reioerio", 25.65, "Producto 6");
            Producto P7 = new Producto(23.5, "prod 7");
            Producto P9 = new Producto(23.5, "prod 7","asdsdsds");


            P1.mostrar();
            P2.mostrar();
            P3.mostrar();
            P4.mostrar();
            //P5.mostrar();
            P6.mostrar();

           

            Console.ReadKey();

               

        }
    }
}

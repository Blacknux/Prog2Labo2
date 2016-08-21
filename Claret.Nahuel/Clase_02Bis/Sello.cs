using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02Bis
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        //Funcion paradefinir el sello
        public static string DefinirCadena()
        {
            Console.Write("Ingrese el sello que desa imprimir\nSello: ");
            Sello.mensaje = Console.ReadLine();
            Sello.mensaje= Sello.mensaje.ToUpper();
            return Sello.mensaje;

        }

        ////Retornar sello sin formato
        public static string Imprimir()
        {
            return Sello.mensaje;
        }

        //Imprimir en color
        public static void ImprimirEnColor(string mensaje)
        {
            //mensaje = Sello.mensaje;
            Int32 color;
            bool validaColor;
            Console.Write("Selecciones el color con el que quiere que se muestre el mesaje\n1-Rojo\n2-celeste\n3-amarillo\nColor: ");
            validaColor = int.TryParse(Console.ReadLine(), out color);
            while (!validaColor)
            {
                Console.WriteLine("ERROR");
                Console.Write("Selecciones el color con el que quiere que se muestre el mesaje\n1-Rojo\n2-celeste\n3-amarillo\nColor: ");
                validaColor = int.TryParse(Console.ReadLine(), out color);
            } 

            switch (color)
            {
                case 1:
                    Sello.color = ConsoleColor.Red;
                    break;
                case 2:
                    Sello.color = ConsoleColor.Cyan;
                    break;
                case 3:
                    Sello.color = ConsoleColor.Yellow;
                    break;
                default:
                    Console.WriteLine("Opcion no valida, se mostrara el color por default(gris)");
                    break;


            }
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
                  

        }

        //Retorna cadena con *

        private static string ArmarFormatoMensaje()
        {
            string mensaje;
            string asteriscos = "";
            string returnMessage;
            mensaje = Sello.mensaje;
            Int32 cantidadDeAster;
            cantidadDeAster = mensaje.Length + 2;
            for (int i = 0; i < cantidadDeAster; i++)
            {
                asteriscos += "*";

            }
            returnMessage = asteriscos + "\n" + "*" + Sello.mensaje + "*\n" + asteriscos;


            return returnMessage;
        }

        public static void ImprimirConFormato()
        {
            Console.WriteLine(Sello.ArmarFormatoMensaje());
        }

        public static bool IsEmptyorNull(string aValidar)
        {
            bool validacion = false;

            if(string.IsNullOrEmpty(aValidar)||string.IsNullOrWhiteSpace(aValidar))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("ERROR LA CADENA ESTA VACIA");
                    Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                validacion = true;
            }
                        
            return validacion;

        }
    }
}

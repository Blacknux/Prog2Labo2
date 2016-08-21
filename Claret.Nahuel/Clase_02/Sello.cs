using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manualidades
    {
    
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            string message;
            message = Sello.mensaje;
            while(!TryParse(Sello.mensaje,out message))
            {
                message = Sello.mensaje;
                Console.ForegroundColor=ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ERROR LA CADENA ESTA VACIA \n");
                
                Console.ForegroundColor=ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Ingrese un nuevo mensaje: ");
                Sello.mensaje = Console.ReadLine();

            }
            return Sello.ArmarFormatoMensaje();
        }

        //Ejercicios conv de num bin a dec
        
        
        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private static string ArmarFormatoMensaje()
        {
            string mensaje;
            string asteriscos="";
            string returnMessage;
            mensaje = Sello.mensaje;
            Int32 cantidadDeAster;
            cantidadDeAster = mensaje.Length + 2;
            for (int i = 0; i <cantidadDeAster; i++)
            {
                asteriscos += "*";

            }
            returnMessage= asteriscos + "\n"+"*"+Sello.mensaje+"*\n"+asteriscos;


            return returnMessage;
        }

        //private static bool TryParse(string aValidar, out string mensaje )
        //{
        //    bool returnBool=false;
        //    if (!string.IsNullOrEmpty(aValidar) && !string.IsNullOrWhiteSpace(aValidar) )
        //    {
        //        returnBool = true;
        //        mensaje = aValidar;

        //    }
        //    else
        //    {
        //        mensaje = null;
        //    }

        //    return returnBool;
        //}
        
    }
}

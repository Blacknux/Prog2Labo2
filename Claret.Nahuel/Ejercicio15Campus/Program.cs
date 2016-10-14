using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15Campus
{
    class Program
    {
        static void Main(string[] args)
        {
            string pepe = "2";
            string overflow = "2222222222222222222222222222222";
            string errorformat = "ded";
            int resultado;
            try
            {
                resultado = Parser.Parse(errorformat);
            }
            catch (ExceptionParser e)
            {
                Console.WriteLine(e.Message);
                
            }
            Console.ReadKey();

        }
    }
}

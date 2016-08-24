using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DecToBinToDec
{
    class Conversores
    {
        //public static void printInt(int a)
        //{
        //    Console.WriteLine(a);
        //    Console.ReadLine();
        //}

        public static string decToBin(Int32 decim)
        {
            string acumulador = "";
            double reduccion;
            string returnAux = "";

            while (decim > 0)
            {

                acumulador += decim % 2;
                reduccion = Math.Floor((double)decim / 2);
                decim = (int)reduccion;
            }

            for (int i = acumulador.Length - 1; i >= 0; i--)
            {
                returnAux += acumulador[i];
            }

            return returnAux;
        }


        public static string binaToDec(string bin)
        {
            int exp = 0;
            string auxReverse = "";
            string returnAux="";


            for (int i = bin.Length - 1; i >= 0; i--)
            {
                auxReverse += bin[i];

            }

            for (int i = 0; i < auxReverse.Length; i++)
            {
                if ((auxReverse[i]) == (char) '1')
                {
                    exp += (int)Math.Pow(2, i);
                }

            }

            returnAux = exp.ToString();
                return returnAux;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = { 1, 21, 34, 4, 48, 5, 4, 7 };

            int[] newnumero= new int[12];
            numero.CopyTo(newnumero,0);

            for (int i = 0; i <12; i++)
            {
                if (newnumero[i].Equals(null) || newnumero[i].Equals(0))
                {
                  //Console.WriteLine( i.ToString()+ " Es Null");
                }
                else
                {
                    Console.WriteLine(Convert.ToString(newnumero[i] ));
                }
                
            }
            Console.ReadLine();


        }
    }
}

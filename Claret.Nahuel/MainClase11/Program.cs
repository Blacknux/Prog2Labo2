﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase11;

namespace MainClase11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ColectoraDeNumeros cn = new ColectoraDeNumeros(ETipoNumero.Par);

                Numero n1 = new Numero(Int32.Parse("222"));
                Numero n2 = new Numero(Int32.Parse("-56"));
                Numero n3 = new Numero(Int32.Parse("59"));
                Numero n4 = new Numero(Int32.Parse("-18"));
                Numero n5 = new Numero(Int32.Parse("0"));

                cn += n1;
                cn += n2;
                cn += n3;
                cn += n4;
                cn += n5;

                Console.WriteLine(cn);

                cn -= n3;
                cn -= n4;

                Console.WriteLine(cn);

                Console.ReadLine();

                Console.WriteLine(cn.SumaDeNumeros);
                Console.WriteLine(cn.RestaDeNumeros);
                Console.WriteLine(cn.MultiplicacionDeNumeros);
                Console.WriteLine(cn.DivisionDeNumeros);

                Console.ReadLine();
            }

            catch (FormatException e)
            {
                //Console.BackgroundColor = ConsoleColor.Yellow;

                Console.Write(e.Message);
                Console.Write(e.ToString());
                Console.ReadKey();

            }
            catch (OverflowException e)
            {
                //Console.BackgroundColor = ConsoleColor.Yellow;

                Console.Write(e.Message);
                Console.Write(e.ToString());
                Console.ReadKey();

            }
            //catch (Exception e)
            //{
            //    throw e;
            //}

            finally
            {
                Console.WriteLine("Ratatatata");
                //Console.Clear();
                Console.ReadKey();
            }
        }


    }
}

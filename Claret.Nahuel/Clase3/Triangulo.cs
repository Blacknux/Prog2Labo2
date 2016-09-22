<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Triangulo
    {
        private int baseT;
        private int alturaT;
        public double superficie;


        #region Constructor

        public Triangulo()
        {
            this.alturaT = 2;
            this.baseT = 3;

        }
        #endregion
        private void ObtenerDatos()
        {
            this.superficie = (double)((baseT * alturaT) / 2);
        }

        public string Mostrar()
        {
            this.ObtenerDatos();
            string returnAux = "";
            returnAux = "La superficie es: " + this.superficie;

            return returnAux;

        }

        public static void Dibujar(Triangulo triang)
        {
            for (int i = triang.alturaT; i > 0; i--)
            {
                for (int j = 0; j < triang.baseT; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("\n");
            }
        }
       
    }
}

 
  
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Triangulo
    {
        private int baseT;
        private int alturaT;
        public double superficie;


        #region Constructor

        public Triangulo()
        {
            this.alturaT = 2;
            this.baseT = 3;

        }
        #endregion
        private void ObtenerDatos()
        {
            this.superficie = (double)((baseT * alturaT) / 2);
        }

        public string Mostrar()
        {
            this.ObtenerDatos();
            string returnAux = "";
            returnAux = "La superficie es: " + this.superficie;

            return returnAux;

        }

        public static void Dibujar(Triangulo triang)
        {
            for (int i = triang.alturaT; i > 0; i--)
            {
                for (int j = 0; j < triang.baseT; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("\n");
            }
        }
       
    }
}

 
  
>>>>>>> 0ead114776a9464d0a782899dfd3e85d92a4f395

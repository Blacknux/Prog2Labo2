<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Rectangulo
    {
        private  Int32 ladoUno;
        private   Int32 ladoDos;
        public  double perimetro;
        public  double superficie;


        #region Constructor

        public Rectangulo()
        {
            this.ladoUno = 8;
            this.ladoDos = 2;
        }
        #endregion

        private  void ObtenerDatos()
        {
           
           this.perimetro = (double)(ladoUno * 2) + (ladoDos * 2);
            this.superficie=(double)ladoUno*ladoDos;
        }

        public  string Mostrar()
        {
            string returnAux;
            this.ObtenerDatos();
            returnAux = "La superficie del rectangulo es: " + this.superficie + " El Perimetro es: " + this.perimetro;
            return returnAux;

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
    class Rectangulo
    {
        private  Int32 ladoUno;
        private   Int32 ladoDos;
        public  double perimetro;
        public  double superficie;


        #region Constructor

        public Rectangulo()
        {
            this.ladoUno = 8;
            this.ladoDos = 2;
        }
        #endregion

        private  void ObtenerDatos()
        {
           
           this.perimetro = (double)(ladoUno * 2) + (ladoDos * 2);
            this.superficie=(double)ladoUno*ladoDos;
        }

        public  string Mostrar()
        {
            string returnAux;
            this.ObtenerDatos();
            returnAux = "La superficie del rectangulo es: " + this.superficie + " El Perimetro es: " + this.perimetro;
            return returnAux;

        }

       
    }
}
>>>>>>> 0ead114776a9464d0a782899dfd3e85d92a4f395

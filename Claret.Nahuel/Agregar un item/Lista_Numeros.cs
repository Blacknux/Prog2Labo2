using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregar_un_item
{
    class Lista_Numeros
    {
        private int[] arrayNumeros;

        public Lista_Numeros()
        {
            this.arrayNumeros = new int[2]; 
        }
        public int numero
        {
            get { return this.arrayNumeros.Length; }

            set
            {
                int[] arrayAux = new int[this.numero + value];
                this.arrayNumeros.CopyTo(arrayNumeros, 0);
                this.arrayNumeros = arrayAux;
            }
        }

            public string Mostrar()
            {
                string strNumeros="";
                for (int i = 0; i < arrayNumeros.Length; i++)
                {
                    strNumeros+=Convert.ToString(arrayNumeros[i]+"\n");
                }
                return strNumeros;
            }
    }
}

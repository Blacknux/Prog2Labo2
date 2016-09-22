using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase07
{
    class Paleta
    {
        private Tempera[] _tempera;
        private sbyte _CantidadMaximaColores;

        #region Constructores
        private Paleta(sbyte inic)
        {
            this._tempera = new Tempera[inic];
            this._CantidadMaximaColores = inic;
        }

        private Paleta()
            : this(4)
        {

        }
        #endregion

        #region sobrecarga

        public static implicit operator Paleta(sbyte num)
        {
            return  new Paleta(num); 
        }

        private static string Mostrar(Paleta P1)
        {
            string retornoTemp=" ";
            for(int i=0;i<P1._tempera.Length;i++)
            {
                retornoTemp+="Tempera: " + P1._tempera[i] + "\n";
            }
            return "La Cantidad de tempresa es: "+ P1._CantidadMaximaColores+"\n" + retornoTemp;
        }

        public static explicit  operator string(Paleta P1)
        {
            return Paleta.Mostrar(P1);
        }

        private static int Ocupados(Paleta P1)
        {
            int retorno = 0;

            foreach (Tempera iter in P1._tempera)
            {
                if (!object.Equals(iter, null))
                {
                    retorno++;
                }
                
            }
            return retorno;
        }
        public static bool operator ==(Paleta paleta, Tempera T1)
        {
            bool retorno = false;
                                    
            //foreach (Tempera Ite in paleta._tempera)
            for (int i = 0; i < paleta._CantidadMaximaColores-1; i++)
            
            {
                if (object.Equals(T1,null)) { break; }
                if (null != paleta._tempera.GetValue(i) 
                    && T1 == paleta._tempera[i])
                {
                    retorno = true;
                    break;
                }

            }
            return retorno;
        }

        public static bool operator !=(Paleta paleta, Tempera T1)
        {
            return !(paleta == T1);
        }

        public static Paleta operator +(Paleta P1, Tempera T1)
        {
            if (-1!= Paleta.findNull(P1) &&  P1 != T1)
            {
                P1._tempera[Paleta.findNull(P1)] = T1;
            }
            return P1;
        }

        private static int findNull(Paleta P1)
        {
            int retorno =-1;

            for(int x= 0;x<P1._CantidadMaximaColores;x++)
            {
                if (object.Equals(P1._tempera[x], null))
                {
                    retorno=x;
                    break;
                }

            }
            return retorno;
        }

        public static int operator ==(Tempera T1, Paleta P1)
        {
            int retorno=0;
            for (int i = 0; i < P1._CantidadMaximaColores; i++)
            {
                if(T1 ==P1._tempera[i])
                {
                    retorno=i;
                    break;
                }

            }
            return retorno;
        }

        public static int operator !=(Tempera T1, Paleta P1)
        {
            return (T1 == P1);
        }


        
        public static Paleta operator +(Paleta P1, Paleta P2)
        {
           Paleta Auxiliar=(sbyte) (P1._CantidadMaximaColores +P2._CantidadMaximaColores);
            //Paleta retorno;


           //Auxiliar = (Paleta.agregoColores(P1, P2)) + (Paleta.agregoColores(P2, P1));

           for (int x = 0; x < P2._CantidadMaximaColores; x++)
           {
               //if (P2._tempera[x].Equals(null) || P1.Equals(null)) { break; }

               if (P1 == P2._tempera[x])
               {
                   int index = (P2._tempera[x] == P1);
                   Auxiliar += P1._tempera[index] + P2._tempera[x];
               }
               else
               {
                   Auxiliar += P2._tempera[x];
               }
           }

           for (int x = 0; x < P1._CantidadMaximaColores; x++)
           {
           //    //if (P2._tempera[x].Equals(null)) { break; }
               if (!(P2 == P1._tempera[x]))
               {
                    Auxiliar += P1._tempera[x];
           //        int index = (P1._tempera[x] == P2);
           //        Auxiliar += P2._tempera[index] + P1._tempera[x];
           //    }
           //    else
           //    {
           //       
              }
           }
              
            //}

            //for (int x = 0; x < P2._CantidadMaximaColores; x++)
            //{
               
            //}
           
            
            //Paleta retorno=(sbyte)cantidad;

            //for (int x = 0; x < Auxiliar._tempera.Length; x++)
            //{
            //    if(!Auxiliar._tempera[x].Equals(null))
            //    retorno._tempera[x]=Auxiliar._tempera[x];
			 
            //}
           Paleta retornoAux=(sbyte) Paleta.Ocupados(Auxiliar);
           for (int i = 0; i < retornoAux._CantidadMaximaColores; i++)
           {
               retornoAux += Auxiliar._tempera[i];
               
           }   
            return retornoAux;
        }

        //private static Paleta agregoColores(Paleta P1, Paleta P2)
        //{
        //    Paleta Auxiliar = (sbyte)(P1._CantidadMaximaColores + P2._CantidadMaximaColores);
        //    for (int x = 0; x < P2._CantidadMaximaColores; x++)
        //    {
        //        if (P1 == P2._tempera[x])
        //        {
        //            int index = (P2._tempera[x] == P1);
        //            Auxiliar += P1._tempera[index] + P2._tempera[x];
        //        }
        //        else
        //        {
        //            Auxiliar += P2._tempera[x];
        //        }

        //    }    
        //        for (int x = 0; x < P1._CantidadMaximaColores; x++)
        //    {
        //        if (P2 == P1._tempera[x])
        //        {
        //            int index = (P1._tempera[x] == P2);
        //            Auxiliar += P2._tempera[index] + P1._tempera[x];
        //        }
        //        else
        //        {
        //            Auxiliar += P1._tempera[x];
        //        }

        //    }
        //    return Auxiliar;
        //}

        #endregion
        
        
        
        /* 
         * + paleta paleta suma 
         * 
         * se agregan siempre y cuando no sean == y se suman si corresponde marca y color
         * 
         * - paleta tempera
         * 
         * se saca una tempera de la paleta ==null 
         * 
         */

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17Generics
{
    public class MiLista<T>:IEnumerable<T>

    {
        T[] _lista;
       

        public MiLista()
        {
            this._lista = new T[0];
            
           
            

        }

        public int Count 
        { 
            get {return this._lista.Length  ;} 
            
        }

        public bool Add(T itemm)
        {

            Array.Resize(ref this._lista, this.Count + 1);
            this._lista[this.Count-1] = itemm;
                return true;
             
        }

        public  bool Remove(T itemm)

        {
            int indice = Array.IndexOf(this._lista, itemm);

            if (indice != -1)
            {
                for (int i = indice; i < this.Count -1 ; i++)
                {
                    this._lista[i] = this._lista[i + 1];
                }
                Array.Resize(ref this._lista, this.Count - 1);
            }

            return true;       
        }








        public IEnumerator<T> GetEnumerator()
        {
            
            for (int i = 0; i < this.Count; i++)
            {
               yield return this._lista[i];
                
            }
           

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

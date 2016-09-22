using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1

{
    public class Empleado
    {
        #region atributos
         string _nombre;
         string _apellido;
         string _legajo;
         EPuestoJerarquico _puesto;
         int _salario;
        
        #endregion
        #region Property
         public string Legajo
         {
             get
             {
                 return this._legajo;
             }
             //set {}
         }
        #endregion
        #region Constructores

        public Empleado(string nombre, string apellido,string legajo,
                         EPuestoJerarquico puesto,int salario)
        {
            this._nombre=nombre;
            this._apellido=apellido;
            this._legajo=legajo;
            this._puesto=puesto;
            this._salario=salario;

        }


        public static bool operator ==(Empleado E1, Empleado E2)
        {
            return E1._legajo==E2._legajo;
        
        }

        public static bool operator !=(Empleado E1, Empleado E2)
        {
            return !(E1==E2);
        }

        public string Mostrar()
        {
            return  this._nombre + "-"+ this._apellido+"-"+this._legajo+"-"+this._puesto.ToString() + "-" +
                            this._salario.ToString();
        }

        #endregion


    }
}

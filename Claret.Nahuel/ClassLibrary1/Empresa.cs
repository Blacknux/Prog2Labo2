using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Empresa
    {
        #region atributos


        /*
      _nominaEmpleados del tipo lista de empleados, privado y de instancia.
_razonSocial del tipo string, privado y de instancia. Generar Property.
_direccion del tipo string, privado y de instancia. Generar Property.
_ganancias del tipo float, privado y de instancia. Generar Property.
      
      */

        List<Empleado> _nominaEmpleados;
        string _razonSocial;
        string _direccion;
        float _ganancias;
        
        #endregion
        #region Properties

        public string razonSocial
        {
            get
            {
                return this._razonSocial;
            }
            set
            {
                this._razonSocial = value;
            }
        }

        public string direccion
        {
            get
            {
                return this._direccion;
            }
            set
            {
                this._direccion = value;

            }
        }

        public float ganancias 
        {
            get
            {
                return this._ganancias;
            }
            set 
            {
                this._ganancias = value;
                            }


        }

        #endregion
        #region Contructores
        /*
         Codificar un constructor privado por defecto. Este será el único lugar donde se instanciará la nómina de empleados.
         Codificar otro constructor que reciba como parámetro la razón social, dirección y ganancias de la Empresa.*/

        private Empresa()
        {
            this._nominaEmpleados = new List<Empleado>();

        }
        public Empresa(string razonSocial, string direccion, float ganancias)
            : this()
        {
            this.razonSocial = razonSocial;
            this.direccion = direccion;
            this.ganancias = ganancias;
        }

        #endregion
        #region Sobrecargas
        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            bool flag=false;

            int cantidad = empresa._nominaEmpleados.Count;
            for (int i = 0; i < cantidad; i++)
            {

                if(empleado.Legajo ==empresa._nominaEmpleados[i].Legajo)
                {
                    flag=true;
                    break;
                }
                
            }
            if(flag==false)
            {
                empresa._nominaEmpleados.Add(empleado);
            }
            return empresa;
        }
        #endregion
    }
}

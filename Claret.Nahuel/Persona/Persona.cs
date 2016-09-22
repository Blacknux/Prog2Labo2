using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paciente
{
   
    public class Persona
    {

        public string name { get { return name; } set { name = value; } }
        public string lastName { get { return lastName; } set { lastName = value; } }
        public int years { get; set; }
        public string dni { get; set; }

        #region Constructors

        public Persona()
        {
            this.name = "";
            this.lastName = "";
            this.years = 0;
            this.dni = "";
        }

        public Persona(string name, string lastName, int years, string dni)
        {
            this.name = name;
            this.lastName = lastName;
            this.years = years;
            this.dni = dni;
        }
        #endregion
        
    }
}

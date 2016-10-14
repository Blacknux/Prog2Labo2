using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15Campus
{
    public class ExceptionParser:Exception
    {
        public ExceptionParser(string m, Exception innerexception)
            : base(m, innerexception)
        { 
        
        }

        public override string ToString()
        {
            return this.InnerException.ToString() + this.Message;
        }
            
    }
}

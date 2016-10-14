using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15Campus
{
    static class Parser
    {


        public static bool TryParce(string numeroS, out int outt)
        {
            try
            {
                return Int32.TryParse(numeroS, out outt);
            }
            catch (FormatException e)
            {
                throw new ExceptionParser("error de formato", e);
            }
            catch (OverflowException e)
            {
                throw new ExceptionParser("very big", e);
            }
        }



        public static int Parse(string stringg)
        {
            try
            {
                return int.Parse(stringg);
            }
            catch (FormatException e)
            {
                throw new ExceptionParser("error de formato", e);
            }
            catch (OverflowException e)
            {
                throw new ExceptionParser("very big", e);
            }
        }
    }
    

}
    
